using HotelManagement.Enums;

namespace HotelManagement.Models
{
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
