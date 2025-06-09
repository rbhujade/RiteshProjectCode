namespace File_Handling_Scenario
{
    class Program
    {
        public static void Main(string[] args)
        {
            Files();
            string file = "E:\\Study Material\\Design Pattern.txt";
            try
            {
                string text = File.ReadAllText(file);
                var word = text.ToLower()
                    .Split(new char[] { ' ', '\t', '\r', '\n', ',', '.', '!', '?', ';', ':', '-', '_', '[', ']', '(', ')', '"', '\'' ,'='},StringSplitOptions.RemoveEmptyEntries);
                
                var count = word.GroupBy(word => word)
                    .ToDictionary(group => group , group=> group.Count());

                Console.WriteLine("Word Counts:");
                foreach (var entry in count.OrderByDescending(o=> o.Value))
                {
                    Console.WriteLine($"{entry.Key.FirstOrDefault().ToString()}: {entry.Value}");
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void  Files()
        {
            string file = "E:\\Study Material\\Design Pattern.txt";

            string filesStream = File.ReadAllText(file);

            var word = filesStream.ToLower()
                .Split(new char[] { ' ', '\t', '\r', '\n', ',', '.', '!', '?', ';', ':', '-', '_', '[', ']', '(', ')', '"', '\'', '=' },StringSplitOptions.RemoveEmptyEntries);


            var countWord = word.GroupBy(word => word)
                .ToDictionary(g=> g,g=>g.Count());

            foreach (var item in countWord.OrderByDescending(o=> o.Value))
            {
                Console.WriteLine("Key : {0}   == Value {1}", item.Key.FirstOrDefault().ToString(),item.Value);
            }

            Console.ReadLine();
        }
    }
}