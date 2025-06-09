using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {

        }
    }

    public class Fish : Animal
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {

        }
    }
}
