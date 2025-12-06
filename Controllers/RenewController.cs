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
            if (model.EditData && model.ConfirmNow)
            {
                ModelState.AddModelError("", "اختر خيار واحد فقط");
                return View(model);
            }

            if (model.EditData)
            {
                return RedirectToAction("EditData", "Renew", model);
            }

            if (model.ConfirmNow)
            {
                return RedirectToAction("BiometricVerify", "Issue");
            }

            ModelState.AddModelError("", "يجب اختيار أحد الخيارات");
            return View(model);
        }


        [HttpGet]
        public IActionResult EditData(RenewalRequest model)
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult SubmitEditData(RenewalRequest model)
        {
            return RedirectToAction("BiometricVerify", "Issue");
        }
    }
}
