using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
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

        public async Task<IActionResult> RoomsList()
        {
            var rooms = await _roomRepository.GetAllRoomsWithDetailAsync();
            return View(rooms);
        }

		public async Task<IActionResult> RoomDetails(Guid id)
		{
            var room = await _roomRepository.GetRoomWithDetailsAsync(id);

			if (room == null)
			{
				return NotFound();
			}
			return View(room);
		}

		public async Task<IActionResult> AvailableRooms(DateTime start, DateTime end, Guid roomTypeId)
		{
			// this is not using the IsRoomAvailableAsync method since filtering the rooms in memory should be better for performance
			var allRoomTypes = await _roomTypeRepository.GetAllAsync();
			var rooms = await _roomRepository.GetAllRoomsWithDetailAsync();
			var cart = _bookingCartService.GetCart();
			var roomIdsInCart = cart.RoomIds;
			var startCart = cart.StartDate;
			var endCart = cart.EndDate;

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
			return View("~/Views/Bookings/StartBooking.cshtml", allRoomTypes); // ← Render the StartBooking view again
		}
	}
}
