using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructore
{
    internal class Car
    {
        private static string _manufacturer;

        static Car() // Static constructor
        {
            _manufacturer = "Toyota";
            Console.WriteLine("Static constructor called");
        }
        public static string Manufacturer => _manufacturer;

        public Car()
        {
            Console.WriteLine("Public constructor called");
        }
    }
}
