using HotelManagement.DAL.Repositories;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelManagement.Controllers
{
	public class BookingsController : Controller
	{
		private readonly ILogger<BookingsController> _logger;
		private readonly RoomTypeRepository _roomTypeRepository;

		public BookingsController(ILogger<BookingsController> logger, RoomTypeRepository roomTypeRepository)
		{
			_logger = logger;
			_roomTypeRepository = roomTypeRepository;
		}

		// View for starting a new booking with filters
		public async Task<IActionResult> StartBooking()
		{
			var roomTypes = await _roomTypeRepository.GetAllAsync();
			return View(roomTypes);
		}

		//[HttpPost]
		//public async Task<IActionResult> FilterRooms(DateTime startDate, DateTime endDate, RoomType? roomType)
		//{
		//	var availableRooms = await _roomRepository.GetAvailableRoomsAsync(startDate, endDate, roomType);
		//	return PartialView("_RoomCardsPartial", availableRooms);
		//}

	}
}

