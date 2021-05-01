using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Enrollment
    {
        // Generate Foreign Key to AdmissionTermCode
        public int AdmissionCodeId { get; set; }
        [ForeignKey("AdmissionCodeId")]
        public virtual AdmissionTermCode AdmissionTermCode { get; set; }

        // Generate Foreign Key to Student
        public byte Id { get; set; }
        [ForeignKey("Id")]
        public virtual Student Student { get; set; }

        // Generate Foreign Key to Course
        public byte CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        // Generate Foreign Key to Major
        public int MajorId { get; set; }
        [ForeignKey("MajorId")]
        public virtual Major Major { get; set; }


        [Required]
        [Range(0,100)]
        public int Grade { get; set; }


        [Required]
        public Boolean EnrolledIndicator { get; set; }


        [Required]
        public Boolean PaymentIndicator { get; set; }


    }
}