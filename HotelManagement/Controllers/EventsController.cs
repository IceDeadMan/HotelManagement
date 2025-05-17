using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;


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

        public async Task<IActionResult> EventsList()
        {
            var events = await _eventRepository.GetAllAsync();
            return View(events);
        }

        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public IActionResult CreateEvent(string Name, string Description, DateTime DatePart, TimeSpan TimePart, int Capacity)
        {
            var fullDateTime = DatePart.Date + TimePart;

            var newEvent = new Event
            {
                Name = Name,
                Description = Description,
                Date = fullDateTime,
                Capacity = Capacity
            };

            _eventRepository.Create(newEvent);

            return RedirectToAction("EventsList");
        }

        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public IActionResult DeleteEvent(Guid id)
        {
            if (_eventRepository.Exists(id))
            {
                _eventRepository.Delete(id);
            }
            else
            {
                ModelState.AddModelError("", "Event not found.");
            }

            return RedirectToAction("EventsList");
        }

    }
}
