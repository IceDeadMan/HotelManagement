namespace HotelManagement.Models
{
    /// <summary>
    /// Represents a Review in the hotel management system.
    /// This class is used to track the comment, rating, and review date of the review,
    /// as well as the associated user, room, or food item for the review.
    /// </summary>
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
