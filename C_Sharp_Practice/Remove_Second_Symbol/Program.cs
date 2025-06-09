using System.Text;

namespace Remove_Second_Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "foo bar foo $ foo $ bar $";

            bool flag = true;
            StringBuilder sb = new StringBuilder();
            foreach (string item in str.Split(" "))
            {
                if(item == "$")
                {
                    if (flag) 
                    {
                        sb.Append(item);
                        flag = false;
                    }
                }
                else
                {
                    sb.Append(item);
                }
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
