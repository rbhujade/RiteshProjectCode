using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCapsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // First letter is in Upper case of each word
            string str1 = "This is pune city in Maharashtra";
            var result1 = string.Join(" ", str1.Split().Select(a => Char.ToUpper(a[0]) + a.Substring(1)));
            Console.WriteLine($" Resultant string =>  {result1}");


            // Occurrence of word in string
            string str = "This is test string to test word occurences in string word test test";
            Dictionary<string, int> dic = new Dictionary<string, int>();
            var result = str.Split();

             foreach (var item in result)
             {
                 if(!dic.ContainsKey(item))
                 {
                     dic.Add(item, 1);
                 }
                 else
                 {
                     dic[item] = dic[item] + 1;                
                 }
             }

             foreach (KeyValuePair<string, int> item in dic)
             {
                 Console.WriteLine($"Word => {item.Key} : {item.Value}");
             }

             // Specific word in string
             var x = result.Count(a => a == "test");

             Console.WriteLine($"String word count is => {result.Length}");
           

            // Occurrence of char in string
            //string message = "This is test string";
            //Dictionary<char, int> dic = message.Replace(" ", string.Empty).ToUpperInvariant()
            //                                    .GroupBy(a => a)
            //                                    .ToDictionary(b => b.Key, b => b.Count());

            //foreach (KeyValuePair<char, int> item in dic)
            //{
            //    Console.WriteLine($"Char: {item.Key} - Count: {item.Value}");
            //}

            Console.ReadKey();
        }
    }
}
