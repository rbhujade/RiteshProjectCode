class Program
{
    public static void Main()
    {
        bool success = true;

        while (success)
        {
            Console.Write("Enter any number : ");
            string outNum = Console.ReadLine();

            if (int.TryParse(outNum, out int num))
            {
                success = false;
                Console.WriteLine(num);
            }
            else 
            {
                Console.WriteLine("Invalid Number.");
            }
        }
        Console.ReadLine();
    }
}