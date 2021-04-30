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
            var students = db.Students.Include(c => c.AdmissionTermCode).Include(c => c.major).ToList();
            return View(students);
        }

        public ActionResult Create()
        {
            var admissionTermCodes = db.AdmissionTermCodes.ToList();
            var majors = db.Majors.ToList();
            var viewModel = new NewStudentViewModel
            {
                admissionTermCodes = admissionTermCodes,
                majors = majors
            };
            return View(viewModel);
        }
    }
}