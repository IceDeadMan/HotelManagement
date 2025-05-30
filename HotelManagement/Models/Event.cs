using HotelManagement.Models.JoinEntities;

namespace HotelManagement.Models
{
    /// <summary>
    /// Represents an event in the hotel management system.
    /// This class is used to track the name, description, date, and capacity of the event,
    /// as well as the users attending the event.
    /// </summary>
    public class Event : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }

        // Staff members
        public ICollection<ApplicationUser> StaffMembers { get; set; } = new List<ApplicationUser>();

        // Registered guests
        public ICollection<EventRegistration> Registrations { get; set; } = new List<EventRegistration>();
    }
}
