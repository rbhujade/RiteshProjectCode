class Program
{
    static void Main(string[] args)
    {
        
        int height = ReadInt("Height");
        int width = ReadInt("Width");

        var result = CalcArea(height, width);

        Console.WriteLine($"Area of triangle in {result} . ");
    }

    public static int CalcArea(int height,int width)
    {
        return (height * width) /2;
    }

    static int ReadInt(string message)
    {
        Console.WriteLine($"Enter {message} : ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
}