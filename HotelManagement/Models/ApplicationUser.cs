using HotelManagement.Models.JoinEntities;
using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Models
{
    /// <summary>
    /// Represents a user in the hotel management system.
    /// This class extends the IdentityUser class to include additional properties
    /// and collections related to the user's bookings, activity records, food orders,
    /// reviews, and events.
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<ActivityRecord> ActivityRecords { get; set; } = new List<ActivityRecord>();
        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        // Staff assignments
        public ICollection<Event> AssignedEvents { get; set; } = new List<Event>();

        // Guest registrations
        public ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();
    }
}
