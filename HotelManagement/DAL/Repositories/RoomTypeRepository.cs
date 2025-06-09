using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// Default repository for managing RoomType entities.
    /// </summary>
    public class RoomTypeRepository : BaseRepository<RoomType>
    {
        public RoomTypeRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
