using HotelManagement.Enums;

namespace HotelManagement.Models
{
    public class FoodOrder
    {
        public Guid Id { get; init; }
        public string? Description { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public Guid RoomId { get; set; }
        public Room? Room { get; set; }

        public ICollection<Food> Foods { get; set; } = new List<Food>();
    }
}
