using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courses.ViewModels
{
    public class NewEnrollmentViewModel
    {
        public IEnumerable<AdmissionTermCode> admissionTermCodes { get; set; }

        public IEnumerable<Student> students { get; set; }

        public IEnumerable<Course> courses { get; set; }

        public IEnumerable<Major> majors { get; set; }

        public Enrollment Enrollment { get; set; }
    }
}