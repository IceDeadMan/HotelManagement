using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<ActivityRecord> ActivityRecords { get; set; } = new List<ActivityRecord>();
        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
