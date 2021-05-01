using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courses.ViewModels
{
    public class NewCourseViewModel
    {
        public IEnumerable<Department> departments { get; set; }
        public Course Course { get; set; }
    }
}