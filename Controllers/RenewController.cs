using Microsoft.AspNetCore.Mvc;
using AbsherSecure1.Models;

namespace AbsherSecure1.Controllers
{
    public class RenewController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RenewalRequest model)
        {
            TempData["RenewAction"] = model.EditData ? "Edit" : "Confirm";
            TempData["FullName"] = model.FullName;
            return RedirectToAction("BiometricVerify", "Issue");
        }
    }
}
