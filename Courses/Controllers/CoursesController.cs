using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Courses.Controllers
{
    public class CoursesController : Controller
    {
        private AppDbContext db;

        public CoursesController()
        {
            db = new AppDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        // GET: Courses
        public ActionResult Index()
        {
            var courses = db.Courses.Include(c => c.department).ToList();
            return View(courses);
        }
    }
}