using System;

namespace FactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Factorial => { Factorial(0)}");
            Console.ReadKey();
        }

        private static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);

            //int fact = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    fact = fact * i;
            //}
            //return fact;
        }
    }
}
