namespace AutoMapper
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Person v = new Person();
            Employee v2 = new Employee();

        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}