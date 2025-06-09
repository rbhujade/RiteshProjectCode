using System.Text;

namespace ReverseString_2
{
    class program
    {
        public static void Main(string[] args) 
        {
            ReverseString();
            string str = "ritesh bhujade";

            char[] chars = str.ToCharArray();

            for (int i = 0,j = str.Length -1 ; i < j; i++,j--) 
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            string result = new string(chars);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void ReverseString()
        {
            string str = "Hellow World";

            char[] chars = str.ToCharArray();

            StringBuilder sb = new StringBuilder();

            for(int i = str.Length - 1;i>=0;i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}