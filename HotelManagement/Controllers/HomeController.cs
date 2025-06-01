using System.Diagnostics;
using HotelManagement.Logging;
using HotelManagement.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// HomeController handles the main page and privacy policy of the hotel management system.
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

        public IActionResult Privacy()
        {
            return View();
        }

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

        // moved to error controller
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
