using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoWin
{
    public  class Formatters
    {
        public static string Default(Person person)
        {
            return person.ToString();
        }

        public static string LastNameToUpper(Person person)
        {
            return person.LastName.ToUpper();
        }

        public static string FirstNameToLower(Person person)
        {
            return person.FirstName.ToLower();
        }

        public static string FullName(Person person)
        {
            return string.Format($"{person.LastName}, {person.FirstName}");
        }
    }
}
