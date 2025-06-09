using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Framework_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("About")] //Action Name
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [OutputCache(Duration = 10)] //Action filter for action method output cacheable
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string StringMethod()
        {
            return "This is return string.";
        }
    }
}