using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    /// <summary>
    /// Handles error pages.
    /// /// </summary>
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult Error404()
        {
            return View("NotFound");
        }

        [Route("Error/{statusCode}")]
        public IActionResult GenericError(int statusCode)
        {
            if (statusCode == 404)
                return RedirectToAction("Error404");

            return View("Error"); // Optional generic error view
        }
    }

}
