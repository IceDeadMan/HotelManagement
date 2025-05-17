using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    public class BookingRepository : BaseRepository<Booking>
    {
        public BookingRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId)
        {
            return await _context.Bookings
                .Include(b => b.Rooms)
                    .ThenInclude(r => r.RoomType)
                .Where(b => b.ApplicationUserId == userId)
                .ToListAsync();
        }


        public async Task<Booking?> GetBookingAsync(Guid bookingId)
        {
            return await _context.Bookings
                .Include(b => b.Rooms)
                .ThenInclude(r => r.RoomType)
                .FirstOrDefaultAsync(b => b.Id == bookingId);
        }
    }
}
