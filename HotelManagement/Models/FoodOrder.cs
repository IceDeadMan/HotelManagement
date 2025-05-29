using HotelManagement.Enums;

namespace HotelManagement.Models
{
    /// <summary>
    /// Represents an food order in the hotel management system.
    /// This class is used to track the description, order date, status,
    /// and associated user and room for the food order.
    /// </summary>
    public class FoodOrder : BaseModel
    {
        public string? Description { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public Guid RoomId { get; set; }
        public Room? Room { get; set; }

        // todo add food quantity
        public ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
