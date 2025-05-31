using System;

namespace HotelManagement.ViewModels;

using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;

public class EventListItemViewModel
{
    public Event Event { get; set; }

    // Display properties
    public int TotalRegisteredParticipants { get; set; }
    public bool IsUserRegistered { get; set; }

    // For modals
    public List<ApplicationUser> AllAssignableStaff { get; set; } = new(); 
}
