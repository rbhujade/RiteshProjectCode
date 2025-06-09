using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
    public class MySingleton
    {
        private static int counter = 0;
        private MySingleton() 
        {
            counter++;
            Print("Counter : " + counter.ToString());
        }

        private static MySingleton instance ; //new MySingleton()

        public static MySingleton GetInstance
        {
            get 
            {  
                if(instance == null)
                    instance = new MySingleton();
                return instance; 
            }
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
