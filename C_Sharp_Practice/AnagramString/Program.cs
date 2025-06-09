namespace AnagramString
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string str1 = "ritesh";
            string str2 = "hsietr";

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string s1 = new string(ch1);
            string s2 = new string(ch2);

            if (s1 == s2) 
            {
                Console.WriteLine("Both the strings are Anagrams.");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams.");
            }

        }
    }
}