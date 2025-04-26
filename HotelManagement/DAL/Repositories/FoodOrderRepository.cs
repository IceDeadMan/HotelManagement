using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class FoodOrderRepository : BaseRepository<FoodOrder>
    {
        public FoodOrderRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
