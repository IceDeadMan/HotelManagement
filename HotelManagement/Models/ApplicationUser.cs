using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        //public ICollection<Room> Rooms { get; set; } = new List<Room>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
