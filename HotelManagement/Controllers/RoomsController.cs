using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
	/// <summary>
	/// RoomsController handles the management of hotel rooms.
	/// It allows users to view a list of all rooms, room details, and available rooms based on selected criteria.
	/// </summary>
    public class RoomsController : Controller
	{
		private readonly ILogger<RoomsController> _logger;
		private readonly RoomRepository _roomRepository;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;

		public RoomsController(ILogger<RoomsController> logger, RoomRepository roomRepository, RoomTypeRepository roomTypeRepository, BookingCartService bookingCartService)
		{
			_logger = logger;
			_roomRepository = roomRepository;
			_roomTypeRepository = roomTypeRepository;
			_bookingCartService = bookingCartService;
		}

		/// <summary>
		/// RoomsList displays a list of all rooms with their details.
		/// </summary>
		/// <returns> A view with all rooms and their details. </returns>
		public async Task<IActionResult> RoomsList()
		{
			var rooms = await _roomRepository.GetAllRoomsWithDetailAsync();
			return View(rooms);
		}
		/// <summary>
		/// RoomDetails displays the details of a specific room based on its ID.
		/// </summary>
		public async Task<IActionResult> RoomDetails(Guid id)
		{
			var room = await _roomRepository.GetRoomWithDetailsAsync(id);

			if (room == null)
			{
				return NotFound();
			}
			return View(room);
		}

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
			var roomIdsInCart = cart.RoomIds;
			var startCart = cart.StartDate;
			var endCart = cart.EndDate;

			// this is not using the IsRoomAvailableAsync method since filtering the rooms in memory should be better for performance
			var availableRooms = rooms
				.Where(r => (roomTypeId == Guid.Empty || r.RoomTypeId == roomTypeId) &&
							!r.Bookings.Any(b => b.StartDate < end && b.EndDate > start))
				.ToList();

			ViewBag.AvailableRooms = availableRooms;
			ViewBag.StartDate = start.ToString("yyyy-MM-dd");
			ViewBag.EndDate = end.ToString("yyyy-MM-dd");
			ViewBag.SelectedRoomTypeId = roomTypeId;
			ViewBag.AvailableRooms = availableRooms;
			ViewBag.RoomIdsInCart = roomIdsInCart;
			ViewBag.StartCart = startCart;
			ViewBag.EndCart = endCart;
			return View("~/Views/Bookings/StartBooking.cshtml", allRoomTypes);
		}
	}
}
