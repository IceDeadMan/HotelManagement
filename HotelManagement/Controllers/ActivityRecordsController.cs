using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using HotelManagement.Enums;
using HotelManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Security.Claims;
using System;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Controller for managing activity records - service requests by guests.
    /// /// This controller allows guests to request services and staff to view and manage these requests.
    /// </summary
    public class ActivityRecordsController : Controller
    {
        private readonly ActivityRecordRepository _activityRecordRepository;

        public ActivityRecordsController(ActivityRecordRepository activityRecordRepository)
        {
            _activityRecordRepository = activityRecordRepository;
        }

        public async Task<IActionResult> ActivityRecordsList()
        {
            var activities = await _activityRecordRepository.GetAllWithDetailsAsync();

            var viewModel = activities.Select(a => new ActivityRecordViewModel
            {
                Id = a.Id,
                GuestName = a.ApplicationUser?.UserName,
                RoomNumber = a.Room?.RoomNumber,
                Type = a.Type,
                Description = a.Description,
                Date = a.Date,
                Status = a.Status
            }).ToList();

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
            TempData["SuccessMessage"] = "Service requested successfully.";

            return Json(new { success = true, message = "Service requested successfully." });

        }

        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStatus(Guid id, ActivityStatus status)
        {
            await _activityRecordRepository.UpdateStatusAsync(id, status);
            //TempData["SuccessMessage"] = "Activity record status updated successfully.";
            return RedirectToAction("ActivityRecordsList");
        }

    }
}
