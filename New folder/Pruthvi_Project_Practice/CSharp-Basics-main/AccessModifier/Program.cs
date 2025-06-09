using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.ReadLine();
        }
    }


    public class A
    {
        protected int x = 100;
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine(x);
        }
    }
    public class C: B
    {
        public C()
        {
            Console.WriteLine(x);
        }
    }
}
