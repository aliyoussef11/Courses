using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public DbSet<Major> Majors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<AdmissionTermCode> AdmissionTermCodes { get; set; }
    }
}