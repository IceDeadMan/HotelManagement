using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using HotelManagement.Enums;
using HotelManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Security.Claims;
using System;
using AutoMapper;
using HotelManagement.Logging;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Controller for managing activity records - service requests by guests.
    /// /// This controller allows guests to request services and staff to view and manage these requests.
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

        public async Task<IActionResult> ActivityRecordsList()
        {
            var activities = await _activityRecordRepository.GetAllWithDetailsAsync();

            var viewModel = _mapper.Map<List<ActivityRecordViewModel>>(activities);

            return View(viewModel);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Guid roomId, ActivityType type, string description)
        {
            var activity = new ActivityRecord
            {
                RoomId = roomId,
                Type = type,
                ApplicationUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), // Get the current user's ID
                Description = description,
                Date = DateTime.Now,
                Status = ActivityStatus.Planned
            };

            _activityRecordRepository.Create(activity);
            TempData["Success"] = "Service requested successfully.";
            _auditLogger.Log("CreateActivityRecord", $"Activity for room {roomId} successfully created.");

            return Json(new { success = true, message = "Service requested successfully." });

        }

        [HttpPut]
        [Authorize(Roles = "Manager,Staff")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStatus(Guid id, ActivityStatus status)
        {
            await _activityRecordRepository.UpdateStatusAsync(id, status);
            //TempData["SuccessMessage"] = "Activity record status updated successfully.";
            _auditLogger.Log("UpdateActivityRecordStatus", $"Activity record {id} status updated to {status}.");
            return Json(new { success = true, message = "Status updated successfully." });
        }

    }
}
