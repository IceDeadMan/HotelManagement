using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using HotelManagement.Logging;
using HotelManagement.ViewModels.Users;


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
        private readonly AuditLogger _auditLogger;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
                               AuditLogger auditLogger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _auditLogger = auditLogger;
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

            var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
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
    }
}
