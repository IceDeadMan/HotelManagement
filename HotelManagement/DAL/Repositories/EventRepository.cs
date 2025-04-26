using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
