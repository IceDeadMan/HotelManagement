using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// FoodsController handles the management of food items in the hotel.
    /// It allows users to view a list of all food items and order food to rooms.
    /// </summary>
    public class FoodsController : Controller
    {
        private readonly ILogger<FoodsController> _logger;
        private readonly FoodRepository _foodRepository;

        public FoodsController(ILogger<FoodsController> logger, FoodRepository foodRepository)
        {
            _logger = logger;
            _foodRepository = foodRepository;
        }

        /// <summary>
        /// FoodsList displays a list of all food items.
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
        [Authorize(Roles = "Manager,Staff")]
        public IActionResult CreateFood(string Name, decimal Price, string Description)
        {
            var newFood = new Food
            {
                Name = Name,
                Price = Price,
                Description = Description
            };

            _foodRepository.Create(newFood);

            return RedirectToAction("FoodsList");
        }

        /// <summary>
        /// DeleteFood allows staff and managers to delete a food item.
        /// It takes the food ID as a parameter and deletes the food item from the database.
        /// </summary>
        /// <param name="id">The ID of the food item to delete.</param>
        /// <returns>Redirects to the FoodsList view after deleting the food item.</returns>
        [HttpPost]
        [Authorize(Roles = "Manager,Staff")]
        public IActionResult DeleteFood(Guid id)
        {
            if (_foodRepository.Exists(id))
            {
                _foodRepository.Delete(id);
            }
            return RedirectToAction("FoodsList");
        }
    }
}
