using System.Text;

namespace Reverese_Order_Word
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.ReverseWord();

            string str = "Welcome to My channel.";
            StringBuilder reverseSentence = new StringBuilder();

            int i;

            int start = str.Length -1;//20
            int end = str.Length -1;//20

            while (start > 0)
            {
                if (str[start] == ' ')//10
                {
                    i = start + 1; //11
                    while (i <= end)//11<=12
                    {
                        reverseSentence.Append(str[i]);//My
                        i++;//15
                    }
                    reverseSentence.Append(" ");
                    end =start - 1;//12
                }
                start --;
            }

            for (i = 0; i <= end; i++)
            {
                reverseSentence.Append(str[i]);

            }
            Console.WriteLine(reverseSentence.ToString());
            Console.ReadLine();
        }
    }
}