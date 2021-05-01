using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Courses.ViewModels;

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

        public ActionResult Create()
        {
            var departments = db.Departments.ToList();
            var viewModel = new NewCourseViewModel
            {
                departments = departments
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateNewCourse(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();

            return RedirectToAction("Index", "Courses");
        }


        }
}