using HotelManagement.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    public class RoomsController : Controller
    {
        private readonly ILogger<RoomsController> _logger;
        private readonly HotelManagementDbContext _context;

        public RoomsController(ILogger<RoomsController> logger, HotelManagementDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> RoomsList()
        {
            var rooms = await _context.Rooms.ToListAsync();
            return View(rooms);
        }
    }
}
