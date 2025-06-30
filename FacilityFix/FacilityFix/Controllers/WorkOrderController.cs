using Microsoft.AspNetCore.Mvc;

namespace FacilityFix.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult WorkorderAccept()//Admin
        {
            return View();
        }
        public IActionResult RepairRequest() //Tenant
        {
            return View();
        }
    }
}

