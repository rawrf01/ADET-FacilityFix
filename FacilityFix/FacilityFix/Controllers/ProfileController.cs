using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult AdminProfile()
        {
            return View();
        }
        public IActionResult TenantProfile()
        {
            return View();
        }
    }
}
