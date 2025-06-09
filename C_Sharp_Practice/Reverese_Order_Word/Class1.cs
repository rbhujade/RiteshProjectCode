using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverese_Order_Word
{
    class Class1
    {
        public void Reverse()
        {
            string str = "hello ritesh bhujade";
            int i;
            StringBuilder sb = new StringBuilder();

            int start = str.Length - 1;
            int end = str.Length - 1;

            while(start > 0)
            {
                if (str[start] == ' ')
                {
                    i = start + 1;
                    while(i <= end)
                    {
                        sb.Append(str[i]);
                        i++;
                    }
                    sb.Append(" ");
                    end = start - 1;
                }
                start--;
            }
        }

        public void ReverseWord()
        {
            string str = "Ritesh Bhujade";
            //"hsetiR edajuhB"

            var word = str.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {
                char[] chars = word[i].ToCharArray();
                Array.Reverse(chars);
                word[i] = new string(chars);
            }
            //Array.Reverse(word);
            string result = string.Join(" ", word);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
