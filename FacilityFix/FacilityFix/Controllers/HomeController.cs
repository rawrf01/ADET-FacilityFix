using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }
        public IActionResult TenantHome()
        {
            return View();
        }
    }
}


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// // using MySql.Data.MySqlClient;

// namespace Data_Grid.Controllers
// {
//     public class HomeController : Controller
//     {
//         // MySqlConnection connection = new MySqlConnection("Server=localhost;Database=FacilityFix;User ID=root;Password=your_password;");

//         private readonly ILogger<HomeController> _logger;
//         public HomeController(ILogger<HomeController> logger)
//         {
//             _logger = logger;
//             con.ConnectionStrin
//         }

//         public IActionResult AdminHome()
//         {
//             return View();
//         }
//         private void FetchData()
//         {
//             try
//             {
//                 connection.Open();
//                 MySqlCommand command = new MySqlCommand("SELECT * FROM YourTable", connection);
//                 MySqlDataReader reader = command.ExecuteReader();
//                 while (reader.Read())
//                 {
//                     // Process each row
//                 }
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error fetching data");
//             }
//             finally
//             {
//                 connection.Close();
//             }
//         }
//         public IActionResult TenantHome()
//         {
//             return View();
//         }
//     }
// }

