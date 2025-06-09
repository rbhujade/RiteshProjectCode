using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Scooter
{
    public class SportsScooter : IScooter
    {
        public void Name()
        {
            Console.WriteLine("Sports Scooter...");
        }
    }
}
