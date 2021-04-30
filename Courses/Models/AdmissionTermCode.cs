using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class AdmissionTermCode
    {      
        [Key]
        [Display (Name = "Admission Semester")]
        public int AdmissionCodeId { get; set; }

        public char AdmissionCode { get; set; }

        public string Semester { get; set; }
    }
}