using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsherSecure1.Models
{
    public class NewIDRequest : IssueRequest
    {
        [Required(ErrorMessage = "المدينة مطلوبة")]
        public string City { get; set; }

        public string District { get; set; }
        public string Street { get; set; }

        public string BloodType { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        // للقاصرين فقط
        public string GuardianName { get; set; }
        public string GuardianId { get; set; }
    }
}
