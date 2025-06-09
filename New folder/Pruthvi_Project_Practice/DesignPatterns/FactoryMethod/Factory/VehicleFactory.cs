using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicle);
    }
}
