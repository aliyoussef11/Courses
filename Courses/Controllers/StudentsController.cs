using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courses.Controllers
{
    public class StudentsController : Controller
    {
        private AppDbContext db;

        public StudentsController()
        {
            db = new AppDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }
    }
}