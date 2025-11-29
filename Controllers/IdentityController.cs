using AbsherSecure1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AbsherSecure1.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
                var model = new UserIdentity
                {
                    FullName = "أمل عبدالرحمن عبدالله الزهراني",
                    IdNumber = "1234567890",
                    IssueDate = "2020-01-01",
                    ExpiryDate = "2030-01-01",
                    TrackingNumber = "000123",
                    Services = new List<GovernmentService>
                {
                    new GovernmentService { Name = "المستشفى العسكري", IsActive = true },
                    new GovernmentService { Name = "جامعة جدة", IsActive = false },
                    new GovernmentService { Name = "شركة سابقة", IsActive = false }
                    }
                };

                return View(model);
        }
    }
}
