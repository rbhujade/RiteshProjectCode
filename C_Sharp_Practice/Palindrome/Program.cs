namespace Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CheckPalindrom1();

            bool check = CheckPalindrom2();
            if (check)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("No Palindrome");
            }
            Console.ReadLine();
        }

        public static bool CheckPalindrom2()
        {
            string str = "racecar";

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if(char.ToLower(str[left]) != char.ToLower(str[right]) )
                {  
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static void CheckPalindrom1()
        {
            string str = "ritesh";

            string reverse = new string(str.Reverse().ToArray());

            bool palindrome = str.Equals(reverse, StringComparison.OrdinalIgnoreCase);

            if (palindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("No Palindrome");
            }
        }
    }
}
