using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelManagement.Services;
using HotelManagement.Models.DTOs;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace HotelManagement.Controllers
{
	public class BookingsController : Controller
	{
		private readonly ILogger<BookingsController> _logger;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;
		private readonly RoomRepository _roomRepository;
		private readonly BookingRepository _bookingRepository;

		public BookingsController(
			ILogger<BookingsController> logger,
			RoomTypeRepository roomTypeRepository,
			BookingCartService bookingCartService,
			RoomRepository roomRepository,
			BookingRepository bookingRepository)
		{
			_logger = logger;
			_roomTypeRepository = roomTypeRepository;
			_bookingCartService = bookingCartService;
			_roomRepository = roomRepository;
			_bookingRepository = bookingRepository;
		}

		// View for starting a new booking with filters
		[Authorize]
		public async Task<IActionResult> StartBooking()
		{
			var cart = _bookingCartService.GetCart();
			var roomIdsInCart = cart.RoomIds;
			var startCart = cart.StartDate;
			var endCart = cart.EndDate;
			var roomTypes = await _roomTypeRepository.GetAllAsync();
			ViewBag.RoomIdsInCart = roomIdsInCart;
			ViewBag.StartCart = startCart;
			ViewBag.EndCart = endCart;
			return View(roomTypes);
		}

		// Add room to booking cart
		[HttpPost]
		[Authorize]
		public IActionResult AddToBookingCart([FromBody] BookingRequest dto)
		{
			if (dto.StartDate > dto.EndDate)
			{
				return BadRequest("Invalid date range.");
			}

			var cart = _bookingCartService.GetCart();

			if (cart.RoomIds.Count == 0)
			{
				cart.StartDate = dto.StartDate;
				cart.EndDate = dto.EndDate;
			}
			else if (cart.StartDate != dto.StartDate || cart.EndDate != dto.EndDate)
			{
				return BadRequest("Stay duration must be the same for all rooms.");
			}
			if (!cart.RoomIds.Contains(dto.RoomId))
			{
				cart.RoomIds.Add(dto.RoomId);
			}

			_bookingCartService.SaveCart(cart);
			return Json(new { success = true });
		}

		[HttpPost]
		[Authorize]
		public IActionResult RemoveFromBookingCart([FromBody] BookingRequest dto)
		{
			Console.WriteLine($"Removing Room: {dto.RoomId}");
			var cart = _bookingCartService.GetCart();
			if (cart.RoomIds.Contains(dto.RoomId))
			{
				Console.WriteLine($"Removing Room: {dto.RoomId}");
				cart.RoomIds.Remove(dto.RoomId);
				_bookingCartService.SaveCart(cart);
			}
			return Json(new { success = true });
		}

		// Proceed to checkout
		[Authorize]
		public IActionResult BookingCart()
		{
			var cart = _bookingCartService.GetCart();

			var roomDetails = new List<(Room room, RoomType roomType)>();

			foreach (var roomId in cart.RoomIds)
			{
				var room = _roomRepository.GetById(roomId);
				if (room == null) continue;

				var roomType = _roomTypeRepository.GetById(room.RoomTypeId);
				if (roomType == null) continue;

				roomDetails.Add((room, roomType));
			}

			ViewBag.StartDate = cart.StartDate;
			ViewBag.EndDate = cart.EndDate;
			ViewBag.RoomDetails = roomDetails;

			int nights = (cart.EndDate - cart.StartDate).Days;
			ViewBag.Nights = nights;
			ViewBag.TotalPrice = roomDetails.Sum(r => r.roomType.Price * nights);

			return View("BookingCart");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> FinalizeBooking()
		{
			var cart = _bookingCartService.GetCart();

			if (cart.RoomIds.Count == 0)
			{
				TempData["Error"] = "Your booking cart is empty.";
				return RedirectToAction("BookingCart");
			}

			var rooms = await _roomRepository.GetRoomsByIdsAsync(cart.RoomIds);

			// Check if all rooms are still available in the given date range
			var unavailableRooms = new List<Room>();
			foreach (var room in rooms)
			{
				bool isAvailable = await _roomRepository.IsRoomAvailableAsync(room.Id, cart.StartDate, cart.EndDate);
				if (!isAvailable)
				{
					unavailableRooms.Add(room);
				}
			}

			if (unavailableRooms.Any())
			{
				var names = string.Join(", ", unavailableRooms.Select(r => r.RoomNumber ?? $"Room {r.Id}"));
				TempData["Error"] = $"Sorry, the following room(s) are no longer available: {names}. Please update your booking.";
				return RedirectToAction("BookingCart");
			}

			var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

			var booking = new Booking
			{
				StartDate = cart.StartDate,
				EndDate = cart.EndDate,
				Status = BookingStatus.Pending,
				ApplicationUserId = userId,
				Rooms = rooms
			};

			_bookingRepository.Create(booking);
			_bookingCartService.ClearCart();

			TempData["Success"] = "Booking finalized successfully!";
			return View("BookingConfirmation", booking);
		}


		// View for user bookings
		[Authorize]
		public async Task<IActionResult> MyBookings()
		{
			var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier); // Retrieves logged-in user's ID

			if (!Guid.TryParse(userIdString, out Guid userId))
			{
				// User not logged in or invalid ID
				return RedirectToAction("Login", "Account"); // Optional fallback
			}

			var bookings = await _bookingRepository.GetBookingsByUserIdAsync(userId);

			return View(bookings);
		}

		[Authorize]
		public async Task<IActionResult> BookingDetails(Guid id)
		{
			var booking = await _bookingRepository.GetBookingAsync(id);
			
			if (booking == null)
				return NotFound();

			var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
			if (booking.ApplicationUserId != userId)
				return Forbid();

			return View(booking);
		}
	}
}

