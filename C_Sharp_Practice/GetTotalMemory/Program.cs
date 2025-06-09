using System;

class Program
{
    static void Main()
    {
        long memoryBefore = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory Used Before Allocation: {memoryBefore} bytes");

        // Allocate a large array
        int[] largeArray = new int[10_000_000];

        long memoryAfter = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory Used After Allocation: {memoryAfter} bytes");

        // Release memory
        largeArray = null;
        GC.Collect(); // Force Garbage Collection

        long memoryAfterGC = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory Used After GC: {memoryAfterGC} bytes");

        Console.ReadKey();
    }
}