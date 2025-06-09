using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Scooter
{
    public class RegularScooter : IScooter
    {
        public void Name()
        {
            Console.WriteLine("Regular Scooter...");
        }
    }
}
