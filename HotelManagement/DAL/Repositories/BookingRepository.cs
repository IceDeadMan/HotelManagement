using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    public class BookingRepository : BaseRepository<Booking>
    {
        public BookingRepository(HotelManagementDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Retrieves all bookings for a specific user by their ID.
        /// </summary>
        /// <param name="userId">The ID of the user whose bookings are to be retrieved.</param>
        public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId)
        {
            return await _context.Bookings
                .Include(b => b.Rooms)
                    .ThenInclude(r => r.RoomType)
                .Where(b => b.ApplicationUserId == userId)
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific booking by its ID.
        /// </summary>
        /// <param name="bookingId">The ID of the booking to retrieve.</param>
        public async Task<Booking?> GetBookingAsync(Guid bookingId)
        {
            return await _context.Bookings
                .Include(b => b.Rooms)
                .ThenInclude(r => r.RoomType)
                .FirstOrDefaultAsync(b => b.Id == bookingId);
        }
    }
}
