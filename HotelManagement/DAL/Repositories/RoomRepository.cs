using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    public class RoomRepository : BaseRepository<Room>
    {
        public RoomRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public async Task<bool> IsRoomAvailableAsync(Guid roomId, DateTime startDate, DateTime endDate)
    {
        return !await _context.Bookings
            .Include(b => b.Rooms)
            //.Where(b => b.Status != BookingStatus.Cancelled) // optional if we allow cancelling bookings
            .AnyAsync(b =>
                b.Rooms.Any(r => r.Id == roomId) &&
                b.StartDate < endDate &&
                b.EndDate > startDate
            );
    }


        public async Task<List<Room>> GetRoomsByIdsAsync(List<Guid> roomIds)
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews)
                .Include(r => r.RoomType)
                .Where(r => roomIds.Contains(r.Id))
                .ToListAsync();
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
