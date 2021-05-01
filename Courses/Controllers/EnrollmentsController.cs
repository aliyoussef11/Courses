using Courses.Models;
using Courses.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Courses.Controllers
{
    public class EnrollmentsController : Controller
    {
        private AppDbContext db;

        public EnrollmentsController()
        {
            db = new AppDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Enrollments
        public ActionResult Register()
        {
            var admissionTermCodes = db.AdmissionTermCodes.ToList();
            var majors = db.Majors.ToList();
            var courses = db.Courses.ToList();
            var students = db.Students.ToList();
            var viewModel = new NewEnrollmentViewModel
            {
                admissionTermCodes = admissionTermCodes,
                majors = majors,
                courses = courses,
                students = students
            };

            return View(viewModel);
        }

        public ActionResult RegisterStudentInCourse(Enrollment enrollment)
        {
            if (!ModelState.IsValid)
            {
                var admissionTermCodes = db.AdmissionTermCodes.ToList();
                var majors = db.Majors.ToList();
                var courses = db.Courses.ToList();
                var students = db.Students.ToList();
                var viewModel = new NewEnrollmentViewModel
                {
                    admissionTermCodes = admissionTermCodes,
                    majors = majors,
                    courses = courses,
                    students = students,
                    Enrollment = enrollment
                };
                return View("Register", viewModel);
            }
            db.Enrollments.Add(enrollment);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}