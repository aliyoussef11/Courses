using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Major
    {
        [Display(Name = "Major Name")]
        public int MajorId { get; set; }

        [Display(Name = "Major Name")]
        public string Name { get; set; }
    }
}