using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Bike
{
    public class RegularBike : IBike
    {
        public void Name()
        {
            Console.WriteLine("Regular Bike....");
        }
    }
}
