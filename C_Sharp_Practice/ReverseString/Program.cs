class Program
{
    public static void Main(string[] args)
    {
        string str = "Hello World!";

        string result = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--) 
        {
            char[] chara = str.ToCharArray();
            result += "" + chara[i];
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }

}