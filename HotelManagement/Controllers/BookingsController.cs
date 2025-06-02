using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services;
using HotelManagement.Models.DTOs;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using HotelManagement.ViewModels;
using HotelManagement.Logging;


namespace HotelManagement.Controllers
{
	/// <summary>
	/// BookingsController handles the booking process, including adding rooms to the booking cart,
	/// finalizing bookings, and viewing user bookings.
	/// It uses the BookingCartService to manage the booking cart and interacts with the RoomTypeRepository,
	/// RoomRepository, and BookingRepository to retrieve and manipulate data.
	/// </summary>
	public class BookingsController : Controller
	{
		private readonly AuditLogger _auditLogger;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;
		private readonly RoomRepository _roomRepository;
		private readonly BookingRepository _bookingRepository;
		private readonly ReviewRepository _reviewRepository;

		public BookingsController(
			AuditLogger auditLogger,
			RoomTypeRepository roomTypeRepository,
			BookingCartService bookingCartService,
			RoomRepository roomRepository,
			BookingRepository bookingRepository,
			ReviewRepository reviewRepository)
		{
			_auditLogger = auditLogger;
			_roomTypeRepository = roomTypeRepository;
			_bookingCartService = bookingCartService;
			_roomRepository = roomRepository;
			_bookingRepository = bookingRepository;
			_reviewRepository = reviewRepository;
		}

		/// <summary>
		/// StartBooking initializes the booking process by retrieving all room types.
		/// </summary>
		/// <returns> A view with all room types and the current booking cart details. </returns>
		[Authorize]
		public async Task<IActionResult> StartBooking()
		{
			var cart = _bookingCartService.GetCart();
			var roomTypes = await _roomTypeRepository.GetAllAsync();

			var viewModel = new StartBookingViewModel
			{
				RoomTypes = roomTypes.ToList(),
				SelectedRoomTypeId = Guid.Empty, // Default to no room type selected
				Cart = cart
			};

			return View(viewModel);
		}

		/// <summary>
		/// AddToBookingCart adds a room to the booking.
		/// It checks if the room is already in the cart and if the stay duration is consistent.
		/// </summary>
		/// <param name="dto"> The booking request containing room ID and date range. </param>
		/// <returns> A JSON response indicating success or failure. </returns>
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
				_auditLogger.Log("AddToCart", $"Room {dto.RoomId} successfully added to the booking cart.");
			}

