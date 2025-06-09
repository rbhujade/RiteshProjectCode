namespace RemoveDuplicateChar
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string str = "Laptop";

            //1
            char[] result = str.ToCharArray().Distinct().ToArray();
            string final= new string(result);

            //2
            char[] arr = str.ToCharArray();
            string str2 = string.Empty;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (!str2.Contains(arr[i]))
                {
                    str2 += ""+ arr[i];
                }
            }
            Console.WriteLine("1" + final);
            Console.WriteLine("2" + str2);
            Console.ReadLine();
        }
    }
}