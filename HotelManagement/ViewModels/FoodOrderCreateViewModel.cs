using HotelManagement.Models;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents the view model for creating a food order.
    /// </summary>
    public class FoodOrderCreateViewModel
    {
        public List<Food> Foods { get; set; } = new();
        public List<Room> AvailableRooms { get; set; } = new();
        public Guid SelectedRoomId { get; set; }
        public string Description { get; set; }
        public List<Guid> SelectedFoodIds { get; set; } = new();
    }
}
