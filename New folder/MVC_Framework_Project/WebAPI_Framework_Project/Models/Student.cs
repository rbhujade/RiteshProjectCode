﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Framework_Project.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Contact { get; set; }
    }
}