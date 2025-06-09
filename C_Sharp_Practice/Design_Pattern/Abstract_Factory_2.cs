using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Abstract_Factory_2
    {

    }

    public interface IProduct1
    {
        string GetProductInfo();
    }

    public class Bottel : IProduct1
    {
        public string GetProductInfo()
        {
            return "Water Bottel.";
        }
    }

    public class Tifin : IProduct1
    {
        public string GetProductInfo()
        {
            return "Tifin";
        }
    }

    public class Bag : IProduct1
    {
        public string GetProductInfo()
        {
            return "Bag";
        }
    }

    public class Spoon : IProduct1
    {
        public string GetProductInfo()
        {
            return "Spoon";
        }
    }

    public interface IProduct1Factory
    {
        IProduct1 Product1FactoryA();
        IProduct1 Product1FactoryB();
    }

    public class KitchenFactory : IProduct1Factory
    {

        public IProduct1 Product1FactoryA()
        {
            return new Spoon();
        }

        public IProduct1 Product1FactoryB()
        {
            return new Tifin();
        }
    }

    public class OfficeFactory : IProduct1Factory
    {
        public IProduct1 Product1FactoryA()
        {
            return new Bag();
        }

        public IProduct1 Product1FactoryB()
        {
            return new Bottel();
        }
    }
    //public interface IDatabase
    //{
    //    string Insert();
    //}

    //class SQL : IDatabase
    //{
    //    public string Insert()
    //    {
    //        return "Insert data using SQL.";
    //    }
    //}

    //class MySQL : IDatabase
    //{
    //    public string Insert()
    //    {
    //        return "Insert data using MySQL.";
    //    }
    //}

    //class Postgres : IDatabase
    //{
    //    public string Insert()
    //    {
    //        return "Insert data using Postgres.";
    //    }
    //}
}
