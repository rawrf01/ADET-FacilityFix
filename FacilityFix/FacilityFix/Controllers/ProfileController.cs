using Microsoft.AspNetCore.Mvc;

namespace FacilityFix.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
