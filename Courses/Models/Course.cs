using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Course
    {
        public byte CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        // Generate Foreign Key to Department
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department department { get; set; }
    }
}