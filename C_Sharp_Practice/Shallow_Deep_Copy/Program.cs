namespace Shallow_Deep_Copy
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            //Deep Copy

            var car1 = new Car()
            {
                Name = "Altros",
                CarModels = new CarModel { Model = "V1"}
            };

            var car2 = car1.DeepCopy();

            car2.CarModels.Model = "V5";
            Console.WriteLine(car1.CarModels.Model.ToString());
            Console.WriteLine(car2.CarModels.Model.ToString());

            Console.ReadLine();
            //Shallow Copy
            var person1 = new Person()
            {
                Name = "Test",
                Address = new Address() { City = "Pune" }
            };

            var person2 = (Person)person1; //.MemberwiseClone()

            person2.Address.City = "Nagpur";

            Console.WriteLine(person1.Address.City);
            Console.WriteLine(person2.Address.City);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }
}