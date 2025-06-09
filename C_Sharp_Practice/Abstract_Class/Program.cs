using System.Security.Cryptography.X509Certificates;

namespace Abstract_Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Shape shape = new Shape();
            //can't instantiate abstract class with constructor
            //The constructor is called when a derived class is instantiated.
            Shape shape = new Circle();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            Animal[] an = new Animal[] {new Dog(),new Cat()};

            Animal dog = new Dog();
            dog.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();

            cat.Sleep();

            Console.ReadLine();
        }


        abstract class Animal
        {
            public abstract void MakeSound();

            public void Sleep()
            {
                Console.WriteLine("Sleeping");
            }
        }

        // Subclass 1
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        //Subclass 2
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat Meows.");
            }
        }

        //Abstract class constructor
        abstract class Shape
        {
            public Shape()
            {
                Console.WriteLine("Constructor of Abstract Class....");
            }
        }

        class Circle : Shape
        {
            public Circle()
            {
                Console.WriteLine("Circle Constructor Called.");
            }
        }

        class Rectangle : Shape
        {
            public Rectangle()
            {
                Console.WriteLine("Rectangle Constructor called.");
            }
        }
    }
}


