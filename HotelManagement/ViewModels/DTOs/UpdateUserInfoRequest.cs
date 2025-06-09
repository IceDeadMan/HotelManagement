namespace HotelManagement.ViewModels.DTOs
{
    /// <summary>
    /// Represents a request to update users personal information,
    /// excluding email and password. 
    /// </summary>
    public class UpdateUserInfoRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
