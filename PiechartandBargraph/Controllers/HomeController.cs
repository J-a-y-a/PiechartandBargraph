using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PiechartandBargraph.Models;

namespace PiechartandBargraph.Controllers
{
    public class HomeController : Controller
    {
        List<Student> stu = new List<Student>();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StudentDetails()
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student()
            {
                StudentID = 102,
                StudentName = "Raju",
                Class = "9",
                Section = "C",
                ParentName = "Hari"
            });
            return View(stu);
        }
        public ActionResult Edit( int ? id)
        {
            List<Student> students = new List<Student>();
            var student = stu.Where(a => a.StudentID == id).FirstOrDefault();
            //Student  student = stu.Find();
            return View(student);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}