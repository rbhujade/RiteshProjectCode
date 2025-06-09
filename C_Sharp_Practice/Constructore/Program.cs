namespace Constructore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            string value = Car.Manufacturer;
            Console.WriteLine(value);
            //
            Car car1 = new Car();
            string value2 = Car.Manufacturer;
            Console.WriteLine(value2);

            Car car2 = new Car();
            Console.WriteLine();

            Car car3 = new Car();
            Console.WriteLine();

            Console.ReadLine();

            //A a = new A();
        }
    }

    public class A
    {
        private A() { }
        //public A() { }
    }

    //class B : A     { }

    public abstract class Shape
    {
        public abstract void Draw();
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Move();
        public abstract void Resize();

        public virtual void aaa()
        {
            Console.WriteLine("hello");
        }
    }

    public class Circle : Shape
    {
        public override void Draw() { /*...*/ }
        public override double GetArea() => 0;
        public override double GetPerimeter() => 0;
        public override void Move() { /*...*/ }
        public override void Resize() { /*...*/ }
    }

    public interface IShape
    {
        void Draw();
        double GetArea();
        double GetPerimeter();
        void Move();
        void Resize();
    }

    public class Circle2 : IShape
    {
        public void Draw() { /*...*/ }
        public double GetArea() => 0;
        public double GetPerimeter() => 0;
        public void Move() { /*...*/ }
        public void Resize() { /*...*/ }
    }

    public interface ITest
    {
        string Name { get; set; }    // property
        event Action OnSpeak;        // event
        void Speak();                // method

        void Log(string message);

        // Default implementation
        void LogWarning(string message)
        {
            Log("[WARNING] " + message);
        }
    }

    public interface IFirst
    {
        void Show();
    }

    public interface ISecond
    {
        void Show();
    }

    public class MyClass : IFirst, ISecond
    {
        public void Show()  // One implementation serves both interfaces
        {
            Console.WriteLine("Show method implementation");
        }
    }
}
