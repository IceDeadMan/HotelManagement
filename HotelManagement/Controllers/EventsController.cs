using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class EventsController : Controller
    {
        private readonly ILogger<EventsController> _logger;
        private readonly EventRepository _eventRepository;

        public EventsController(ILogger<EventsController> logger, EventRepository eventRepository)
        {
            _logger = logger;
            _eventRepository = eventRepository;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _eventRepository.GetAllAsync();
            return View(events);
        }
    }
}
