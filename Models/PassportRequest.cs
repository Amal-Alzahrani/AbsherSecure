using System.ComponentModel.DataAnnotations;

namespace AbsherSecure1.Models
{
    public class PassportRequest : IssueRequest
    {
        [Required(ErrorMessage = "مدة صلاحية الجواز مطلوبة")]
        public int PassportValidityYears { get; set; } 

        public string DeliveryMethod { get; set; }
        public string DeliveryAddress { get; set; }
    }
}