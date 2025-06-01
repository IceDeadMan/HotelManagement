using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HotelManagement.DAL.Repositories
{
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
    }
}
