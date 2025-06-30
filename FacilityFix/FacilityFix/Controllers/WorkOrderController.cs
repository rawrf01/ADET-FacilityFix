using Microsoft.AspNetCore.Mvc;

namespace FacilityFix.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult WorkorderAccept()
        {
            return View();
        }
        public IActionResult WorkorderView()
        {
            return View();
        }
    }
}

