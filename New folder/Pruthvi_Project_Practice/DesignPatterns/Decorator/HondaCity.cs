using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HondaCity : IVehicle
    {
        public string Make => "Honda City";

        public string Model => "Petrol";

        public double Price => 1000000;
    }
}
