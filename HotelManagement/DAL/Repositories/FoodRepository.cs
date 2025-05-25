using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
