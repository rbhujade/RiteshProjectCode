using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SecondHighSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, UserName = "Anil" , Salary = 5000, DeptID = 1},
                new Employee { Id = 2, UserName = "Sunil" , Salary = 6000, DeptID = 1},
                new Employee { Id = 3, UserName = "Lokesh" , Salary = 5500, DeptID = 2},
                new Employee { Id = 4, UserName = "Vinay" , Salary = 7000, DeptID = 2},
                new Employee { Id = 5, UserName = "Vinay 123" , Salary = 7000, DeptID = 3},
                new Employee { Id = 6, UserName = "Raj" , Salary = 6000, DeptID = 4},
            };

            List<Dept> dept = new List<Dept>()
            {
                new Dept { Id = 1, Name = "I.T."},
                new Dept { Id = 2, Name = "Admin"},
                new Dept { Id = 3, Name = "HR"},
                new Dept { Id = 4, Name = "Dev"}
            };

            var emp = employees.GroupBy(a => a.Salary).OrderByDescending(a => a.Key).Skip(1).First();

            var r = employees.Join(dept,
                e => e.DeptID,
                d => d.Id,
                (e, d) => new { DeptID = e.DeptID, Salary = e.Salary, DeptName = d.Name })
                .GroupBy(a => a.DeptName)
                .Select(a => new { DeptName = a.Key, SalarySum = a.Sum(b => b.Salary) });
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Salary { get; set; }
        public int DeptID { get; set; }
    }

    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
