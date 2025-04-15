using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class FoodRepository : BaseRepository<Food>
    {
        public FoodRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
