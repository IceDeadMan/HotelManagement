namespace HotelManagement.ViewModels.Users
{
    /// <summary>
    /// Represents the view model for user login functionality.
    /// </summary>
    public class LoginViewModel
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
    }
}
