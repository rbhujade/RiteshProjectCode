namespace Array_Find_Unique_Num
{
    class Program
    {
        public static void Main(string[] args) 
        {
            GetSingleItemByXOR();
            GetSingleItemByDisctionary();
        }

        //using Disctionary
        public static void GetSingleItemByDisctionary()
        {
            int[] numbers = { 2, 4, 7, 9, 2, 4, 7, 9, 2, 4, 7, 9, 3 };

            var result = numbers.GroupBy(x => x).ToDictionary(d => d.Key, d => d.Count());

            int num = result.FirstOrDefault(f => f.Value == 1).Key;

            Console.WriteLine(num + " have Single item in Array.");
            Console.ReadLine();
        }

        //using XOR
        public static void GetSingleItemByXOR()
        {
            int[] numbers = { 2, 4, 7, 9, 2, 4, 7, 9, 2, 4, 7, 9, 3 };

            Dictionary<int,int> dic = new Dictionary<int,int>();

            foreach (int x in numbers) 
            {
                //dic.Add(x,1);
            }

            Console.WriteLine( " have Single item in Array.");
            Console.ReadLine();
        }
    }
}