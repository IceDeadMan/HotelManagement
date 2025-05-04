using HotelManagement.Enums;

namespace HotelManagement.Models
{
    public class Room : BaseModel
    {
        public string? RoomNumber { get; set; }
        public string? Description { get; set; }
		public RoomType RoomType { get; set; }

		//public Guid ApplicationUserId { get; set; }
		//public ApplicationUser? ApplicationUser { get; set; }

		public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<ActivityRecord> ActivityRecords { get; set; } = new List<ActivityRecord>();
        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
