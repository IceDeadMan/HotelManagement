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

    public List<ApplicationUser> AssignedStaff { get; set; } = new();
    public List<EventRegistration> Registrations { get; set; } = new(); // Optional

    // For modals
    public List<ApplicationUser> AllAssignableStaff { get; set; } = new(); // For dropdown
}
