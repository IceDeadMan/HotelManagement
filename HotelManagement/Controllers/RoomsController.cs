using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class RoomsController : Controller
    {
        private readonly ILogger<RoomsController> _logger;
        private readonly RoomRepository _roomRepository;

        public RoomsController(ILogger<RoomsController> logger, RoomRepository roomRepository)
        {
            _logger = logger;
            _roomRepository = roomRepository;
        }

        public async Task<IActionResult> RoomsList()
        {
            var rooms = await _roomRepository.GetAllAsync();
            return View(rooms);
        }

		public async Task<IActionResult> RoomDetails(Guid id)
		{
			var room = await _context.Rooms
				.Include(r => r.Bookings)
				.FirstOrDefaultAsync(r => r.Id == id);
			if (room == null)
			{
				return NotFound();
			}
			return View(room);
		}

	}
}
