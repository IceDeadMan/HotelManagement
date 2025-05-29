using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Enums;

namespace HotelManagement.DAL.Repositories
{
    public class FoodOrderRepository : BaseRepository<FoodOrder>
    {
        public FoodOrderRepository(HotelManagementDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Retrieves all food orders with their associated details.
        /// Needed for username, room number...
        /// </summary>
        /// <returns>A list of food orders with their associated details.</returns>
        public async Task<List<FoodOrder>> GetAllWithDetailsAsync()
        {
            return await _context.FoodOrders
                .Include(o => o.ApplicationUser)
                .Include(o => o.Room)
                .Include(o => o.Foods)
                .ToListAsync();
        }

        /// <summary>
        /// Updates the status of a food order.
        /// Should be safer to use this instead of the default update method.
        /// </summary>
        public async Task UpdateStatusAsync(Guid orderId, OrderStatus status)
        {
            var order = await _context.FoodOrders.FindAsync(orderId);
            if (order == null) return;

            order.Status = status;
            await _context.SaveChangesAsync();
        }


    }
}
