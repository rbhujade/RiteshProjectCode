using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Abstract_Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Interface
            ModelVehicle model = new ModelVehicle();
            IInterfaceVehicle v = new InterfaceVehicle();
            v.SetData(model);
            v.GetData();


            //Abstract

        }
    }

    //Abstract Class
    public abstract class AbstractVehicle
    {
        public abstract string Print();
    }

    public class DerivedClass : AbstractVehicle
    {
        public override string Print()
        {
            return "null";
        }
    }

    interface IInterfaceVehicle
    {
        void SetData(ModelVehicle model);
        IList<ModelVehicle> GetData();
    }

    class InterfaceVehicle : IInterfaceVehicle 
    {
        public void SetData(ModelVehicle model) 
        { 
        
        }

        public IList<ModelVehicle> GetData()
        {
            return new List<ModelVehicle>();
        }
    }

    public class ModelVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
    }

    interface IA1
    {
        void Show();
    }

    interface IA2
    {
        void Show();
    }

    public class A : IA1 , IA2
    {
        public void Show()
        {
            Console.WriteLine("A Show");
        }
    }

    class B
    {
        public void Show1() 
        {
            IA1 a1 = new A();

            IA2 a2 = new A();

            a1.Show();
            a2.Show();
        }
    }

    class C : IA1, IA2
    {
        public void Show() 
        {
            Console.WriteLine("C Show");
        }
    }
}
