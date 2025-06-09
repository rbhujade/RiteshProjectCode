using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }  // Primary Key
        public string? Name { get; set; }

        // Navigation Property - One-to-Many relationship
        public ICollection<Employee>? Employees { get; set; }
    }
}
