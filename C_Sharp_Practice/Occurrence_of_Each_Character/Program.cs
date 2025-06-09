namespace Occurrence_of_Each_Character
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Occurences_Of_Special_Character occ = new Occurences_Of_Special_Character();
            occ.OccurencesOfSpecialChar();


            Occurences();
            string str = "Welcome to my first program.";

            Dictionary<char,int> dic = new Dictionary<char,int>();

            dic = str.GroupBy(x => x).ToDictionary(d=> d.Key , d=>d.Count());

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key +"  -  "+ item.Value);
            }
            Console.ReadLine();
        }

        public static void Occurences()
        {
            string str = "Welcome to my first program.";

            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

            foreach (var character in str)
            {
                if(character != ' ')
                {
                    if (!keyValuePairs.ContainsKey(character))
                    {
                        keyValuePairs.Add(character, 1);
                    }
                    else
                    {
                        keyValuePairs[character]++;
                    }
                }
            }

            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine(keyValue.Key + " -  " + keyValue.Value);
            }

            //Console.ReadLine();
        }
    }
}