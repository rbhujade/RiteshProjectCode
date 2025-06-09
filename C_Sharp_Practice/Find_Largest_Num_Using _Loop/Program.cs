namespace Find_Largest_Num_Using_Loop
{
    class Program
    {
        public static void Main(string[] args) 
        {
            SecondLargestNum();
        }

        public static void SecondLargestNum()
        {
            int[] ints = {  3 ,5 ,2,6,1,5,4};

            int max1 = ints.Min(i => i);
            int max2 = ints.Min(i => i);

            foreach (int i in ints) 
            { 
                if (i > max1)
                {
                    max2 = max1; // max1 = 1 ,i=3 ,max2 = 1
                    max1 = i;
                }
            }

            Console.WriteLine(max2);
            Console.ReadLine();
        }
    }
}