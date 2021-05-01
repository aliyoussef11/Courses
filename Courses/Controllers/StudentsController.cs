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

        [HttpPost]
        public ActionResult CreateNewStudent(Student student)
        {
            if(!ModelState.IsValid)
            {
                var admissionTermCodes = db.AdmissionTermCodes.ToList();
                var majors = db.Majors.ToList();
                var viewModel = new NewStudentViewModel
                {
                    admissionTermCodes = admissionTermCodes,
                    majors = majors,
                    Student = student
                };
                return View("Create", viewModel);
            }
            db.Students.Add(student);
            db.SaveChanges();

            return RedirectToAction("Index", "Students");
        }

        public ActionResult ShowCourseRegistered(int Id)
        {
            var coursesRegistered = db.Enrollments.Include(c => c.Student).Where(s => s.Id == Id).ToList();
            return View(coursesRegistered);
        }

        public ActionResult Register()
        {
            return RedirectToAction("Register", "Enrollments");
        }

        public ActionResult Delete(int id2Delete)
        {
            var student = db.Students.Find(id2Delete);
            var studentinEnrollment = db.Enrollments.Find(id2Delete);
            
            db.Students.Remove(student);
            db.Enrollments.Remove(studentinEnrollment);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}