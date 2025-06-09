using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    
    public sealed class Singleton_ThreadSafe
    {
        private static readonly Lazy<Singleton_ThreadSafe> _instance =
            new Lazy<Singleton_ThreadSafe>(() => new Singleton_ThreadSafe());

        private Singleton_ThreadSafe()
        {
            Console.WriteLine("Singleton Instance Created");
        }

        public static Singleton_ThreadSafe Instance => _instance.Value;

        public void Print() => Console.WriteLine("Hello from Singleton");
    }
}
