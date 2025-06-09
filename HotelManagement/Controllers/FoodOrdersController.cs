using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.ViewModels;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using HotelManagement.Models;
using AutoMapper;
using HotelManagement.Models.JoinEntities;
using HotelManagement.Logging;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Controller for managing food orders.
    /// </summary>
    public class FoodOrdersController : Controller
    {
        private readonly FoodOrderRepository _foodOrderRepository;
        private readonly FoodRepository _foodRepository;
        private readonly IMapper _mapper;
        private readonly AuditLogger _auditLogger;

        public FoodOrdersController(FoodOrderRepository foodOrderRepository, FoodRepository foodRepository, IMapper mapper, AuditLogger auditLogger)
        {
            _foodOrderRepository = foodOrderRepository;
            _foodRepository = foodRepository;
            _mapper = mapper;
            _auditLogger = auditLogger;
        }

        /// <summary>
        /// Displays the food orders list with sorting options.
        /// Based on the sortBy and sortDir parameters, it sorts the retrieved orders accordingly.
        /// </summary>
        public async Task<IActionResult> FoodOrdersList(string sortBy , string sortDir = "asc")
        {
             var orders = await _foodOrderRepository.GetAllWithDetailsAsync();

            // Normalize case for safety
            sortBy = sortBy?.ToLower();
            sortDir = sortDir?.ToLower();

            var ordersSorted = (sortBy, sortDir) switch
            {
                ("guest", "asc") => orders.OrderBy(o => o.ApplicationUser.FirstName + " " + o.ApplicationUser.LastName),
                ("guest", "desc") => orders.OrderByDescending(o => o.ApplicationUser.FirstName + " " + o.ApplicationUser.LastName),
                ("room", "asc") => orders.OrderBy(o => o.Room.RoomNumber),
                ("room", "desc") => orders.OrderByDescending(o => o.Room.RoomNumber),
                ("date", "asc") => orders.OrderBy(o => o.OrderDate),
                ("date", "desc") => orders.OrderByDescending(o => o.OrderDate),
                ("status", "asc") => orders.OrderBy(o => o.Status),
                ("status", "desc") => orders.OrderByDescending(o => o.Status),
                _ => orders.OrderBy(o => o.Status).ThenBy(o => o.OrderDate)
            };

            var viewModel = _mapper.Map<List<FoodOrderViewModel>>(ordersSorted);
            return View(viewModel);
        }

        /// <summary>
        /// Updates the status of a food order.
        /// </summary>
        [HttpPut]
        [Authorize(Roles = "Manager,KitchenStaff")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStatus(Guid id, OrderStatus status)
        {
            await _foodOrderRepository.UpdateStatusAsync(id, status);
            _auditLogger.Log("UpdateStatus", $"Order {id} status updated to {status}.");
            return Json(new { success = true, message = "Status updated successfully." });
        }

        /// <summary>
        /// Displays the food menu for ordering.
        /// Groups selected foods by Id to represent the count of each food item selected.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrder(FoodOrderCreateViewModel model)
        {
            if (!ModelState.IsValid || !model.SelectedFoodIds.Any())
            {
                TempData["Error"] = "You must select at least one food.";
                return RedirectToAction("Menu");
            }

            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var foodItems = await _foodRepository.GetFoodsByIdsAsync(model.SelectedFoodIds);

            var order = new FoodOrder
            {
                ApplicationUserId = userId,
                RoomId = model.SelectedRoomId,
                Description = model.Description,
                OrderDate = DateTime.Now,
                Status = OrderStatus.Pending,
                FoodOrderFoods = model.SelectedFoodIds
                    .GroupBy(id => id)
                    .Select(group => new FoodOrderFood
                    {
                        FoodId = group.Key,
                        Quantity = group.Count()
                    }).ToList()
            };

            _foodOrderRepository.Create(order);
            _auditLogger.Log("CreateOrder", $"Order created for room {model.SelectedRoomId} with foods: {string.Join(", ", model.SelectedFoodIds)}.");
            TempData["Success"] = "Your food order has been placed!";
            return RedirectToAction(controllerName: "Foods", actionName: "FoodMenu");
        }
    }

}
