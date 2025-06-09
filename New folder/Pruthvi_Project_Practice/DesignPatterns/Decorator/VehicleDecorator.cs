using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class VehicleDecorator(IVehicle vehicle) : IVehicle
    {
        private readonly IVehicle vehicle = vehicle;

        public string Make => vehicle.Make;

        public string Model => vehicle.Model;

        public double Price => vehicle.Price;
    }
}
