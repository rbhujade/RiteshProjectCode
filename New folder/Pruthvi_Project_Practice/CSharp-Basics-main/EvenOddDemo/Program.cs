using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            var output = Testodd(2);
            Console.WriteLine($"Result : {output}");
            Console.ReadKey();
        }

        private static bool Testodd(int num)
        {
            if ((num & 1) == 0)
            {
                return true;
            }  
            return false;
        }
    }
}
