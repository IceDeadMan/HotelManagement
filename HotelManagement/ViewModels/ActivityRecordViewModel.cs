using HotelManagement.Enums;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents a view model for activity records.
    /// </summary>
    public class ActivityRecordViewModel
    {
        public Guid Id { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public ActivityType Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ActivityStatus Status { get; set; }
    }
}