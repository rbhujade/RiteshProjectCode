using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string str)
        { 
            if(str.Length > 0)
            {
                char[] array = str.ToCharArray();
                array[0] = char.IsUpper(array[0]) ? char.ToLower(array[0]) : char.ToUpper(array[0]);

                return new string(array);
            }

            return str;
        }

        public static int DateTimeExtensions(this DateTime dt)
        {
            int age = DateTime.Now.Year - dt.Year;
            if (DateTime.Now < dt.AddYears(age))
                age--;
            return age;
        }
    }
}
