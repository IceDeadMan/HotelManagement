using HotelManagement.Enums;

namespace HotelManagement.Models
{
    public class ActivityRecord
    {
        public Guid Id { get; init; }
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
