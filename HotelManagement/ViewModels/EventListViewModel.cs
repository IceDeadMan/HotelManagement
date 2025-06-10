namespace HotelManagement.ViewModels
{

    /// <summary>
    /// ViewModel for displaying a list of events.
    /// This is used in the EventsController to show a list of events.
    /// </summary>
    public class EventListViewModel
    {
        public List<EventListItemViewModel> Events { get; set; } = new();
        public bool IsManager { get; set; }
        public string? CurrentUserId { get; set; }
    }
}