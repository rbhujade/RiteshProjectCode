using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallow_Deep_Copy
{
    public class Car
    {
        public string Name { get; set; }
        public CarModel CarModels { get; set; }

        public Car DeepCopy()
        {
            return new Car
            {
                CarModels = new CarModel { Model = this.CarModels.Model },
                Name = this.Name
            };
        }
    }

    public class CarModel
    {
        public string Model { get; set; }
    }
}