			_bookingCartService.SaveCart(cart);
			return Json(new { success = true });
		}

		/// <summary>
		/// RemoveFromBookingCart removes a room from the booking cart.
		/// </summary>
		/// <param name="dto"> The booking request containing room ID. </param>
		/// <returns> A JSON response indicating success. </returns>
		[HttpPost]
		[Authorize]
		public IActionResult RemoveFromBookingCart([FromBody] BookingRequest dto)
		{
			var cart = _bookingCartService.GetCart();
			if (cart.RoomIds.Contains(dto.RoomId))
			{
				cart.RoomIds.Remove(dto.RoomId);
                _auditLogger.Log("AddToCart", $"Room {dto.RoomId} successfully removed from the booking cart.");
                _bookingCartService.SaveCart(cart);
			}
			return Json(new { success = true });
		}

		/// <summary>
		/// BookingCart displays the current booking cart details.
		/// It retrieves the room details and calculates the total price based on the selected rooms and stay duration.
		/// </summary>
		/// <returns> A view with the booking cart details. </returns>
		[Authorize]
		public IActionResult BookingCart()
		{
			var cart = _bookingCartService.GetCart();

			var viewModel = new BookingCartViewModel
			{
				StartDate = cart.StartDate,
				EndDate = cart.EndDate
			};

			viewModel.Nights = (cart.EndDate - cart.StartDate).Days;

			foreach (var roomId in cart.RoomIds)
			{
				var room = _roomRepository.GetById(roomId);
				if (room == null) continue;

				var roomType = _roomTypeRepository.GetById(room.RoomTypeId);
				if (roomType == null) continue;

				var item = new BookingCartViewModel.RoomCartItem
				{
					RoomId = room.Id.ToString(),
					RoomNumber = room.RoomNumber,
					RoomTypeDescription = roomType.Description,
					Capacity = roomType.Capacity,
					PricePerNight = roomType.Price,
					Subtotal = roomType.Price * viewModel.Nights
				};

				viewModel.RoomDetails.Add(item);
			}

			viewModel.TotalPrice = viewModel.RoomDetails.Sum(i => i.Subtotal);

			return View("BookingCart", viewModel);
		}



		/// <summary>
		/// FinalizeBooking processes the booking by checking room availability and creating a booking record.
		/// </summary>
		/// <returns> A view with the booking confirmation or an error message. </returns>
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
			_auditLogger.Log("FinalizeBooking", "Booking successfully finalized.");

			TempData["Success"] = "Booking finalized successfully!";
			return View("BookingConfirmation", booking);
		}


		/// <summary>
		/// MyBookings retrieves the bookings made by the logged-in user.
		/// </summary>
		/// <returns> A view with the user's bookings. </returns>
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

		/// <summary>
		/// BookingDetails retrieves the details of a specific booking.
		/// </summary>
		/// <param name="id"> The ID of the booking. </param>
		/// <returns> A view with the booking details or a not found error. </returns>
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

		/// <summary>
		/// BookingRoomDetails retrieves the details of a specific room ina current booking viewed by the user.
		/// It includes the booking details, food orders, activity records, and user review for that room.
		/// </summary>
		/// <param name="roomId"> The ID of the room. </param>
		/// <param name="bookingId"> The ID of the booking. </param>
		/// <returns> A view with the room details, booking information, food orders, activity records, and user review. </returns>
		[HttpGet]
		[Authorize]
		public async Task<IActionResult> BookingRoomDetails(Guid roomId, Guid bookingId)

		{
			var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

			var booking = await _bookingRepository.GetBookingAsync(bookingId);

			var room = await _roomRepository.GetRoomWithDetailsAsync(roomId);
			if (room == null)
				return NotFound();

			// Filter room's food orders and activity records by booking date range and user
			var filteredFoodOrders = room.FoodOrders
				.Where(o => o.ApplicationUserId == userId && o.OrderDate >= booking.StartDate && o.OrderDate <= booking.EndDate)
				.OrderByDescending(o => o.OrderDate)
				.ToList();

			var filteredActivities = room.ActivityRecords
				.Where(a => a.ApplicationUserId == userId && a.Date >= booking.StartDate && a.Date <= booking.EndDate)
				.OrderByDescending(a => a.Date)
				.ToList();

			// Get the user's single review for this room (editable)
			var review = room.Reviews
				.FirstOrDefault(r => r.ApplicationUserId == userId);

			var model = new BookingRoomDetailViewModel
			{
				Room = room,
				Booking = booking,
				FoodOrders = filteredFoodOrders,
				ActivityRecords = filteredActivities,
				Review = review
			};

			return View(model);
		}

		/// <summary>
		/// Reception displays the reception view with all bookings categorized by their status.
		/// It includes today's bookings, ongoing bookings, bookings before check-in, and past or cancelled bookings.
		/// </summary>
		/// <returns> A view with categorized booking summaries for the reception desk. </returns>
		[Authorize(Roles = "Manager,Receptionist")]
		public async Task<IActionResult> Reception()
		{
			var allBookings = await _bookingRepository.GetBookingSummariesAsync();
			var today = DateTime.Today;

			var viewModel = new ReceptionViewModel
			{
				TodaysBookings = allBookings
					.Where(b =>
						(b.StartDate.Date == today && b.Status == BookingStatus.Pending) ||
						(b.EndDate.Date == today && (b.Status == BookingStatus.Confirmed)))// or Pending for now
					.ToList(),

				OngoingBookings = allBookings
					.Where(b =>
						b.Status == BookingStatus.Confirmed &&
						(
							(b.StartDate.Date < today && b.EndDate.Date > today) ||
							(b.StartDate.Date == today) // Just checked in today
						))
					.ToList(),

				BeforeCheckIn = allBookings
					.Where(b =>
						(b.Status == BookingStatus.Pending) &&
						b.StartDate.Date > today)
					.ToList(),

				PastOrCancelledBookings = allBookings
					.Where(b =>
						b.Status == BookingStatus.Completed ||
						b.Status == BookingStatus.Cancelled )
					.ToList()
			};

			return View(viewModel);
		}


		/// <summary>
		/// ChangeStatus allows authorized users to change the status of a booking.
		/// Should be used by receptionist to chek in and check out bookings or cancel bookings.
		/// </summary>
		[HttpPost]
		[Authorize(Roles = "Manager,Receptionist")]
		public async Task<IActionResult> ChangeStatus(Guid id, BookingStatus newStatus)
		{
			await _bookingRepository.ChangeStatusAsync(id, newStatus);
			_auditLogger.Log("ChangeBookingStatus", $"Booking {id} has changed status to {newStatus}");
			return RedirectToAction(nameof(Reception));
		}
		
		/// <summary>
		/// CancelBooking allows users to cancel their own bookings.
		/// It checks if the booking exists, if the user is the owner, and if the booking status is pending.
		/// /// </summary>
		[HttpPost]
		[Authorize]
		public async Task<IActionResult> CancelBooking(Guid id)
		{
			var booking = _bookingRepository.GetById(id);
			if (booking == null)
			{
				return NotFound();
			}

			// Ensure the logged-in user is the owner of the booking
			var currentUserId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (booking.ApplicationUserId.ToString() != currentUserId)
			{
				return Forbid(); // User is not allowed to cancel someone else's booking
			}

			if (booking.Status != BookingStatus.Pending)
			{
				TempData["Error"] = "Only pending bookings can be cancelled.";
				return RedirectToAction("MyBookings");
			}

			await _bookingRepository.ChangeStatusAsync(id, BookingStatus.Cancelled);
			_auditLogger.Log("CancelBooking", $"Booking {id} successfully cancelled.");

			TempData["Success"] = "Booking cancelled successfully.";
			return RedirectToAction("MyBookings");
		}

		/// <summary>
		/// Delete removes a booking by its ID.
		/// This action is restricted to authorized users with specific roles.
		/// </summary>
		/// <param name="id"> The ID of the booking to be deleted. </param>
		/// <returns> A redirect to the reception view after deletion. </returns>
		// [HttpPost]
		// [Authorize(Roles = "Manager,Receptionist")]
		// public IActionResult Delete(Guid id)
		// {
		// 	_bookingRepository.Delete(id);
		// 	return RedirectToAction(nameof(Reception));
		// }

		/// <summary>
		/// AvailableRooms displays a list of available rooms based on the selected criteria - room type and stay duration.
		/// If filters out the rooms that are already booked during the selected dates.
		/// /</summary>
		/// <param name="start">The start date of the stay.</param>
		/// <param name="end">The end date of the stay.</param>
		/// <param name="roomTypeId">The ID of the selected room type.</param>
		/// <returns> A view with available rooms based on the selected criteria. </returns>
		public async Task<IActionResult> AvailableRooms(DateTime start, DateTime end, Guid roomTypeId)
		{

			var allRoomTypes = await _roomTypeRepository.GetAllAsync();
			var rooms = await _roomRepository.GetAllRoomsWithDetailAsync();
			var cart = _bookingCartService.GetCart();

			// this is not using the IsRoomAvailableAsync method since filtering the rooms in memory should be better for performance
			var availableRooms = rooms
				.Where(r => (roomTypeId == Guid.Empty || r.RoomTypeId == roomTypeId) &&
							!r.Bookings.Any(b => b.StartDate < end && b.EndDate > start))
				.ToList();

			var viewModel = new StartBookingViewModel
			{
				RoomTypes = allRoomTypes.ToList(),
				SelectedRoomTypeId = roomTypeId,
				StartDate = start.ToString("yyyy-MM-dd"),
				EndDate = end.ToString("yyyy-MM-dd"),
				Cart = cart,
				AvailableRooms = availableRooms
			};

			return View("StartBooking", viewModel);
		}
	}
}

