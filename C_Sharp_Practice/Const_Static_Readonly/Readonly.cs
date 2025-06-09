using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Const_Static_Readonly
{
    internal class Readonly
    {
    }

    public class Example
    {
        private const int num1_const = 12345;
        private static int num2_static;
        private readonly int num3_readonly = 98765;
        private static readonly int num4_static_readonly = 7676786;


        public Example(int static1)
        {
            //num1_const = 3333; //const cannot change
            num2_static = static1;
            num3_readonly = 555;
            //num4_static_readonly = 6666; //static readonly cannot change
        }

        private Example()
        {
            //num1_const = 3333; //const cannot change
            num2_static = 444;
            num3_readonly = 555;
            //num4_static_readonly = 6666; //static readonly cannot change
        }

        static Example()
        {
            //num1_const = 3333; //const cannot change
            num2_static = 444;
            //num3_readonly = 555; //readonly cannot change
            num4_static_readonly = 6666;
        }

        public void Print()
        {
            //num1_const = 2485875; //const can't change
            num2_static = 9877676;// 
            //num3_readonly = 9746536; //readonly can't change
            //num4_static_readonly = 899485758; //static readonly can't change
            Console.WriteLine("num1_const : " + num1_const);
            Console.WriteLine("num2_static : " + num2_static);
            Console.WriteLine("num3_readonly : " + num3_readonly);
            Console.WriteLine("num4_static_readonly : " + num4_static_readonly);
        }
    }

    public class College
    {
        public readonly string str1;
        public readonly string str2;
        public readonly string str3 = "student";
        public College(string a, string b)
        {
            str1 = a;
            str2 = b;
            Console.WriteLine("Display value of string 1 {0}, "
                            + "and string 2 {1}", str1, str2);
        }

        //static public void Main()
        //{
        //    College ob = new College("VJNT College", "Oxford College");
        //}
    }
}
