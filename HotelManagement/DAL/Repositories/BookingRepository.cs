using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    public class BookingRepository : BaseRepository<Booking>
    {
        public BookingRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public IEnumerable<Booking> GetBookingsByUserId(Guid userId)
        {
            return _context.Bookings
                .Include(b => b.Rooms) // im not sure if this is needed
                    .ThenInclude(r => r.RoomType) // im not sure if this is needed
                .Where(b => b.ApplicationUserId == userId)
                .ToList();
        }
    }
}
