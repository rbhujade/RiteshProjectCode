namespace Method_Hiding
{
    class Program
    {
        public static void Main(string[] args) 
        {
            BaseClass b = new BaseClass();
            b.Display(); // Output: Display from Base Class.

            DerivedClass derived  = new DerivedClass();
            derived.Display(); // Output:Display from Derived class.

            BaseClass c = new DerivedClass();
            c.Display(); // Output: Display from Base Class.

            // Accessing the hidden method
            BaseClass baseRef = derived;
            baseRef.Display();  // Output: Display from Base Class.

            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display from Base Class.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Display from Derived class.");
        }
    }

}