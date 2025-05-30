using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.ViewModels;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using HotelManagement.Models;
using AutoMapper;
using HotelManagement.Models.JoinEntities;

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

        public FoodOrdersController(FoodOrderRepository foodOrderRepository, FoodRepository foodRepository, IMapper mapper)
        {
            _foodOrderRepository = foodOrderRepository;
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> FoodOrdersList()
        {
            var orders = await _foodOrderRepository.GetAllWithDetailsAsync();

            var viewModel = _mapper.Map<List<FoodOrderViewModel>>(orders);

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public async Task<IActionResult> UpdateStatus(Guid id, OrderStatus status)
        {
            await _foodOrderRepository.UpdateStatusAsync(id, status);
            return RedirectToAction("FoodOrdersList");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrder(FoodOrderCreateViewModel model)
        {
            if (!ModelState.IsValid || !model.SelectedFoodIds.Any())
            {
                // Redisplay view with validation
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
                        Quantity = group.Count() // If multiple selections represent quantity
                    }).ToList()
            };

            _foodOrderRepository.Create(order);
            TempData["Success"] = "Your food order has been placed!";
            return RedirectToAction(controllerName: "Foods", actionName: "FoodMenu");
        }
    }

}
