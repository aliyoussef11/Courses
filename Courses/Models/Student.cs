using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Student
    {
        public byte Id { get; set; }

        [StringLength(60)]
        public string FirstName { get; set; }

        [StringLength(60)]
        public string LastName { get; set; }

        // Generate Foreign Key to AdmissionTermCode
        [StringLength(9)]
        public char AdmissionTermCode { get; set; }
        [ForeignKey("AdmissionCode")]
        public virtual AdmissionTermCode admissionTermCode { get; set; }

        public DateTime DateOfBirth { get; set; }

        // Generate Foreign Key to Major
        public byte MajorId { get; set; }
        [ForeignKey("MajorId")]
        public virtual Major major { get; set; }


    }
}