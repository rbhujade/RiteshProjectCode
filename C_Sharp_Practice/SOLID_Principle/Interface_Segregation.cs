using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal class Interface_Segregation
    {
    }

    interface Iflyable
    {
        void Fly();
    }

    interface ISwimable
    {
        void Swim();
    }

    class Dog : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Dog can swim..");
        }
    }

    // Violates ISP: Forces all animals to implement unnecessary methods
    interface IAnimal1
    {
        void Fly1();
        void Swim1();
    }

    class Dog1 : IAnimal1 
    { 
        public void Fly1()
        {
            throw new NotImplementedException();
            //Dog cannot Fly
        }

        public void Swim1() 
        {
            Console.WriteLine("Dog can Swim.");
        }
    }
}
