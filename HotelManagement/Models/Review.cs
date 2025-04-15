namespace HotelManagement.Models
{
    public class Review : BaseModel
    {
        public string? Comment { get; set; }
        public int Rating { get; set; } // */10
        public DateTime ReviewDate { get; set; }

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }

        public Guid? FoodId { get; set; }
        public Food? Food { get; set; }
    }
}
