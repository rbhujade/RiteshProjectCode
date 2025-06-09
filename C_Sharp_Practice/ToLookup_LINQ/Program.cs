namespace GroupBy_ToLookup_LINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "John", Department = "IT" },
                new Employee { Name = "Alice", Department = "HR" },
                new Employee { Name = "Bob", Department = "IT" },
                new Employee { Name = "Mark", Department = "HR" },
                new Employee { Name = "Sophia", Department = "Finance" }
            };

            //ToLookup
            var lookupEmployees = employees.ToLookup(e => e.Department);


            var result= from e in employees
                        group e by e.Department into g
                        select new
                        {
                            Department = g.Key,
                            Count = g.Count()
                        };

            var groupby = employees.GroupBy(e => e.Department)
                .Select(g => new {Department = g.Key , Count = g.Count()});

            foreach (var group in result)
            {
                Console.WriteLine("Department : " + group.Department + "    Count : " + group.Count );

            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
}