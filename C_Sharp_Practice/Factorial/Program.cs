namespace Factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = 5;
            int result = Factorial(num);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Factorial(int x)
        {
            if(x <= 1) 
            { 
                return 1;
            }
            return x * Factorial(x -1);
        }

        
    }
}