using HotelManagement.Models;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// ViewModel for displaying a single event in a list.
    /// This is used in the EventsController to show a list of events.
    /// Includes useful properties and list for assigning staff.
    /// </summary>
    public class EventListItemViewModel
    {
        public Event Event { get; set; }
        public int TotalRegisteredParticipants { get; set; }
        public bool IsUserRegistered { get; set; }
        public bool IsUserInvolved { get; set; } = false;
        public List<ApplicationUser> AllAssignableStaff { get; set; } = new();
    }
}
