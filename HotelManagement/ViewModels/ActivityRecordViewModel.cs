using System;

namespace HotelManagement.ViewModels;
using HotelManagement.Enums;

public class ActivityRecordViewModel
{
    public Guid Id { get; set; }
    public string GuestName { get; set; }
    public string RoomNumber { get; set; }
    public ActivityType Type { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public ActivityStatus Status { get; set; }
}
