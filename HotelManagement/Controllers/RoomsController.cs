using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels;
using AutoMapper;

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
		private readonly IMapper _mapper;

        public RoomsController(ILogger<RoomsController> logger, RoomRepository roomRepository,
								RoomTypeRepository roomTypeRepository, BookingCartService bookingCartService,
								IMapper mapper)
        {
            _logger = logger;
            _roomRepository = roomRepository;
            _roomTypeRepository = roomTypeRepository;
            _bookingCartService = bookingCartService;
            _mapper = mapper;
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
				return NotFound();

            var viewModel = _mapper.Map<RoomDetailViewModel>(room);
            viewModel.Bookings = _mapper.Map<List<BookingSummaryViewModel>>(room.Bookings);
            viewModel.Reviews = _mapper.Map<List<ReviewViewModel>>(room.Reviews);

            return View(viewModel);
		}
	}
}
