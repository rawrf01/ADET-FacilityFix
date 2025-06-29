using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult RepairRequest()
        {
            return View();
        }

        public IActionResult RepairRequestDetails()
        {
            return View();
        }
    }
}
