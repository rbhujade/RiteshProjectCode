namespace Delegete
{
    class Program
    {
        delegate void Caclulator(int a,int b);
        public delegate void PrintDelegate(string msg);

        public static void Main(string[] args) 
        {
            Caclulator c = new Caclulator(Mul);

            c(10,20);

            PrintDelegate pd = new PrintDelegate(Print);
            PrintDelegate pd2 = Print;
            pd("Hello Print Delegate.");

            Console.ReadLine();
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public static void Print(string msg) 
        {
            Console.WriteLine(msg);
        }
    }
}