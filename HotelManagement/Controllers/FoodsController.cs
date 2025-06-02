using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using HotelManagement.ViewModels;
using System.Security.Claims;
using HotelManagement.Logging;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// FoodsController handles the management of food items in the hotel.
    /// It allows users to view a list of all food items and order food to rooms.
    /// </summary>
    public class FoodsController : Controller
    {
        private readonly AuditLogger _auditLogger;
        private readonly FoodRepository _foodRepository;
        private readonly RoomRepository _roomRepository;

        public FoodsController(AuditLogger auditLogger, FoodRepository foodRepository, RoomRepository roomRepository)
        {
            _auditLogger = auditLogger;
            _foodRepository = foodRepository;
            _roomRepository = roomRepository;
        }

        /// <summary>
        /// FoodsList displays a list of all food items. Replaced by FoodMenu
        /// </summary>
        /// <returns>Returns a view with the list of food items.</returns>    
        public async Task<IActionResult> FoodsList()
        {
            var foods = await _foodRepository.GetAllAsync();
            return View(foods);
        }

        /// <summary>
        /// CreateFood allows staff and managers to create a new food item.
        /// It takes the food details as parameters and creates a new food item in the database.
        /// </summary>
        /// <param name="Name">The name of the food item.</param>
        /// <param name="Price">The price of the food item.</param>
        /// <param name="Description">The description of the food item.</param>
        /// <returns>Redirects to the FoodsList view after creating the food item.</returns>
        [HttpPost]
        [Authorize(Roles = "Manager,KitchenStaff")]
        public IActionResult CreateFood(string Name, decimal Price, string Description)
        {
            var newFood = new Food
            {
                Name = Name,
                Price = Price,
                Description = Description
            };

            _foodRepository.Create(newFood);
            _auditLogger.Log("CreateFood", $"New food {Name} created successfully.");

            return RedirectToAction("FoodMenu");
        }

        /// <summary>
        /// DeleteFood allows staff and managers to delete a food item.
        /// It takes the food ID as a parameter and deletes the food item from the database.
        /// </summary>
        /// <param name="id">The ID of the food item to delete.</param>
        /// <returns>Redirects to the FoodsList view after deleting the food item.</returns>
        [HttpPost]
        [Authorize(Roles = "Manager,KitchenStaff")]
        public IActionResult DeleteFood(Guid id)
        {
            if (_foodRepository.Exists(id))
            {
                _foodRepository.Delete(id);
                _auditLogger.Log("DeleteFood", $"Food with ID {id} deleted successfully.");
            }
            return RedirectToAction("FoodMenu");
        }

        /// <summary>
        /// FoodMenu displays the food menu for ordering food.
        /// It fetches all food items and available rooms for the logged-in user.
        /// Staff and managers can also create and delete food items.
        /// If the user is not logged in, he wont be able to order food, but can still view the menu.
        /// </summary>
        /// <returns> A view with the food menu and available rooms for ordering.</returns>
        public async Task<IActionResult> FoodMenu()
        {
            var currentDate = DateTime.Now;

            // Fetch all foods for display
            var foods = await _foodRepository.GetAllWithReviewsAsync();

            // Default values
            var availableRooms = new List<Room>();

            // Only attempt room check if user is logged in
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (!string.IsNullOrEmpty(userId))
                {
                    availableRooms = await _roomRepository.GetRoomsBookedByUserAsync(Guid.Parse(userId), currentDate);
                }
            }

            var viewModel = new FoodOrderCreateViewModel
            {
                Foods = foods.ToList(),
                AvailableRooms = availableRooms
            };

            return View(viewModel);
        }

        /// <summary>
        /// ToggleAvailability allows staff and managers to toggle the availability of a food item.
        /// It takes the food ID as a parameter and updates the availability status of the food item.
        /// /// </summary>
        /// <param name="id">The ID of the food item to toggle availability.</param>
        /// /// <returns>Returns a JSON response indicating success and the new availability status.</returns>
        [HttpPut]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager,KitchenStaff")]
        public IActionResult ToggleAvailability(Guid id)
        {
            var food = _foodRepository.GetById(id);
            if (food == null)
            {
                return NotFound();
            }

            food.IsAvailable = !food.IsAvailable;
            _foodRepository.Update(food);
            _auditLogger.Log("ToggleAvailability", $"Food {food.Name} availability toggled to {food.IsAvailable}.");

            return Json(new { success = true, isAvailable = food.IsAvailable });
        }
    }
}
