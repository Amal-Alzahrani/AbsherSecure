using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsherSecure1.Models
{
    public class PassportRequest : IssueRequest
    {
        [Required(ErrorMessage = "مدة صلاحية الجواز مطلوبة")]
        public int PassportValidityYears { get; set; } 

        public string DeliveryMethod { get; set; }
        public string DeliveryAddress { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}