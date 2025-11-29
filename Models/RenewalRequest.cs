using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class RenewalRequest
    {
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        public string IdNumber { get; set; }
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
        public bool EditData { get; set; } // true => تعديل البيانات
        public bool ConfirmNow { get; set; } // true => تأكيد فوري
    }
}

