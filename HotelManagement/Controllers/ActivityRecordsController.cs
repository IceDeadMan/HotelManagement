using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using HotelManagement.Enums;
using HotelManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using AutoMapper;
using HotelManagement.Logging;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Controller for managing activity records - service requests by guests.
    /// This controller allows guests to request services and staff to view and manage these requests.
    /// </summary
    public class ActivityRecordsController : Controller
    {
        private readonly AuditLogger _auditLogger;
        private readonly ActivityRecordRepository _activityRecordRepository;
        private readonly IMapper _mapper;

        public ActivityRecordsController(AuditLogger auditLogger, ActivityRecordRepository activityRecordRepository, IMapper mapper)
        {
            _auditLogger = auditLogger;
            _activityRecordRepository = activityRecordRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Displays a list of activity records with sorting options.
        /// Sorts the records based on the specified criteria and direction.
        /// </summary>
        public async Task<IActionResult> ActivityRecordsList(string sortBy, string sortDir = "asc")
        {
            var activities = await _activityRecordRepository.GetAllWithDetailsAsync();

            var orderedActivities = (sortBy, sortDir.ToLower()) switch
            {
                ("GuestName", "desc") => activities.OrderByDescending(a => a.ApplicationUser.FirstName + " " + a.ApplicationUser.LastName),
                ("GuestName", _) => activities.OrderBy(a => a.ApplicationUser.FirstName + " " + a.ApplicationUser.LastName),
                ("RoomNumber", "desc") => activities.OrderByDescending(a => a.Room.RoomNumber),
                ("RoomNumber", _) => activities.OrderBy(a => a.Room.RoomNumber),
                ("Type", "desc") => activities.OrderByDescending(a => a.Type),
                ("Type", _) => activities.OrderBy(a => a.Type),
                ("Date", "desc") => activities.OrderByDescending(a => a.Date),
                ("Date", _) => activities.OrderBy(a => a.Date),
                ("Status", "desc") => activities.OrderByDescending(a => a.Status),
                ("Status", _) => activities.OrderBy(a => a.Status),
                _ => activities.OrderBy(a => a.Status).ThenBy(a => a.Date)
            };

            var viewModel = _mapper.Map<List<ActivityRecordViewModel>>(orderedActivities);

            return View(viewModel);
        }

        /// <summary>
        /// Allows guests to request a service for their room.
        /// </summary>
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Guid roomId, ActivityType type, string description)
        {
            var activity = new ActivityRecord
            {
                RoomId = roomId,
                Type = type,
                ApplicationUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                Description = description,
                Date = DateTime.Now,
                Status = ActivityStatus.Planned
            };

            _activityRecordRepository.Create(activity);
            TempData["Success"] = "Service requested successfully.";
            _auditLogger.Log("CreateActivityRecord", $"Activity for room {roomId} successfully created.");

            return Json(new { success = true, message = "Service requested successfully." });
        }

        /// <summary>
        /// Updates the status of an activity record.
        /// </summary>
        [HttpPut]
        [Authorize(Roles = "Manager,Staff")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStatus(Guid id, ActivityStatus status)
        {
            await _activityRecordRepository.UpdateStatusAsync(id, status);
            _auditLogger.Log("UpdateActivityRecordStatus", $"Activity record {id} status updated to {status}.");

            return Json(new { success = true, message = "Status updated successfully." });
        }

        /// <summary>
        /// Deletes an activity record by its ID.
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public IActionResult DeleteActivityRecord(Guid id)
        {
            var activity = _activityRecordRepository.GetById(id);
            if (activity == null)
            {
                return NotFound();
            }

            _activityRecordRepository.Delete(id);
            _auditLogger.Log("DeleteActivityRecord", $"Activity record {id} deleted.");
            TempData["Success"] = "Activity record deleted successfully.";
            return RedirectToAction("ActivityRecordsList");
        }

        /// <summary>
        /// Allows customers to delete their own activity records.
        /// </summary>
        [HttpPost]
        [Authorize]
        public IActionResult DeleteActivityRecordByCustomer([FromBody] Guid id)
        {
            var activity = _activityRecordRepository.GetById(id);
            if (activity == null || activity.Status != ActivityStatus.Planned)
            {
                return BadRequest("Cannot delete this activity.");
            }

            _activityRecordRepository.Delete(id);
            _auditLogger.Log("DeleteActivityRecordByCustomer", $"Customer deleted activity record {id}.");
            TempData["Success"] = "Activity record deleted successfully.";
            return Ok();
        }

    }
}
