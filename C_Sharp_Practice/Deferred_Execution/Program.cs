namespace Deferred_Execution
{
    class Program
    {
        public static void Main(string[] args) 
        {
            DeferedExecution();
            ImmediateExecution();
        }

        public static void DeferedExecution()
        {
            Console.WriteLine("---------Deferred Execution----------");
            var employee = GetEmployees();

            var deffered = employee.Where(w => w.Country == "USA"); //query does not execute here

            employee.Add(new Employee { Emp_ID = 7, Name = "Ritesh", Email = "ritesh@bhujade.com", Country = "USA" });

            foreach (var item in deffered) //query execute here
            {
                Console.WriteLine($"Name : {item.Name}   ,  Country : {item.Country}");
            }
        }

        public static void ImmediateExecution()
        {
            Console.WriteLine("");
            Console.WriteLine("---------Immediate Execution----------");
            var employee = GetEmployees();

            var deffered = employee.Where(w => w.Country == "USA").ToList(); //Query execute here

            employee.Add(new Employee { Emp_ID = 7, Name = "Ritesh", Email = "ritesh@bhujade.com", Country = "USA" });

            foreach (var item in deffered)
            {
                Console.WriteLine($"Name : {item.Name}   ,  Country : {item.Country}");
            }
        }

        public static List<Employee> GetEmployees()
        {
            var Emp_List = new List<Employee>(
                    new Employee[]
                    {
                    new Employee{Emp_ID=1, Name="Shambhu Sharma", Email="shambhu@shambhu.com", Country="India"},
                    new Employee{Emp_ID=2, Name="Manu Khanna", Email="manu@manu.com", Country="India"},
                    new Employee{Emp_ID=3, Name="Abhishek Nigam", Email="abhishek@abhishek.com", Country="USA"},
                    new Employee{Emp_ID=4, Name="Yogesh Gupta", Email="yogesh@yogesh.com", Country="USA"},
                    new Employee{Emp_ID=5, Name="Shweta Kashyap", Email="Shweta@Shweta.com", Country="India"},
                    new Employee{Emp_ID=6, Name="Shraddha Gaur", Email="Shraddha@Shraddha.com", Country="India"},
                    new Employee{Emp_ID=7, Name="Akhilesh Atwal", Email="Akhilesh@Akhilesh.com", Country="India"},
                    new Employee{Emp_ID=6, Name="Mayank Dhulekar", Email="Mayank@Mayank.com", Country="USA"},
                    new Employee{Emp_ID=7, Name="Saurabh Mehrotra", Email="Saurabh@Saurabh.com", Country="USA"},
                    new Employee{Emp_ID=7, Name="Mehak Jain", Email="Mehak@Mehak.com", Country="India"},
                    });

            return Emp_List;
        }
    }

    public class Employee
    {
        public int Emp_ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
    }

    
}