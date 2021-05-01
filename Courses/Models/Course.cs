using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CourseId { get; set; }

        [Required(ErrorMessage = "Please enter The Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please enter The Number Of Credits")]
        [Range(1,4)]
        public int Credits { get; set; }

        // Generate Foreign Key to Department
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department department { get; set; }
    }
}