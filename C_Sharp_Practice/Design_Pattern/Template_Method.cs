using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Template_Method
    {
    }

    public abstract class CoffeeTemplate
    {
        // Template Method - Defines the skeleton of the algorithm
        public void PreparedCoffee()
        {
            BoilWater();
            BrewCoffee();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater() 
        {
            Console.WriteLine("Boiling water...");
        }

        private void PourInCup() 
        {
            Console.WriteLine("Pouring coffee into cup...");
        }

        // Steps that subclasses will implement
        protected abstract void BrewCoffee();
        protected abstract void AddCondiments();
    }

    public class BlackCoffee : CoffeeTemplate
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing black coffee ...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("No condiments added.");
        }
    }

    public class MilkCoffee : CoffeeTemplate
    {
        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee with milk...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk.");
        }
    }
}
