using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using HotelManagement.Models;
using HotelManagement.ViewModels;
using System.Diagnostics;

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
            return View("~/Views/Shared/NotFound.cshtml");
        }

        [Route("Error/500")]
        public IActionResult Error500()
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            var model = new ErrorViewModel
            {
                RequestId = requestId
            };

            return View("~/Views/Shared/Error.cshtml", model);
        }

        [Route("Error/{statusCode}")]
        public IActionResult GenericError(int statusCode)
        {
            if (statusCode == 404)
                return RedirectToAction(nameof(Error404));

            if (statusCode == 500)
                return RedirectToAction(nameof(Error500));

            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            var model = new ErrorViewModel
            {
                RequestId = requestId
            };

            return View("~/Views/Shared/Error.cshtml", model);
        }
    }

}
