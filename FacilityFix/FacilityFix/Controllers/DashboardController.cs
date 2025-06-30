using Microsoft.AspNetCore.Mvc;

namespace FacilityFix.Controllers
{
    public class DashboardController : Controller
{
    public IActionResult Admin_Home()
    {
        return View();
    }
}
}


