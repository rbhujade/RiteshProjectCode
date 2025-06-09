namespace LINQ_Query_Scenario
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 90000 },
                new Employee { Id = 4, Name = "Diana", Department = "IT", Salary = 80000 },
                new Employee { Id = 5, Name = "Eve", Department = "Finance", Salary = 60000 },
                new Employee { Id = 6, Name = "Frank", Department = "HR", Salary = 45000 }
            };

            int thresold = 10000;

            var result = employees
                .Where(w=> w.Salary > thresold)
                .GroupBy(g=>g.Department)
                .OrderBy(o=> o.Key);

            foreach (var group in result)
            {
                Console.WriteLine("Department : "+group.Key);
                foreach(var emp in group)
                {
                    Console.WriteLine(emp.Name + "  -  " + emp.Salary);
                }
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}