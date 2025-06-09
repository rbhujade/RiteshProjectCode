class Program
{
    static void Main(string[] args)
    {
        int[] number = new int[5]
        {
            44,88,66,22,99
        };

        Console.WriteLine("Enter number : ");
        int search = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(number, search);
        //int position = -1;
        if(position > -1)
        {
            Console.WriteLine($"Index {position} found for {search}");
        }
        else
        {
            Console.WriteLine("not found");
        }

        
    }
}