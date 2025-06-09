using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int refValue = 0;
            int outValue = 8;

            IncreaseNumber_Ref(ref refValue);
            IncreaseNumber_Out(out outValue);

            Console.WriteLine($"New Number is -> {refValue}");
            Console.WriteLine($"New Number is -> {outValue}");
          
            Console.ReadKey();
        }

        public static void IncreaseNumber_Ref(ref int value)
        {
            value = 5;
        }

        public static void IncreaseNumber_Out(out int value)
        {
            value = 0;
            value = value + 7;
        }

        
    }

    // OUTPUT
    // refValue => 5
    // outValue => 7
}



