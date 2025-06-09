
namespace Design_Pattern
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("------------Start Template Methode pattern------");
            //Template 
            DataExporter dataExporter = new CSVDataExporter();
            dataExporter.Export();
            Console.WriteLine("-------------End Template Factory--------");

            Console.WriteLine("------------Start Singleton pattern------");
            //Singleton 
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();
            if (singleton == singleton1) 
            {
                Console.WriteLine("Same result for both instance.");
            }

            Console.WriteLine("-------------End Singleton Factory--------");


            Console.WriteLine("------------Start Abstract Factory pattern------");
            //Abstract Factory

            IProductFactory productFactory = new ElectronicFactory();

            IProduct product1 = productFactory.CreateProductA();
            IProduct product2 = productFactory.CreateProductB();

            Console.WriteLine($"Product 1 : {product1.GetName()}");
            Console.WriteLine($"Product 2 : {product2.GetName()}");

            productFactory = new FurnitureFactory();

            IProduct furniture1 = productFactory.CreateProductA();
            IProduct furniture2 = productFactory.CreateProductB();

            Console.WriteLine($"Furniture 1 : {furniture1.GetName()}");
            Console.WriteLine($"Furniture 2 : {furniture2.GetName()}");

            Console.WriteLine("-------------End Abstract Factory--------");
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("------------Start Template pattern------");
            //Template Method
            Console.WriteLine("Making Black Coffee:");
            CoffeeTemplate blackCoffee = new BlackCoffee();
            blackCoffee.PreparedCoffee();

            Console.WriteLine("\nMaking Milk Coffee:");
            CoffeeTemplate milkCoffee = new MilkCoffee();
            milkCoffee.PreparedCoffee();

            Console.WriteLine("-------------End Template pattern--------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------Start Decorator pattern------");

            //Decorator Pattern
            ICoffee coffee = new Coffee();
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

            Console.WriteLine("-------------End Decorator pattern--------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------Start Factory pattern------");

            //Factory Pattern
            INotification emailNot = Factory_Pattern.GetNotification("email");
            emailNot.Notify("Hello via Email!");

            INotification sms = Factory_Pattern.GetNotification("sms");
            sms.Notify("Hello via SMS!");
            Console.WriteLine("-------------End Factory pattern--------");

        }
    }

    public sealed class Xyz
    {
        public void sss()
        {
            Console.WriteLine("");
        }
    }

}