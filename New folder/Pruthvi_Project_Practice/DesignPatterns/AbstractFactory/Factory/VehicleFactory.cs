using AbstractFactory.Product.Bike;
using AbstractFactory.Product.Scooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface VehicleFactory
    {
        IBike GetBike(string bikeType);
        IScooter GetScooter(string scooterType);
    }
}
