using HotelManagement.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<IActionResult> Index()
        {
            var foods = await _foodRepository.GetAllAsync();
            return View(foods);
        }
    }
}
