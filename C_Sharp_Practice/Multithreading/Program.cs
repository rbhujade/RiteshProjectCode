namespace Multithreading
{
    class Program
    {
        public static void Main(string[] args)
        {

            var task1 = Task.Run(() =>
            {
                for(int i=0;i<=100;i++)
                {
                    Console.WriteLine("Task 1 Running...");
                }
            });

            var task2 = Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("Task 2 Running...");
                }
            });

            Task.WaitAll(task1,task2);

            Console.ReadLine();
        }
    }
}