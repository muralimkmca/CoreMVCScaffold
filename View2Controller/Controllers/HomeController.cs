using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using View2Controller.Models;

namespace View2Controller.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["username"] = "Murali";
            return View();
        }

        public object? Privacy()
        {
            if (TempData.ContainsKey("username"))
            {
                object? obj = TempData["username"];
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}