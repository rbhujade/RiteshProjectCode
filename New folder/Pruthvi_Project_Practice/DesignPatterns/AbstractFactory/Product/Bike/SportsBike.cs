using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Bike
{
    internal class SportsBike : IBike
    {
        public void Name()
        {
            Console.WriteLine("Sports Bike....");
        }
    }
}
