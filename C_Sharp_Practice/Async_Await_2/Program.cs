using System.Collections.Specialized;
using System.Text;

namespace Async_Await_2
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine(GetData());
            PrintAsync();
        }

        public async static Task PrintAsync()
        {
            Console.WriteLine("Task running.......");
            await Task.Delay(2000);
            Console.WriteLine("Task completed.");
        }

        public static string GetData()
        {
            Console.WriteLine("Task running.......");
            Thread.Sleep(2000); // Simulates a time-consuming operation
            return "Data from server";
        }
    }
}