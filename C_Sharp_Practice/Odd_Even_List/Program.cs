class Program
{
    static void Main()
    {
        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        for (int i = 0; i < 20; i++) 
        { 
            if(i % 2 == 0) even.Add(i);
            else odd.Add(i);
        }

        Console.WriteLine("Odd Number :");
        
        foreach (int i in odd)
        {
            Console.WriteLine($"{i}");
        }

        Console.WriteLine();
        Console.WriteLine("Even Number :");
        foreach (int i in even)
        {
            Console.WriteLine($"{i}");
        }
    }
}