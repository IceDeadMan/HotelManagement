using System;
using HotelManagement.Models;
using HotelManagement.ViewModels.DTOs;

namespace HotelManagement.ViewModels;

/// <summary>
/// StartBookingViewModel is used to manage the booking process.
/// It contains properties for filtering available rooms by type and date,
/// as well as properties for displaying available rooms and the current booking cart.
/// </summary>
public class StartBookingViewModel
{
    // Dropdown list of all room types
    public List<RoomType> RoomTypes { get; set; } = new();

    // Filter inputs
    public Guid SelectedRoomTypeId { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }

    // Result of search
    public List<Room> AvailableRooms { get; set; } = new();

    // Booking cart (room IDs and selected dates)
    public BookingCartSession Cart { get; set; }
}

