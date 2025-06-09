using HotelManagement.Logging;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// HomeController handles the main page of the hotel management system.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly AuditLogger _auditLogger;

        public HomeController(AuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// SetLanguage allows users to change the application's language and set it in a cookie.
        /// </summary>
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            if (!string.IsNullOrEmpty(culture))
            {
                _auditLogger.Log("SetLanguage", $"Language changed to {culture}.");
                Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
            }
            return LocalRedirect(returnUrl);
        }
    }
}
