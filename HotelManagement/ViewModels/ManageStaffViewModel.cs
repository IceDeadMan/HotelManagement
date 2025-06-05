using System;

namespace HotelManagement.ViewModels;
using System.Collections.Generic;
using HotelManagement.Models;

public class ManageStaffViewModel
{
    public List<ApplicationUser> Users { get; set; }
    public List<string> AvailableRoles { get; set; }
    public Dictionary<Guid, string> UserRoles { get; set; }
}
