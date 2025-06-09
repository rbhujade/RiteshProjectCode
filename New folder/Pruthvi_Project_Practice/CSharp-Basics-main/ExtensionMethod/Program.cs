using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Months
            List<string> months = new List<string>()
            { 
                "January","February","March","April","May","June","July","August","September","October","November","December"
            };

            // Get Name
            List<string> names = new List<string>()
            {
                "Ramesh","Shrikant","Ram","Rahul","Kiran","Nitin","Raj"
            };

            Console.WriteLine($"Result -> { months.AddDelimiter(",")}");
            Console.WriteLine($"Result -> { names.AddDelimiter("|")}");

            Console.ReadKey();
        }        
    }

    public static class CollectionExtension
    {
        public static string AddDelimiter(this IEnumerable<string> input, string delimiter)
        {
            var result = new StringBuilder();
            foreach (var item in input)
            {
                if (result.Length > 0)
                    result.Append(delimiter);
                result.Append(item);
            }
            return result.ToString();
        }
    }
}
