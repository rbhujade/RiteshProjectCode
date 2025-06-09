namespace Occurrences
{
    class Program
    {
        public static void Main(string[] args) 
        {
            UsingLinq();
            CountUsingDictionary();
        }

        public static void UsingLinq()
        {
            string str = "bannana";

            var result = str.GroupBy(g=>g).ToDictionary(d=>d.Key,d=>d.Count());

            //to find max occurences char.
            int max = result.Max(d => d.Value);
            char maxChar = result.LastOrDefault(f=>f.Value == max).Key;

            foreach (var item in result)
            {
                Console.WriteLine("Character : " + item.Key + "      Count : " + item.Value);
            }
        }

        public static void CountUsingDictionary()
        {
            string str = "bannana";

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char item in str)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1;
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine("Character : " + item.Key + "      Count : " + item.Value);
            }

            Console.WriteLine();
        }
    }
}