using Microsoft.AspNetCore.Mvc;
using AbsherSecure1.Models;

namespace AbsherSecure1.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewID()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewID(IssueRequest model)
        {
            // هنا معالجة الطلب (حفظ، ارسال API، ...). الآن نعرض صفحة تحقق.
            TempData["RequestType"] = "NewID";
            TempData["FullName"] = model.FullName;
            return RedirectToAction("BiometricVerify");
        }

        [HttpGet]
        public IActionResult Passport()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Passport(IssueRequest model)
        {
            TempData["RequestType"] = "Passport";
            TempData["FullName"] = model.FullName;
            return RedirectToAction("BiometricVerify");
        }

        [HttpGet]
        public IActionResult Visa()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Visa(IssueRequest model)
        {
            TempData["RequestType"] = "Visa";
            TempData["FullName"] = model.FullName;
            return RedirectToAction("BiometricVerify");
        }

        public IActionResult BiometricVerify()
        {
            ViewBag.RequestType = TempData["RequestType"];
            ViewBag.FullName = TempData["FullName"];
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
