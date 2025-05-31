using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using HotelManagement.ViewModels;



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
        private readonly UserManager<ApplicationUser> _userManager;

        public EventsController(ILogger<EventsController> logger, EventRepository eventRepository, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _eventRepository = eventRepository;
            _userManager = userManager;
        }

        /// <summary>
        /// EventsList displays a list of all events.
        /// </summary>
        public async Task<IActionResult> EventsList()
        {
            var currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var events = await _eventRepository.GetAllWithDetailsAsync();
            var isManager = User.IsInRole("Manager");

            var viewModel = new EventListViewModel
            {
                CurrentUserId = currentUserId.ToString(),
                IsManager = isManager,
                Events = events.Select(e => new EventListItemViewModel
                {
                    Event = e,
                    TotalRegisteredParticipants = e.Registrations?.Sum(r => r.NumberOfParticipants) ?? 99,
                    IsUserRegistered = e.Registrations.Any(r => r.UserId == currentUserId),
                    AllAssignableStaff = isManager ? _userManager.GetUsersInRoleAsync("Staff").Result.ToList() : new List<ApplicationUser>(),
                }).ToList()
            };

            return View(viewModel);
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
        [Authorize(Roles = "Manager")]
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
        [Authorize(Roles = "Manager")]
        public IActionResult DeleteEvent(Guid id)
        {
            if (_eventRepository.Exists(id))
            {
                _eventRepository.Delete(id);
            }
            else
            {
                TempData["Error"] = "Event not found.";
            }

            return RedirectToAction("EventsList");
        }

        /// <summary>
        /// RegisterToEvent allows users to register for an event.
        /// It takes the event ID and the number of participants as parameters.
        /// If the event has enough capacity and the user is not already registered, it registers the user.
        /// </summary>
        [HttpPost]
        [Authorize]
        public IActionResult RegisterToEvent(Guid eventId, int numberOfParticipants)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var eventItem = _eventRepository.GetByIdWithDetails(eventId);

            if (eventItem == null)
            {
                TempData["Error"] = "Event not found.";
                return RedirectToAction("EventsList");
            }

            if (eventItem.Capacity < numberOfParticipants)
            {
                TempData["Error"] = "Not enough capacity for the selected number of participants.";
                return RedirectToAction("EventsList");
            }

            if (_eventRepository.IsUserRegisteredToEvent(eventId, userId))
            {
                TempData["Error"] = "You are already registered for this event.";
                return RedirectToAction("EventsList");
            }

            _eventRepository.RegisterUserToEvent(eventId, userId, numberOfParticipants);
            TempData["Success"] = "You have successfully registered for the event.";
            return RedirectToAction("EventsList");
        }

        /// <summary>
        /// UnregisterFromEvent allows users to unregister from an event.
        /// It takes the event ID as a parameter and removes the user's registration if they are registered.
        /// </summary>
        [HttpPost]
        [Authorize]
        public IActionResult UnregisterFromEvent(Guid eventId)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var eventItem = _eventRepository.GetByIdWithDetails(eventId);

            if (eventItem == null)
            {
                TempData["Error"] = "Event not found.";
                return RedirectToAction("EventsList");
            }

            if (!_eventRepository.IsUserRegisteredToEvent(eventId, userId))
            {
                TempData["Error"] = "You are not registered for this event.";
                return RedirectToAction("EventsList");
            }

            _eventRepository.UnregisterUserFromEvent(eventId, userId);
            return RedirectToAction("EventsList");
        }


        /// <summary>
        /// AssignStaffToEvent allows managers to assign staff members to an event.
        /// It takes the event ID and the staff user ID as parameters.
        /// If the event exists, it assigns the staff member to the event.
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult AssignStaffToEvent(Guid eventId, Guid staffUserId)
        {
            var eventItem = _eventRepository.GetByIdWithDetails(eventId);
            if (eventItem == null)
            {
                TempData["Error"] = "Event not found.";
                return RedirectToAction("EventsList");
            }

            _eventRepository.AssignStaffToEvent(eventId, staffUserId);
            return RedirectToAction("EventsList");
        }

        /// <summary>
        /// UnassignStaffFromEvent allows managers to unassign staff members from an event.
        /// It takes the event ID and the staff user ID as parameters.
        /// If the event exists, it unassigns the staff member from the event.
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult UnassignStaffFromEvent(Guid eventId, Guid staffUserId)
        {
            var eventItem = _eventRepository.GetByIdWithDetails(eventId);
            if (eventItem == null)
            {
                TempData["Error"] = "Event not found.";
                return RedirectToAction("EventsList");
            }

            _eventRepository.UnassignStaffFromEvent(eventId, staffUserId);
            return RedirectToAction("EventsList");
        }

    }
}
