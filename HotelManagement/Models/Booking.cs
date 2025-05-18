using HotelManagement.Enums;

namespace HotelManagement.Models
{
    /// <summary>
    /// Represents an booking in the hotel management system.
    /// This class is used to track the start and end dates of the booking,
    /// the status of the booking, and the associated user and rooms.
    /// </summary>
    public class Booking : BaseModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BookingStatus Status { get; set; }

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
