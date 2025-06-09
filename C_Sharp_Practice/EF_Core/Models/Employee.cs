using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }  // Primary Key
        public string? FullName { get; set; }
        public int DepartmentId { get; set; } // Foreign Key

        // Navigation Property
        public Department? Department { get; set; }
    }
}
