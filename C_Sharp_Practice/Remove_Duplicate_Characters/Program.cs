namespace Remove_Duplicate_Characters
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Welcome to first program.";

            string result = string.Empty;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}