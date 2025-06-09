namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //static class
            double result = MathHelper.Square(10);
            Console.WriteLine("Square :" + result);

            //Sealed class
            Logger logger = new Logger();

            //Partial Class
            Person person = new Person() { FirstName = "Ritesh",LastName ="Bhujade" ,Age = 33};
            person.ShowName();
            person.ShowAge();

            Console.ReadLine();
        }
    }

    //sealed class
    sealed class Logger
    {
        public Logger() 
        { 
        
        }
        public void Log(string message) 
        {
            Console.WriteLine("Sealed class called.");
        }
    }

    //can't inherit sealed class
    //class Email : Logger
    //{

    //}

    //partial class
    public partial class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public void ShowName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    public partial class Person
    {
        public int Age { get; set; }

        public void ShowAge()
        {
            Console.WriteLine($"Age : {Age}");
        }
    }

    //static class
    public static class MathHelper
    {
        //static class only have static constructor
        static MathHelper()
        {

        }
        public static double Square(double num)
        {
            return num * num;
        }
    }

    public class x : Person
    {

    }
}