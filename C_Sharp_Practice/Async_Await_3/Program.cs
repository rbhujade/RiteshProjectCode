using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        await FetchDataAsync();
        Console.WriteLine("End");
    }

    static async Task FetchDataAsync()
    {
        Console.WriteLine("Fetching data...");
        await Task.Delay(3000);  // Simulating a delay (e.g., API call)
        Console.WriteLine("Data fetched!");
    }
}