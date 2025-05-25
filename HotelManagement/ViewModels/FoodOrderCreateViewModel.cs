using System;
using HotelManagement.Models;

namespace HotelManagement.ViewModels;

public class FoodOrderCreateViewModel
{
    public List<Food> Foods { get; set; } = new();
    public List<Room> AvailableRooms { get; set; } = new();

    // Used for form binding
    public Guid SelectedRoomId { get; set; }
    public string Description { get; set; }
    public List<Guid> SelectedFoodIds { get; set; } = new();
}
