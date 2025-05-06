using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class RoomTypeRepository : BaseRepository<RoomType>
    {
        public RoomTypeRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
