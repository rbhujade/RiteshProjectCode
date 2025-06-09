using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrence_of_Each_Character
{
    internal class Occurences_Of_Special_Character
    {
        public void OccurencesOfSpecialChar()
        {
            string str = "Hello@World! It's 2024. #CSharp@Rocks!!";

            Dictionary<char,int> map = new Dictionary<char,int>();

            foreach (char item in str)
            {
                if(!char.IsLetterOrDigit(item) && !char.IsWhiteSpace(item))
                {
                    if(map.ContainsKey(item))
                    {
                        map[item]++;
                    }
                    else
                    {
                        map.Add(item, 1);
                    }
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"Special Character : {item.Key}   : Count - {item.Value}");
            }
            
        }
    }
}
