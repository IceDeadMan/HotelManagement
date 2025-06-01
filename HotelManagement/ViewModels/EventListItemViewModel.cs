using System;

namespace HotelManagement.ViewModels;

using HotelManagement.Models;
using HotelManagement.Models.JoinEntities;

/// <summary>
/// ViewModel for displaying a single event in a list.
/// This is used in the EventsController to show a list of events.
/// Includes useful properties and list for assigning staff.
/// </summary>
public class EventListItemViewModel
{
    public Event Event { get; set; }

    // Display properties
    public int TotalRegisteredParticipants { get; set; }
    public bool IsUserRegistered { get; set; }

    // For modals
    public List<ApplicationUser> AllAssignableStaff { get; set; } = new();
}
