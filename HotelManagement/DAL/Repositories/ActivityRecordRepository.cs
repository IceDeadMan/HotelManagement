using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class ActivityRecordRepository : BaseRepository<ActivityRecord>
    {
        public ActivityRecordRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
