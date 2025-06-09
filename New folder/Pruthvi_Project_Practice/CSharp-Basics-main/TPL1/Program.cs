using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var action = new Action(
                ()=>
                {
                    Task.Delay(5000);
                    Console.WriteLine("Hello Task World.");
                });

            Task task = new Task(action);
            task.Start();
            task.Wait();
            */

            var action = new Action<int>(
                (cnt)=>
                {
                    for (int i = 0; i <= cnt; i++)
                    {
                        Task.Delay(5000);
                        Console.WriteLine($"{i}");
                    }
                });

            Task task = new Task(() => { action(100); });
            task.Start();
            
            Console.ReadKey();

            Task.Factory.StartNew(Show);
           

        }


        public static void Show()
        {

        }
    }
}
