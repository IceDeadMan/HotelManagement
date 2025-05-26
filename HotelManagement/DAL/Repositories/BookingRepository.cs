using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Enums;
using HotelManagement.Models.DTOs;

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

        /// <summary>
        /// Changes the status of a booking.
        /// </summary>
        /// <param name="bookingId">The ID of the booking whose status is to be changed.</param>
        /// <param name="newStatus">The new status to set for the booking.</param>
        public async Task ChangeStatusAsync(Guid bookingId, BookingStatus newStatus)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null)
            {
                booking.Status = newStatus;
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Retrieves a summary of all bookings for the reception desk.
        /// This includes the booking ID, start and end dates, status, user name, and room numbers.
        /// Using a DTO to avoid exposing the entire Booking model.
        /// </summary>
        public async Task<List<ReceptionBookingSummary>> GetBookingSummariesAsync()
        {
            return await _context.Bookings
                .Select(b => new ReceptionBookingSummary
                {
                    Id = b.Id,
                    StartDate = b.StartDate,
                    EndDate = b.EndDate,
                    Status = b.Status,
                    UserName = b.ApplicationUser.UserName,
                    RoomNumbers = b.Rooms.Select(r => r.RoomNumber).ToList()
                })
                .ToListAsync();
        }
    }
}
