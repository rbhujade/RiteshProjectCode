using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Join
{
    class Join_LINQ
    {
        public void LeftJoin()
        {
            var context = GetData();

            var leftJoinResult = from t1 in context.employees1
                                 join t2 in context.departments1
                                 on t1.DepartmentId equals t2.Id into t3
                                 from dept in t3.DefaultIfEmpty()
                                 select new
                                 {
                                     ID = t1.Id,
                                     EmpName = t1.Name,
                                     Department = dept?.DeptName ?? string.Empty
                                 };

            foreach (var item in leftJoinResult)
            {
                Console.WriteLine(item.ID + "      " + item.EmpName +"      " + item.Department);
            }
            Console.ReadLine();
        }

        public (IList<Employee> employees1, IList<Department> departments1) GetData()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Sara", DepartmentId = 2 },
                new Employee { Id = 3, Name = "Mike", DepartmentId = 0 } // No department
            };

            var departments = new List<Department>
            {
                new Department { Id = 1, DeptName = "HR" },
                new Department { Id = 2, DeptName = "IT" },
                new Department { Id = 3, DeptName = "Finance" }
            };

            return (employees, departments);
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }
}
