namespace Generics_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            string[] strings = { "1", "2", "3" };

            Generics(ints);
            Console.WriteLine("\n");
            Generics(strings);

            Console.ReadLine();
        }

        public static void Generics<T>(T[] ints)
        {
            foreach (T i in ints) 
            {
                Console.Write(i + " ");
            }
        }
    }
}