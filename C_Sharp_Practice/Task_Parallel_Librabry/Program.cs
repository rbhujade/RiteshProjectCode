namespace Task_Parallel_Librabry
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Task basicTask = Task.Run(() => {
                Console.WriteLine("Basic Task is running...");
                Thread.Sleep(5000);
                Console.WriteLine("Basic Task is completed...");
            });
            basicTask.Wait();

            Task<int> sumTask = Task.Run(() => { 
                int sum = 0;
                for (int i = 0; i <= 10; i++)
                {
                    sum += i;
                }
                return sum;
            });

            Console.WriteLine("Sum of 1 to 10 num. "+ sumTask.Result);

            Task task1 = Task.Run(() => { Console.WriteLine("Task 1 is running...."); });
            Task task2 = Task.Run(() => { Console.WriteLine("Task 2 is running...."); });
            Task.WaitAll(task1, task2);
        }
    }
}