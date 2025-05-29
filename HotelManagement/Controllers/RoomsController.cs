using HotelManagement.DAL.Repositories;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels;

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
				return NotFound();

			var viewModel = new RoomDetailViewModel
			{
				RoomNumber = room.RoomNumber!,
				Description = room.Description!,
				RoomTypeName = room.RoomType?.Name ?? "",
				RoomTypeDescription = room.RoomType?.Description ?? "",
				RoomTypePrice = room.RoomType?.Price ?? 0,
				RoomTypeCapacity = room.RoomType?.Capacity ?? 0,
				Bookings = room.Bookings.Select(b => new BookingSummaryViewModel
				{
					GuestName = b.ApplicationUser?.UserName ?? "Unknown",
					StartDate = b.StartDate,
					EndDate = b.EndDate
				}).ToList(),
				Reviews = room.Reviews.Select(r => new ReviewViewModel
				{
					ReviewerUsername = r.ApplicationUser?.UserName ?? "Anonymous",
					Rating = r.Rating,
					Comment = r.Comment,
					ReviewDate = r.ReviewDate
				}).ToList()
			};

			return View(viewModel);
		}
	}
}
