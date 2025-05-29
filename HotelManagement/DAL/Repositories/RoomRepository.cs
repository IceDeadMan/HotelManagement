using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// RoomRepository class for managing Room entities in the database.
    /// Provides methods to check room availability, retrieve rooms by IDs, and get room details.
    /// </summary>
    public class RoomRepository : BaseRepository<Room>
    {
        public RoomRepository(HotelManagementDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Checks if a room is available for booking within the specified date range.
        /// That means that the room is not already booked during the specified period.
        /// </summary>
        /// <param name="roomId">The ID of the room to check availability for.</param>
        /// <param name="startDate">The start date of the booking period.</param>
        /// <param name="endDate">The end date of the booking period.</param>
        /// <returns>True if the room is available, false otherwise.</returns>
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

        /// <summary>
        /// Retrieves a list of rooms by their IDs, including their related entities.
        /// </summary>
        /// <param name="roomIds">A list of room IDs to retrieve.</param>
        /// <returns>A list of Room entities with their related entities.</returns>
        public async Task<List<Room>> GetRoomsByIdsAsync(List<Guid> roomIds)
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews)
                .Include(r => r.RoomType)
                .Where(r => roomIds.Contains(r.Id))
                .AsSplitQuery() // query is very slow without this, could be set in global db context options
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific room by its ID, including its related entities.
        /// </summary>
        /// <param name="id">The ID of the room to retrieve.</param>
        /// <returns>The Room entity with the specified ID, or null if not found.</returns>
        public async Task<Room?> GetRoomWithDetailsAsync(Guid id)
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews).ThenInclude(r => r.ApplicationUser)// for usernames 
                .Include(r => r.RoomType)
                .AsSplitQuery() // query is very slow without this, could be set in global db context options
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        /// <summary>
        /// Retrieves all rooms with their details, including related entities.
        /// </summary>
        /// <returns>A list of all Room entities with their related entities.</returns>
        public async Task<List<Room>> GetAllRoomsWithDetailAsync()
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Include(r => r.ActivityRecords)
                .Include(r => r.FoodOrders)
                .Include(r => r.Reviews)
                .Include(r => r.RoomType)
                .AsSplitQuery() // query is very slow without this, could be set in global db context options
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a list of rooms that are currently booked by a specific user.
        /// </summary>
        /// <param name="userId">The ID of the user to check for booked rooms.</param>
        /// <param name="currentDate">The current date to check for bookings.</param>
        /// <returns>A list of Room entities that are booked by the specified user on the current date.</returns>
        public async Task<List<Room>> GetRoomsBookedByUserAsync(Guid userId, DateTime currentDate)
        {
            return await _context.Rooms
                .Include(r => r.Bookings)
                .Where(r => r.Bookings.Any(b =>
                    b.ApplicationUserId == userId &&
                    b.StartDate <= currentDate &&
                    b.EndDate >= currentDate))
                .ToListAsync();
        }
    }
}
