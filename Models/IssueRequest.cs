using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class IssueRequest
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }
       
        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "رقم الهوية يجب أن يكون 10 أرقام")]
        public string NationalId { get; set; }

        [Required(ErrorMessage = "تاريخ الميلاد مطلوب")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "رقم الجوال مطلوب")]
        public string Mobile { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }

}
