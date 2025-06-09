using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    internal class Scooter : IVehicle
    {
        public void Color()
        {
            Console.WriteLine("Scooter color is Black");
        }

        public void Drive()
        {
            Console.WriteLine("Scooter drive at speed 60 KM/hr");
        }
    }
}
