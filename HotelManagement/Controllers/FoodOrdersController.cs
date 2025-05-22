using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.ViewModels;
using HotelManagement.Enums;
using Microsoft.AspNetCore.Authorization;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Controller for managing food orders.
    /// </summary>
    public class FoodOrdersController : Controller
    {
        private readonly FoodOrderRepository _repository;

        public FoodOrdersController(FoodOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> FoodOrdersList()
        {
            var orders = await _repository.GetAllWithDetailsAsync();

            var viewModel = orders.Select(o => new FoodOrderViewModel
            {
                Id = o.Id,
                Description = o.Description,
                OrderDate = o.OrderDate,
                Status = o.Status,
                GuestName = o.ApplicationUser?.UserName,
                RoomNumber = o.Room?.RoomNumber,
                Foods = o.Foods.Select(f => f.Name).ToList()
            }).ToList();

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public async Task<IActionResult> UpdateStatus(Guid id, OrderStatus status)
        {
            await _repository.UpdateStatusAsync(id, status);
            return RedirectToAction("FoodOrdersList");
        }
    }

}
