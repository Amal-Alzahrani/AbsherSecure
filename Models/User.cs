using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string NationalID { get; set; }  // رقم الهوية
        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; } // كلمة المرور

        public string FaceImagePath { get; set; }  // صورة الوجه المحفوظة
        public string FingerImagePath { get; set; } // بصمة الإصبع المحفوظة
    }
}