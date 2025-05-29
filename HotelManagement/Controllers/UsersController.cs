using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using HotelManagement.Models.Users;
using Microsoft.AspNetCore.Authorization;


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

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("RoomsList", "Rooms");
            }

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
                return RedirectToAction("RoomsList", "Rooms");

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            return View(user);
        }
    }
}
