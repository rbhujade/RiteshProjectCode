using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    public abstract class Bird
    { }

    interface IFly
    {
        void Fly();
    }

    public class Sparrow : Bird, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying...");
        }
    }

    public class Ostrich : Bird
    {
        // Ostrich does not implement IFlyable
    }


    //// Violates LSP:
    public abstract class Bird1
    {
        public abstract void Fly();
    }

    public class Sparrow1 : Bird1
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying...");
        }
    }

    public class Ostrich1 : Bird1
    {
        // Violates LSP: Ostrich cannot fly
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
