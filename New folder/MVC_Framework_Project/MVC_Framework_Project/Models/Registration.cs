using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Framework_Project.Models
{
    public class Registration
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Course { get; set; }
        public int Intrest { get; set; }
    }

    public class MyIntrestModel
    {
        public int IntrestId { get; set; }
        public IEnumerable<SelectListItem> Intrest { get; set; }
    }
}