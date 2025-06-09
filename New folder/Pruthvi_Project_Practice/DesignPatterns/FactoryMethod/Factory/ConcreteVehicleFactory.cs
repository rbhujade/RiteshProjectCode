using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                case "SportBike":
                    return new SportBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}
