using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class ActivityRecordRepository : BaseRepository<ActivityRecord>
    {
        public ActivityRecordRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public IList<ActivityRecord> GetByRoomId(Guid roomId)
        {
            return _context.ActivityRecords
                .Where(ar => ar.RoomId == roomId)
                .ToList();
        }

        public IList<ActivityRecord> GetByUserId(Guid userId)
        {
            return _context.ActivityRecords
                .Where(ar => ar.ApplicationUserId == userId)
                .ToList();
        }
    }
}
