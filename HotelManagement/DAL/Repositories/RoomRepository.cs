using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class RoomRepository : BaseRepository<Room>
    {
        public RoomRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
