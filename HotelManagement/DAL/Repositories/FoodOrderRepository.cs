using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Enums;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// Repository for managing food orders in the hotel management system.
    /// Additional methods for retrieving all food orders with details async and updating order status.
    /// </summary>
    public class FoodOrderRepository : BaseRepository<FoodOrder>
    {
        public FoodOrderRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public async Task<List<FoodOrder>> GetAllWithDetailsAsync()
        {
            return await _context.FoodOrders
                .Include(o => o.ApplicationUser)
                .Include(o => o.Room)
                .Include(o => o.FoodOrderFoods)
                    .ThenInclude(fof => fof.Food)
                .ToListAsync();
        }

        public async Task UpdateStatusAsync(Guid orderId, OrderStatus status)
        {
            var order = await _context.FoodOrders.FindAsync(orderId);
            if (order == null) return;

            order.Status = status;
            await _context.SaveChangesAsync();
        }


    }
}
