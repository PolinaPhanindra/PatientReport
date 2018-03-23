using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
/// <summary>
/// <para>Patient model data</para>
/// </summary>
namespace PatientReport.Model
{  
    //Create a patient class
    public class Patient
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
    public  class PatientDetails
    {
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        public int ContactNo { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public int EmailId { get; set; }
        public string PolicyNumber { get; private set; }
    }
}