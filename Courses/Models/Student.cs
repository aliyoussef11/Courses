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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required(ErrorMessage ="Please enter your First Name")]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(60)]
        public string LastName { get; set; }

        // Generate Foreign Key to AdmissionTermCode
        public int AdmissionCodeId { get; set; }
        [ForeignKey("AdmissionCodeId")]
        public virtual AdmissionTermCode AdmissionTermCode { get; set; }


        [Required(ErrorMessage = "Please enter your BirthDate")]
        public DateTime DateOfBirth { get; set; }


        // Generate Foreign Key to Major
        public int MajorId { get; set; }
        [ForeignKey("MajorId")]
        public virtual Major major { get; set; }


    }
}