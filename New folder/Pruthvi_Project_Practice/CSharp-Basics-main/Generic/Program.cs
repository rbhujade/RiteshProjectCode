using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Comparer.AreEqual<int>(10, 10);
            Console.WriteLine($"Result => {result}");

            var result1 = Comparer.AreEqual<string>("Test", "Test");
            Console.WriteLine($"Result => {result1}");

            var result2 = Comparer.AreEqual<double>(10.0, 10.0);
            Console.WriteLine($"Result => {result2}");

            Emp e1 = new Emp() { ID = 1, Name = "Raj" };
            Emp e2 = e1;

            var result4 = Comparer.AreEqual<Emp>(e1, e2);
            Console.WriteLine($"Result => {result4}");

            Console.ReadKey();
        }
    }

    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    public class Comparer
    {
        public static bool AreEqual<T>(T val1,T val2)
        {
            return val1.Equals(val2);
        }
    }
}
