using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjectOnPioneerWeb_publish.Models
{
    public class PioneerData
    {
        [Key]
        public int Id { get; set; }
        public string Interestedin { get; set; }
        [Required(ErrorMessage = "Please insert your full name")]
        public string Yourfullname { get; set; }


        [Required(ErrorMessage = "Please enter the Contact No .")]
        [StringLength(11)]
        public string ContactNo { get; set; }


        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Emailid")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Emailid { get; set; }
        [StringLength(11)]
        public string AlternativeNo { get; set; }
        public string BestTimeToCall { get; set; }
        [Required(ErrorMessage = "please input the message in the given box")]
        [StringLength(200)]
        public string YourMessage { get; set; }

        public bool isSubmitted { get; set; }
    }
}