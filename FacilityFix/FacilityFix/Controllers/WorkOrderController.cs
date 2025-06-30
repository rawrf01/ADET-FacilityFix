using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult RepairRequest() //Tenant
        {
            return View();
        }

        public IActionResult RepairRequestDetails() //Admin
        {
            return View();
        }
    }
}
