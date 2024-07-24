using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Globomantics.Survey.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Temp") != null)
            {
                HttpContext.Session.SetString("Temp", "Logged In");

            }
            return View();
        }
    }
}
