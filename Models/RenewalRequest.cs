using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class RenewalRequest
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        public string IdNumber { get; set; }
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool EditData { get; set; } // true => تعديل البيانات
        public bool ConfirmNow { get; set; } // true => تأكيد فوري
    }
}

