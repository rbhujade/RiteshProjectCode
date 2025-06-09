using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Example : IFirst1,ISecond1
    {
        public void Method1()
        {
            Console.WriteLine();
        }
    }

    public interface IFirst1
    {
        void Method1();
    }

    public interface ISecond1
    {
        void Method1();
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
