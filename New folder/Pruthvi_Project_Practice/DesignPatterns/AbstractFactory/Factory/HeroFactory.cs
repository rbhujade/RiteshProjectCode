using AbstractFactory.Product.Bike;
using AbstractFactory.Product.Scooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class HeroFactory : VehicleFactory
    {
        public IBike GetBike(string bikeType)
        {
            switch (bikeType)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bikeType));
            }
        }

        public IScooter GetScooter(string scooterType)
        {
            switch (scooterType)
            {
                case "Sports":
                    return new SportsScooter();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooterType));
            }
        }
    }
}
