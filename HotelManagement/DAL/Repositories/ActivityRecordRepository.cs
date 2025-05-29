using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Enums;

namespace HotelManagement.DAL.Repositories
{
    public class ActivityRecordRepository : BaseRepository<ActivityRecord>
    {
        public ActivityRecordRepository(HotelManagementDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Retrives all activity records for a specific room.
        /// </summary>
        public IList<ActivityRecord> GetByRoomId(Guid roomId)
        {
            return _context.ActivityRecords
                .Where(ar => ar.RoomId == roomId)
                .ToList();
        }

        /// <summary>
        /// Retrieves all activity records by a specific user.
        /// </summary>
        public IList<ActivityRecord> GetByUserId(Guid userId)
        {
            return _context.ActivityRecords
                .Where(ar => ar.ApplicationUserId == userId)
                .ToList();
        }

        /// <summary>
        /// Retrieves all activity records with their associated details.
        /// This includes the user and room information.
        /// </summary>
        public async Task<List<ActivityRecord>> GetAllWithDetailsAsync()
        {
            return await _context.ActivityRecords
                .Include(ar => ar.ApplicationUser)
                .Include(ar => ar.Room)
                .ToListAsync();
        }

        /// <summary>
        /// Updates the status of an activity record
        /// Should be safer to use this instead of the default update method.
        /// </summary>
        public async Task UpdateStatusAsync(Guid id, ActivityStatus status)
        {
            var activityRecord = await _context.ActivityRecords.FindAsync(id);
            if (activityRecord == null) return;

            activityRecord.Status = status;
            await _context.SaveChangesAsync();
        }

    }
}
