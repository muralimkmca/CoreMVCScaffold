using Microsoft.AspNetCore.Mvc;
using View2Controller.Models;

namespace View2Controller.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection collection)
        {

            //string name = collection.EmpName;
            //string address = collection.EmpAddress;

            string name = collection["EmpName"];
            string address = collection["EmpAddress"];

            return View();
        }
    }
}
