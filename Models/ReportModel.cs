using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace AbsherSecure1.Models
{
    public class ReportModel
    {
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        public string IdNumber { get; set; }
        public string Description { get; set; }
        public IFormFile Attachment { get; set; } // صورة الهوية إن وُجدت
    }
}

