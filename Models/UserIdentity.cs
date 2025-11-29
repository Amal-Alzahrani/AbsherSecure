using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class UserIdentity
    {
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        public string IdNumber { get; set; }
        [Required(ErrorMessage = "تاريخ الميلاد مطلوب")]
        public string IssueDate { get; set; }
        public string ExpiryDate { get; set; }
        public string TrackingNumber { get; set; }
        public int UsageCount { get; set; }
        public List<GovernmentService> Services { get; set; }
    }

    public class GovernmentService
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

