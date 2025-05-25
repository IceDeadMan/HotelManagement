using HotelManagement.Enums;

namespace HotelManagement.Models
{
    /// <summary>
    /// Represents an activity record in the hotel management system.
    /// This class is used to track various activities related to rooms such as cleaning, maintenance, etc.
    /// It contains properties for the date of the activity, a description, the type of activity,
    /// the status of the activity, and references to the associated room and user.
    /// </summary>
    public class ActivityRecord : BaseModel
    {
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public ActivityType Type { get; set; }
        public ActivityStatus Status { get; set; }

        public Guid RoomId { get; set; }
        public Room? Room { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
