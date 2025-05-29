using System;

namespace HotelManagement.ViewModels;
using HotelManagement.Models;

/// <summary>
/// Represents the details of a room in the current booking in the My Booking page.
/// /// Includes the room details, booking details, food orders, activity records, and review.
/// </summary>
public class BookingRoomDetailViewModel
{
    public Room Room { get; set; }
    public Booking Booking { get; set; }
    public List<FoodOrder> FoodOrders { get; set; }
    public List<ActivityRecord> ActivityRecords { get; set; }
    public Review? Review { get; set; }

}
