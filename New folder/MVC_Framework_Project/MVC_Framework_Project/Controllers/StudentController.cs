using MVC_Framework_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Framework_Project.Controllers
{
    public class StudentController : Controller
    {
        Sample_DBEntities db = new Sample_DBEntities();
        // GET: Student
        public ActionResult Index()
        {
            var list = db.TB_Student.ToList();

            List<string> course = new List<string>();
            course.Add("IT");
            course.Add("CS");
            course.Add("CE");
            course.Add("ME");
            course.Add("EE");
            ViewData["Course"] = course;
            ViewBag.Course = course;
            TempData["Course"] = course;
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student stud)
        {
            if(ModelState.IsValid)
            {
                TB_Student st = new TB_Student();

                //stud.ID = db.TB_Student.Max().ID +  1; //
                st.Name = stud.Name;
                st.Email = stud.Email;
                st.Course = stud.Course;
                st.Contact = stud.Contact;

                db.TB_Student.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stud);
        }

        public ActionResult UserRegistration()
        {
            Dictionary<int,string> intrest = new Dictionary<int,string>();
            intrest.Add(1,"Cricket");
            intrest.Add(2,"Football");
            intrest.Add(3,"Hokey");
            intrest.Add(4,"Chess");
            intrest.Add(5,"Carrom");

            List<SelectListItem> intrest2 = new List<SelectListItem>();
            intrest2.Add( new SelectListItem
            {
                Text = "Select option",
                Value = "0",
                Selected = true
            });
            intrest2.Add(new SelectListItem
            {
                Text = "Cricket",
                Value = "1"
            });
            intrest2.Add(new SelectListItem
            {
                Text = "Hokey",
                Value = "2"
            });
            intrest2.Add(new SelectListItem
            {
                Text = "Chess",
                Value = "3"
            });
            intrest2.Add(new SelectListItem
            {
                Text = "Carrom",
                Value = "4"
            });

            var model = new MyIntrestModel
            {
                IntrestId = 1,
                Intrest = intrest.Select(s => new SelectListItem
                {
                    Value = s.Key.ToString(),
                    Text = s.Value
                })
            };
            ViewData["Intrest2"] = intrest2;
            ViewBag.Intrest = intrest2;
            return View();
        }

        [HttpPost]
        public ActionResult UserRegistration(Registration registration)
        {
            if(ModelState.IsValid)
            {

            }

            return View(registration);
        }
    }
}