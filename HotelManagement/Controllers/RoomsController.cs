using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels;
using AutoMapper;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using HotelManagement.Logging;

namespace HotelManagement.Controllers
{
	/// <summary>
	/// RoomsController handles the management of hotel rooms.
	/// It allows users to view a list of all rooms, room details, and available rooms based on selected criteria.
	/// </summary>
	public class RoomsController : Controller
	{
        private readonly AuditLogger _auditLogger;
        private readonly RoomRepository _roomRepository;
		private readonly RoomTypeRepository _roomTypeRepository;
		private readonly BookingCartService _bookingCartService;
		private readonly IMapper _mapper;

		public RoomsController(AuditLogger auditLogger, RoomRepository roomRepository,
								RoomTypeRepository roomTypeRepository, BookingCartService bookingCartService,
								IMapper mapper)
		{
            _auditLogger = auditLogger;
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
			var roomTypes = await _roomTypeRepository.GetAllAsync();
			
			// todo mapper
			var viewModel = new RoomsListViewModel
			{
				Rooms = _mapper.Map<List<Room>>(rooms),
				RoomTypes = _mapper.Map<List<RoomType>>(roomTypes)
			};

            _auditLogger.Log("RoomsList", "Rooms list viewed.");
            return View(viewModel);
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

			_auditLogger.Log("RoomDetails", $"Room {id} details viewed.");
            return View(viewModel);
		}

		/// <summary>
		/// Manager can create a new room.
		/// </summary>:
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = "Manager")]
		public IActionResult Create(Room room)
		{
			if (ModelState.IsValid)
			{
				_roomRepository.Create(room);
                _auditLogger.Log("CreateRoom", $"Room {room.Id} created successfully.");
				TempData["Success"] = "Room created successfully.";
				return RedirectToAction("RoomsList");
			}
			TempData["Error"] = "Failed to create room.";
			_auditLogger.Log("CreateRoom", "Room creation failed due to invalid model state.");
            return RedirectToAction("RoomsList");
		}

		/// <summary>
		/// Manager can delete a room.
		/// </summary>
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = "Manager")]
		public IActionResult Delete(Guid id)
		{
			var room = _roomRepository.GetById(id);
			if (room != null)
			{
				_roomRepository.Delete(id);
                _auditLogger.Log("DeleteRoom", $"Room {id} deleted successfully.");
				TempData["Success"] = "Room deleted successfully.";
			}
			else
			{
				TempData["Error"] = "Room not found.";
			}
			return RedirectToAction("RoomsList");
		}
	}
}
