using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Department
    {

        [Display(Name="Department Name")]
        public int DepartmentId { get; set; }


        public string DepartmentName { get; set; }
    }
}