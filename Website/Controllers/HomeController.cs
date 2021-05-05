using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        AdminContext db = new AdminContext();
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurCourses()
        {
            return View();
        }
        public ActionResult CourseDetails()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();

        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(Admin admin)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Adminregister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adminregister(Admin admin)
        {
            admin.ModifiedDate = null;
            db.Admins.Add(admin);

            db.SaveChanges();
            ViewBag.Message = "Data Inserted Successfully";
            return RedirectToAction("Admin");
        }
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Employeeregister()
        {
            return View();
        }
        public ActionResult Faculty()
        {
            return View();
        }
        public ActionResult Facultyregister()
        {
            return View();
        }
    }
}