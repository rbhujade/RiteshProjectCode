using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class SportBike : IVehicle
    {
        public void Color()
        {
            Console.WriteLine("Bike color is Green");
        }

        public void Drive()
        {
            Console.WriteLine("Bike drive at speed 150 KM/hr");
        }
    }
}
