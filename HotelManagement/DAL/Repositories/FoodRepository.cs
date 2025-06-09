using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// Repository for managing food items in the hotel management system.
    /// Additional methods for retrieving foods by IDs async, getting all foods with reviews,
    /// updating availability status, and deleting foods with associated orders.
    /// </summary>
    public class FoodRepository : BaseRepository<Food>
    {
        public FoodRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public async Task<List<Food>> GetFoodsByIdsAsync(List<Guid> foodIds)
        {
            return await _context.Foods
                .Where(f => foodIds.Contains(f.Id))
                .ToListAsync();
        }

        public async Task<List<Food>> GetAllWithReviewsAsync()
        {
            return await _context.Foods
                .Include(f => f.Reviews)
                .ThenInclude(r => r.ApplicationUser)
                .ToListAsync();
        }

        public async Task UpdateStatus(Guid foodId, bool isAvailable)
        {
            var food = await _context.Foods.FindAsync(foodId);
            if (food == null) return;
            food.IsAvailable = isAvailable;
            await _context.SaveChangesAsync();
        }

        public new void Delete(Guid id)
        {
            var food = _context.Foods
                .Include(f => f.FoodOrderFoods)
                .ThenInclude(fof => fof.FoodOrder)
                .SingleOrDefault(f => f.Id == id);

            if (food == null) return;

            var affectedOrders = new List<FoodOrder>();

            foreach (var fof in food.FoodOrderFoods)
            {
                var foodOrder = fof.FoodOrder;

                var remainingItems = _context.FoodOrderFoods
                    .Count(x => x.FoodOrderId == foodOrder.Id && x.FoodId != id);

                if (remainingItems == 0)
                {
                    affectedOrders.Add(foodOrder);
                }
            }

            _context.Foods.Remove(food);

            foreach (var order in affectedOrders)
            {
                _context.FoodOrders.Remove(order);
            }

            _context.SaveChanges();
        }
    }
}
