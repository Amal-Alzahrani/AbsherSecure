using System.Diagnostics;
using AbsherSecure1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AbsherSecure1.Controllers
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
            return View();
        }

        public IActionResult Services()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserID")))
                return RedirectToAction("Login", "Auth");

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
