namespace Generics
{
    class Program
    {
        public static void Main(string[] args) 
        {
            ExGenerics exGenerics= new ExGenerics();
            exGenerics.GenericsExample();

            bool calculater = Calculater<int>.AreEquel(14,10);
            bool val2 = Calculater<string>.AreEquel("Test", "Test");


            var intData = new GenericClass<int>(42);
            Console.WriteLine(intData.GetData());

            var strData = new GenericClass<string>("Test");
            Console.WriteLine(strData.GetData());

            //
            bool flag = CheckEquals(40,40);

            if (flag) 
            {
                Console.WriteLine("Equals");
            }
            else 
            { 
                Console.WriteLine("Not Equal."); 
            }

            Console.ReadLine();
        }

        public static bool CheckEquals<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public static bool CheckEquals1(int a,int b)
        {
            return a.Equals(b);
        }

        
    }

    public class Calculater<T>
    {
        public static bool AreEquel(T a, T b)
        {
            return a.Equals(b);
        }
    }

    public class ExGenerics()
    {
        public void GenericsExample()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            double[] doubles = { 1.0, 2.0, 3.0 };
            string[] strings = { "1", "2", "3" };

            GenericsMethod(ints);
            GenericsMethod(doubles);
            GenericsMethod(strings);
        }
        public void GenericsMethod<Thing>(Thing[] array)
        {
            foreach (Thing i in array)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine();
        }
    }
}
