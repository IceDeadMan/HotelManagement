using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class ReviewRepository : BaseRepository<Review>
    {
        public ReviewRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
