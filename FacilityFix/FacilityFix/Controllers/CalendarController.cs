using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
    }
}
