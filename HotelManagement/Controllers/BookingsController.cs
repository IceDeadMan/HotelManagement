using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelManagement.Services;
using HotelManagement.Models.DTOs;
using HotelManagement.Models;

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

		//[HttpPost]
		//public async Task<IActionResult> FilterRooms(DateTime startDate, DateTime endDate, RoomType? roomType)
		//{
		//	var availableRooms = await _roomRepository.GetAvailableRoomsAsync(startDate, endDate, roomType);
		//	return PartialView("_RoomCardsPartial", availableRooms);
		//}

		// Add room to booking cart
		[HttpPost]
		public IActionResult AddToBookingCart([FromBody] BookingRequest dto)
		{
			if (dto.StartDate > dto.EndDate)
			{
				return BadRequest("Invalid date range.");
			}

			var cart = _bookingCartService.GetCart();

			_logger.LogInformation("DTO StartDate: {StartDate}, EndDate: {EndDate}", dto.StartDate, dto.EndDate);
			_logger.LogInformation("Room Count: {RoomCount}", cart.RoomIds.Count);
			if (cart.RoomIds.Count == 0)
			{
				cart.StartDate = dto.StartDate;
				cart.EndDate = dto.EndDate;
			}
			else if (cart.StartDate != dto.StartDate || cart.EndDate != dto.EndDate)
			{
				return BadRequest("Stay duration must be the same for all rooms.");
			}
			_logger.LogInformation("Cart start date: {StartDate}, end date: {EndDate}", cart.StartDate, cart.EndDate);
			if (!cart.RoomIds.Contains(dto.RoomId))
			{
				cart.RoomIds.Add(dto.RoomId);
			}

			_bookingCartService.SaveCart(cart);
			return Json(new { success = true });
		}

		[HttpPost]
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
		public IActionResult FinalizeBooking()
		{
			var cart = _bookingCartService.GetCart();

			if (cart.RoomIds.Count == 0)
			{
				TempData["Error"] = "Your booking cart is empty.";
				return RedirectToAction("BookingCart");
			}

			// This is used because the number of rooms in a single booking will generally be low,
			// but we can implement GetRoomsByIds later
			var rooms = cart.RoomIds.Select(id => _roomRepository.GetById(id)).ToList();

			var booking = new Booking
			{
				StartDate = cart.StartDate,
				EndDate = cart.EndDate,
				Status = BookingStatus.Pending,
				// user placeholder - USER1
				ApplicationUserId = Guid.Parse("67019a3d-04de-444b-bb6c-6ef934dcd291"),
				Rooms = rooms
			};

			_bookingRepository.Create(booking);
			// I think repo.save here is not needed as the Create method already saves the changes

			_bookingCartService.ClearCart(); // Clear cart after saving

			TempData["Success"] = "Booking finalized successfully!";
			return View("BookingConfirmation", booking);
		}

	}
}

