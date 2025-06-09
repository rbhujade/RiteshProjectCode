namespace Task_Parallel_Library_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread1();
            Console.WriteLine("End Threads --------------------");
            Task task = Task.Run(() => 
            {
                Console.WriteLine("Task 1 is running....");
            });

            Task task2 = Task.Run(() =>
            {
                Console.WriteLine("Task 2 is running....");
            });

            Task task3 = Task.Run(() =>
            {
                Console.WriteLine("Task 3 is running....");
            });

            Task task4 = Task.Run(() =>
            {
                Console.WriteLine("Task 4 is running....");
            });

            Task task5 = Task.Run(() =>
            {
                Console.WriteLine("Task 5 is running....");
            });

            Task task6 = Task.Run(() =>
            {
                Console.WriteLine("Task 6 is running....");
            });

            Console.ReadLine();
        }

        public static void Thread1()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("1");
                Console.WriteLine($"Task {i} is running on thread {Task.CurrentId}");
            });
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("2");
                Console.WriteLine($"Task {i} is running on thread {Task.CurrentId}");
            });
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("3");
                Console.WriteLine($"Task {i} is running on thread {Task.CurrentId}");
            });
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("4");
                Console.WriteLine($"Task {i} is running on thread {Task.CurrentId}");
            });
        }
    }
}