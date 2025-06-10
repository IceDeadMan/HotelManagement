using HotelManagement.Enums;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// For displaying food order details to staff.
    /// </summary>
    public class FoodOrderViewModel
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string? GuestName { get; set; }
        public string? RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public List<string> Foods { get; set; } = new();
    }
}