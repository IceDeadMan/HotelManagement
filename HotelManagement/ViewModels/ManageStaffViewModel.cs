using HotelManagement.Models;

namespace HotelManagement.ViewModels
{

    /// <summary>
    /// Represents the view model for managing staff members in the managers profile view.
    /// </summary>
    public class ManageStaffViewModel
    {
        public List<ApplicationUser> Users { get; set; }
        public List<string> AvailableRoles { get; set; }
        public Dictionary<Guid, string> UserRoles { get; set; }
    }
}
