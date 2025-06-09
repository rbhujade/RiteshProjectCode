using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate obj = new TestDelegate();
            obj.Test();

            Console.ReadKey();
        }
    }

    public class TestDelegate
    {
        public int Method1(string input)
        {
            return input.Length;
        }

        public int Method2(string input)
        {
            //... do something different
            return 1;
        }

        public bool RunTheMethod(Func<string, int> method)
        {
            int i = method("Test  this");
            return true;
        }

        public bool Test()
        {
            return RunTheMethod(Method1);
        }
    }
}
