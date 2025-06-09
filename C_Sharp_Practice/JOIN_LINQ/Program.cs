namespace JOIN_LINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", DeptId = 101 },
                new Employee { Id = 2, Name = "Bob", DeptId = 102 },
                new Employee { Id = 3, Name = "Charlie", DeptId = 101 }
            };

            var departments = new List<Department>
            {
                new Department { Id = 101, Name = "IT" },
                new Department { Id = 102, Name = "HR" }
            };

            var result = employees.Join(departments,
                emp => emp.DeptId,
                dept => dept.Id,
                (emp, dept) => new
                {
                    emp.Name,
                    Department = dept.Name
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} works in {item.Department}");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DeptId { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
