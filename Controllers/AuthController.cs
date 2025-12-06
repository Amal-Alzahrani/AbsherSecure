using Microsoft.AspNetCore.Mvc;
using AbsherSecure1.Models;

namespace AbsherSecure1.Controllers
{
    public class AuthController : Controller
    {
        private static List<User> usersDB = new List<User>();


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string nationalID, string password)
        {
            var user = usersDB.FirstOrDefault(x => x.NationalID == nationalID && x.Password == password);

            if (user == null)
            {
                ViewBag.Error = "رقم الهوية أو كلمة المرور غير صحيحة";
                return View();
            }


            HttpContext.Session.SetString("UserID", user.Id.ToString());
            HttpContext.Session.SetString("UserName", user.FullName);

            return RedirectToAction("Services", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            model.Id = usersDB.Count + 1;

            usersDB.Add(model);

            return RedirectToAction("Login");
        }
    }
}