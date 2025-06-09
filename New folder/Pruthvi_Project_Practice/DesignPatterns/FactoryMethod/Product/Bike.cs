using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    internal class Bike : IVehicle
    {
        public void Color()
        {
            Console.WriteLine("Bike color is Red");
        }

        public void Drive()
        {
            Console.WriteLine("Bike drive at speed 90 KM/hr");
        }
    }
}
