using HotelManagement.Models;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents the view model for displaying a list of rooms and
    /// includes the room types for creating new rooms.
    /// </summary>
    public class RoomsListViewModel
    {
        public List<Room> Rooms { get; set; } = new();
        public List<RoomType> RoomTypes { get; set; } = new();
    }
}
