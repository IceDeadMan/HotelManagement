using System;

namespace HotelManagement.ViewModels;
using HotelManagement.Models;

public class BookingRoomDetailViewModel
{
    public Room Room { get; set; }
    public Booking Booking { get; set; }
    public List<FoodOrder> FoodOrders { get; set; }
    public List<ActivityRecord> ActivityRecords { get; set; }
    public Review? Review { get; set; }

}
