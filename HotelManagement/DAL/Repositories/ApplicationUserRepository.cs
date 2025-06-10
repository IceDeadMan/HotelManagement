using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// Repository for managing application users in the hotel management system.
    /// Includes methods for retrieving non-admin and non-customer users,
    /// updating email, password, and the rest of user information, and changing the assigned role.
    /// Does not inherit from BaseRepository, as this functionality is managed by built-in
    /// User and Role Managers from ASP.NET Identity.
    /// </summary>
    public class ApplicationUserRepository : IDisposable
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly HotelManagementDbContext _context;

        public ApplicationUserRepository(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            HotelManagementDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IList<ApplicationUser>> GetNonAdminAndNonCustomerUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();

            var filteredUsers = new List<ApplicationUser>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (!roles.Contains("Admin") && !roles.Contains("Customer"))
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }
        
        public async Task<IdentityResult> UpdatePasswordAsync(ApplicationUser user, string newPassword)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return await _userManager.ResetPasswordAsync(user, token, newPassword);
        }

        public async Task<IdentityResult> UpdateUserInfoAsync(ApplicationUser updatedUser)
        {
            var existingUser = await _userManager.FindByIdAsync(updatedUser.Id.ToString());
            if (existingUser == null)
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });

            existingUser.FirstName = updatedUser.FirstName;
            existingUser.LastName = updatedUser.LastName;
            existingUser.UserName = updatedUser.UserName;
            existingUser.PhoneNumber = updatedUser.PhoneNumber;

            return await _userManager.UpdateAsync(existingUser);
        }

        public async Task<IdentityResult> UpdateEmailAsync(Guid userId, string newEmail)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });

            var token = await _userManager.GenerateChangeEmailTokenAsync(user, newEmail);
            return await _userManager.ChangeEmailAsync(user, newEmail, token);
        }

        public async Task<IdentityResult> ChangeUserRoleAsync(Guid userId, string newRole)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });

            var currentRoles = await _userManager.GetRolesAsync(user);

            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!removeResult.Succeeded)
                return removeResult;

            if (!await _roleManager.RoleExistsAsync(newRole))
            {
                return IdentityResult.Failed(new IdentityError { Description = $"Role '{newRole}' does not exist." });
            }

            return await _userManager.AddToRoleAsync(user, newRole);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
