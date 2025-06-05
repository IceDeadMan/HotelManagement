using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using HotelManagement.Logging;
using HotelManagement.ViewModels.Users;
using AutoMapper;
using HotelManagement.DAL.Repositories;
using HotelManagement.ViewModels.DTOs;


namespace HotelManagement.Controllers
{
    /// <summary>
    /// UsersController handles user registration, login, and profile management.
    /// It uses ASP.NET Identity for user management and authentication.
    /// </summary>
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationUserRepository _userRepository;
        private readonly AuditLogger _auditLogger;
        private readonly IMapper _mapper;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                               AuditLogger auditLogger, IMapper mapper, ApplicationUserRepository userRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
            _auditLogger = auditLogger;
            _mapper = mapper;
        }

        public IActionResult Register()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction(controllerName: "Rooms", actionName: "RoomsList");
            }
            return View();
        }
        public IActionResult Login()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction(controllerName: "Rooms", actionName: "RoomsList");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = _mapper.Map<ApplicationUser>(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, "Customer");
                if (!roleResult.Succeeded)
                {
                    _auditLogger.Log("Register", $"Failed to assign Customer role to user {model.Username}.");
                    foreach (var error in roleResult.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);

                    return View(model);
                }

                _auditLogger.Log("Register", $"User {model.Username} registered successfully.");
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("RoomsList", "Rooms");
            }

            _auditLogger.Log("Register", "User registration failed.");
            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                _auditLogger.Log("Login", $"User {model.Username} logged in successfully.");
                return RedirectToAction("RoomsList", "Rooms");
            }

            _auditLogger.Log("Login", "Unsuccessful login attempt.");
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            ViewBag.LoginFailed = true;
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _auditLogger.Log("Logout", "User logged out.");
            return RedirectToAction("Login");
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            _auditLogger.Log("ProfileView", $"User {user.UserName} accessed their profile.");
            return View(user);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> NonCustomerOrAdminUsers()
        {
            var users = await _userRepository.GetNonAdminAndNonCustomerUsersAsync();
            return View(users);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdatePassword(string currentPassword, string newPassword)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (result.Succeeded)
            {
                _auditLogger.Log("UpdatePassword", $"Password updated for user {user.UserName}");
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateUserInfo([FromBody] UpdateUserInfoRequest model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            user.FirstName = string.IsNullOrWhiteSpace(model.FirstName) ? user.FirstName : model.FirstName;
            user.LastName = string.IsNullOrWhiteSpace(model.LastName) ? user.LastName : model.LastName;
            user.UserName = string.IsNullOrWhiteSpace(model.UserName) ? user.UserName : model.UserName;
            user.PhoneNumber = string.IsNullOrWhiteSpace(model.PhoneNumber) ? user.PhoneNumber : model.PhoneNumber;

            var result = await _userRepository.UpdateUserInfoAsync(user);
            if (result.Succeeded)
            {
                _auditLogger.Log("UpdateUserInfo", $"Updated info for user {user.UserName}");
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateEmail(string newEmail)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var result = await _userRepository.UpdateEmailAsync(user.Id, newEmail);

            if (result.Succeeded)
            {
                _auditLogger.Log("UpdateEmail", $"Updated email for user {user.UserName} to {newEmail}");
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> ChangeUserRole(Guid userId, string newRole)
        {
            var result = await _userRepository.ChangeUserRoleAsync(userId, newRole);
            if (result.Succeeded)
            {
                _auditLogger.Log("ChangeUserRole", $"Changed role of user {userId} to {newRole}");
                return Ok();
            }

            return BadRequest(result.Errors);
        }

    }
}
