namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents the default view model for error handling in the application.
    /// </summary>
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
