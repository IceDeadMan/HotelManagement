using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;


namespace HotelManagement.Controllers
{
    /// <summary>
    /// EventsController handles the management of events in the hotel.
    /// It allows users to view and attend events, as well as create and delete events for staff and managers.
    /// </summary>
    public class EventsController : Controller
    {
        private readonly ILogger<EventsController> _logger;
        private readonly EventRepository _eventRepository;

        public EventsController(ILogger<EventsController> logger, EventRepository eventRepository)
        {
            _logger = logger;
            _eventRepository = eventRepository;
        }

        /// <summary>
        /// EventsList displays a list of all events.
        /// </summary>
        public async Task<IActionResult> EventsList()
        {
            var events = await _eventRepository.GetAllAsync();
            return View(events);
        }

        /// <summary>
        /// CreateEvent allows staff and managers to create a new event.
        /// It takes the event details as parameters and creates a new event in the database.
        /// </summary>
        /// <param name="Name">The name of the event.</param>
        /// <param name="Description">The description of the event.</param>
        /// <param name="DatePart">The date part of the event.</param>
        /// <param name="TimePart">The time part of the event.</param>
        /// <param name="Capacity">The capacity of the event.</param>
        /// <returns>Redirects to the EventsList view after creating the event.</returns>
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

        /// <summary>
        /// DeleteEvent allows staff and managers to delete an event.
        /// It takes the event ID as a parameter and deletes the event from the database.
        /// </summary>
        /// <param name="id">The ID of the event to delete.</param>
        /// <returns>Redirects to the EventsList view after deleting the event.</returns>
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
