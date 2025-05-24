using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelManagement.Services;
using HotelManagement.Models.DTOs;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using HotelManagement.ViewModels;


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
		private readonly ILogger<BookingsController> _logger;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;
		private readonly RoomRepository _roomRepository;
		private readonly BookingRepository _bookingRepository;
		private readonly ReviewRepository _reviewRepository;

		public BookingsController(
			ILogger<BookingsController> logger,
			RoomTypeRepository roomTypeRepository,
			BookingCartService bookingCartService,
			RoomRepository roomRepository,
			BookingRepository bookingRepository,
			ReviewRepository reviewRepository)
		{
			_logger = logger;
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
			var roomIdsInCart = cart.RoomIds;
			var startCart = cart.StartDate;
			var endCart = cart.EndDate;
			var roomTypes = await _roomTypeRepository.GetAllAsync();
			ViewBag.RoomIdsInCart = roomIdsInCart;
			ViewBag.StartCart = startCart;
			ViewBag.EndCart = endCart;
			return View(roomTypes);
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
		[HttpPost]
		[Authorize]
		[ValidateAntiForgeryToken]
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
		/// AddRoomReview allows a user to submit a review for a room they have booked.
		/// </summary>
		/// <param name="RoomId"> The ID of the room being reviewed. </param>
		/// <param name="Rating"> The rating given by the user (1-5). </param>
		/// <param name="Comment"> The comment provided by the user. </param>
		/// <returns> A redirect to the BookingRoomDetails view with a success message. </returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public IActionResult AddRoomReview(Guid RoomId, int Rating, string Comment)
		{
			// Review actions are here for now, maybe create a separate ReviewsController later
			// if we want to manage reviews separately and delete them, etc.
			var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

			var review = new Review
			{
				Id = Guid.NewGuid(),
				RoomId = RoomId,
				ApplicationUserId = userId,
				Rating = Rating,
				Comment = Comment,
				ReviewDate = DateTime.UtcNow
			};

			_reviewRepository.Create(review);

			TempData["SuccessMessage"] = "Review submitted successfully.";

			return Json(new { success = true, message = "Review submitted successfully." });
		}

		/// <summary>
		/// EditRoomReview allows a user to edit their existing review for a room.
		/// Each user can post only one review per room, so this updates the existing review.
		/// </summary>
		/// <param name="ReviewId"> The ID of the review being edited. </param>
		/// <param name="Rating"> The new rating given by the user (1-5). </param>
		/// <param name="Comment"> The new comment provided by the user. </param>
		/// /// <returns> A redirect to the BookingRoomDetails view with a success message. </returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public IActionResult EditRoomReview(Guid ReviewId, int Rating, string Comment)
		{
			var review = _reviewRepository.GetById(ReviewId);
			if (review == null || review.ApplicationUserId != Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)))
				return NotFound();

			review.Rating = Rating;
			review.Comment = Comment;
			review.ReviewDate = DateTime.UtcNow;

			_reviewRepository.Update(review);

			TempData["SuccessMessage"] = "Review updated successfully.";

			return Json(new { success = true, message = "Review updated successfully." });
		}

		
	}
}

