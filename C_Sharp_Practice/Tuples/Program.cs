namespace Tuples
{
    class Program
    {
        public static void Main(string[] args)
        {
            var result = ReturnTupleValues();
            Console.WriteLine(result.str);
            Console.WriteLine(result.num);
            Console.ReadLine();
        }

        public static (string str,int num) ReturnTupleValues()
        {
            return ("Ritesh", 33);
        }
    }
}