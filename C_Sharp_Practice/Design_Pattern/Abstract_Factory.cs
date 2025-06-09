using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Abstract_Factory
    {
    }

    public interface IProduct
    {
        string GetName();
    }

    public class Mobile : IProduct
    {
        public string GetName()
        {
            return "Mobile Phone";
        }
    }

    public class Chair : IProduct
    {
        public string GetName() 
        {
            return "Chair";
        }
    }

    public class Laptop : IProduct
    {
        public string GetName()
        {
            return "Laptop";
        }
    }


    public class Table : IProduct
    {
        public string GetName()
        {
            return "Table";
        }
    }

    public interface IProductFactory
    {
        IProduct CreateProductA();
        IProduct CreateProductB();
    }

    public class ElectronicFactory : IProductFactory
    {
        public IProduct CreateProductA()
        { 
            return new Mobile();
        }

        public IProduct CreateProductB()
        {
            return new Laptop();
        }
    }

    public class FurnitureFactory : IProductFactory
    {
        public IProduct CreateProductA()
        {
            return new Chair();
        }

        public IProduct CreateProductB()
        {
            return new Table();
        }
    }
}
