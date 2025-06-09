namespace Types_of_Classes
{
    class Program
    {
        public static void Main(string[] args) 
        {
            NormalClass myClass = new NormalClass();
        }
    }

    // 1. Normal(Concrete) Class
    //A normal class (or concrete class) is a standard class that can be instantiated and contains implementation.
    //Can be instantiated: NormalClass myClass = new NormalClass();
    class NormalClass
    {
        public int Value { get; set; }

        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
}