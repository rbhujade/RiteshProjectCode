namespace Async_Await
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();

            Console.ReadLine();
        }


        public async static void Task1()
        {
            Console.WriteLine("Task 1 started...");
            await Task.Delay(5000);
            Console.WriteLine("Task 1 completed.");
        }

        public async static void Task2()
        {
            Console.WriteLine("Task 2 started...");
            await Task.Delay(5000);
            Console.WriteLine("Task 2 completed.");
        }

        public async static void Task3()
        {
            Console.WriteLine("Task 3 started...");
            await Task.Delay(5000);
            Console.WriteLine("Task 3 completed.");
        }
    }
}