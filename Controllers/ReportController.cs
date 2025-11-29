using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AbsherSecure1.Models;

namespace AbsherSecure1.Controllers
{
    public class ReportController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ReportModel model)
        {
           
            if (model.Attachment != null)
            {
                
            }

            TempData["ReportSent"] = "تم استلام البلاغ، سنعاود الاتصال إذا لزم الأمر.";
            return RedirectToAction("Index");
        }
    }
}