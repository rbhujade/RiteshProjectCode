using System.Text;

namespace Possible_Substring_of_String
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string str = "abcd";

            for (int i = 0; i < str.Length; ++i) 
            {
                StringBuilder stringBuilder = new StringBuilder(str.Length - i);

                for (int j = i; j < str.Length; ++j)
                {
                    stringBuilder.Append(str[j]);
                    Console.WriteLine(stringBuilder + " ");
                }
            }

            Console.ReadLine();
        }
    }
}