using System;

namespace HotelManagement.ViewModels;

/// <summary>
/// Represents the main stats of a booking. Does not include the list of rooms.
public class RoomDetailBookingViewModel
{
    public string GuestName { get; set; } = "";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
