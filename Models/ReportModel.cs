using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsherSecure1.Models
{
    public class ReportModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        public string IdNumber { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Attachment { get; set; } // صورة الهوية إن وُجدت
    }
}

