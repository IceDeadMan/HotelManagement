using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public class BookingRepository : BaseRepository<Booking>
    {
        public BookingRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
