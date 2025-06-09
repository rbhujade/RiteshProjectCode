namespace Check_Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            Palidrome_2("{[{}]}");
            Palindrome_1();
            
            Console.WriteLine("{[{}]} : " + Palidrome_2("123321"));
            Console.ReadLine();
        }

        public static bool Palidrome_2(string str)
        {
            for(int i=0,j = str.Length -1 ; i<= str.Length/2;i++,j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Palindrome_1()
        {
            string str = "ritesh";
            bool flag = false;

            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                //0,3
                //1,2

                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            //Console.ReadKey();
        }
    }
}