using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbsherSecure1.Models
{
    public class VisaRequest : IssueRequest
    {
        [Required(ErrorMessage = "نوع التأشيرة مطلوب")]
        public string VisaType { get; set; }
        [Required(ErrorMessage = "رقم جواز السفر مطلوب")]
        public string PassportNumber { get; set; }
        public string EmployerOrSponsor { get; set; }

        [Required(ErrorMessage = "تاريخ بداية التأشيرة مطلوب")]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "تاريخ نهاية التأشيرة مطلوب")]
        public DateTime ToDate { get; set; }

        [Required(ErrorMessage = "سبب الزيارة مطلوب")]
        public string Purpose { get; set; }

        public string AddressInSaudi { get; set; }
        [NotMapped]
        public IFormFile SupportingDocument { get; set; }
    }
}