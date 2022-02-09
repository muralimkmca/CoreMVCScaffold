using CoreMVCScaffold.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCScaffold.Controllers
{
    public class EmployeeController : Controller
    {
        

        [HttpPost]
        public IActionResult Index(string method)
        {
            
            return View();
        }
    }
}
