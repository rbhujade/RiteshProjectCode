using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // String reverse using Linq
            string stringInput = "Pruthviraj Nikam";
            var resultstring = new string(stringInput.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(resultstring);

            // String reverse using without Linq
            string reverse = string.Empty;
            for (int i = stringInput.Length -1; i >=0; i--)
            {
                reverse += stringInput[i];
            }
            //Console.WriteLine(reverse);

            // Reverse each word from string array and sequence as well.
            //var actor = new[] { "amitabh", "abhishek", "jitendra", "Salman", "Aishwariya" };
            var actor = "amitabh,abhishek,jitendra,Salman,Aishwariya";
            var resultstring1 = actor.Split(" ").Reverse().Select(a => new string(a.Reverse().ToArray()));
            foreach (var m in resultstring1)
            {
                Console.WriteLine(m);
            }

            // ************ REMOVE DUPLICATE CHAR FROM STRING
            // 1. Using HashSet
            string inputString = "dotnetworld";
            string resultString = string.Empty;
            var unique = new HashSet<char>(inputString);
            foreach (var c in unique)
            {
                resultString += c;
            }
            // Console.WriteLine("After Removing Duplicates : " + resultString);

            // 2. Using Distinct
            var result = new string(inputString.ToCharArray().Distinct().ToArray());
            //Console.WriteLine("After Removing Duplicates : " + result);

            // 3. Using simple way
            string revStr = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!revStr.Contains(inputString[i]))
                    revStr += inputString[i];
            }
            //Console.WriteLine("After Removing Duplicates : " + revStr);


            // *********   REMOVE DUPLICATE WORLD FROM STRING
            string SetenceString = "red white black white green yellow red red black white";
            var result1 = string.Join(" ", SetenceString.ToLower().Split().Distinct());
            var resWithCaps = string.Join(" ", result1.Split().Select(a => char.ToUpper(a[0]) + a.Substring(1)));
            var resWithCount = string.Join(" ", SetenceString.Split().Select(a => $"{a} => " + a.Count()).Distinct());
            //Console.WriteLine(result1);
            //Console.WriteLine(resWithCaps);
            Console.WriteLine(resWithCount);

            Console.ReadKey();
        }
    }
}
