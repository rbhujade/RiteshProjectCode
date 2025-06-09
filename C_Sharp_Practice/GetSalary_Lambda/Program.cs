namespace GetSalary_Lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(){
                new Employee(){Id = 1,Name="Ritesh",Salary = 30000},
                new Employee(){Id = 2,Name="Nitesh",Salary = 40000},
                new Employee(){Id = 3,Name="Litesh",Salary = 40000},
                new Employee(){Id = 4,Name="Mitesh",Salary = 30000},
                new Employee(){Id = 5,Name="Dinesh",Salary = 80000},
                new Employee(){Id = 6,Name="Ritik",Salary = 60000}
            };

            var num = list.Select(s=> s.Salary).Distinct().OrderByDescending(d=> d).Take(3).Skip(2).First();

            var thirdNum = list.OrderByDescending(d=> d.Salary).Skip(2).Take(2).ToList();


            Console.ReadLine();             
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }

    
}