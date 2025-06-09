namespace Fibonaci_Num
{
    class Program
    {
        public static void Main(string[] args)
        { 
            int f1 =0 , f2 = 1 , f3 =0 ;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 0; i <= 10; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadLine();
        }

    }
}