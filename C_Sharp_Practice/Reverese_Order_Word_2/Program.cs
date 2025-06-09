using System.Text;

namespace Reverese_Order_Word_2
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Exmaple();
            string str = "Welcome to my first program.";

            StringBuilder sb = new StringBuilder();
            int i = 0;

            int start = str.Length-1;
            int end = str.Length-1;

            while(start >0)
            {
                if (str[start] == ' ')
                {
                    i = start + 1;
                    while(i <= end)
                    {
                        sb.Append(str[i]);
                        i++;
                    }
                    sb.Append(' ');
                    end = start - 1;
                }
                start--;
            }

            for(i = 0; i <= end; i++)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        public static void Exmaple()
        {
            string str = "Welcome to my first program.";

            var array = str.Reverse().ToArray();
            Console.WriteLine(array);
        }
    }
}