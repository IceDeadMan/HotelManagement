using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    public class RoomRepository : BaseRepository<Room>
    {
        public RoomRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public async Task<Room?> GetRoomWithDetailsAsync(Guid id)
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Room>> GetAllRoomsWithDetailAsync()
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews)
                .Include(r => r.RoomType)
                .ToListAsync();
        }
    }
}
