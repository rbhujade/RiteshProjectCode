class Program
{
    static void Main()
    {
        int[] number = new int[5];

        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine("Enter a Number : ");
            number[i] = Convert.ToInt16(Console.ReadLine());
        }

        for (int i = 0; i < number.Length; i++) 
        {
            Console.Write($"{number[i]}");
        }

        foreach (int i in number)
        {
            Console.Write($"{i}");
        }
    }
}
