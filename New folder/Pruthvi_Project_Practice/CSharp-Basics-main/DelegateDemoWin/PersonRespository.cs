using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoWin
{
    public class PersonRespository
    {
        public static List<Person> GetPeople()
        {
            var persons = new List<Person>()
            {
                new Person() {FirstName = "Ritesh", LastName="Bhujade", Rating = 5},
                new Person() {FirstName = "Akash", LastName="Yenkure", Rating = 3},
                new Person() {FirstName = "Ram", LastName="Shinde", Rating = 3},
                new Person() {FirstName = "Sham", LastName="Disuja", Rating = 4},
                new Person() {FirstName = "Pallavi", LastName="K", Rating = 2},
                new Person() {FirstName = "Dhanu", LastName="Kale", Rating = 2},
            };

            return persons;
        }
    }

    //public delegate string PersonFormat(Person person);

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return string.Format($"{FirstName}, {LastName}");
        }

        public string ToString(Func<Person,string> format)
        {
            if (format != null)
                return format(this);
            return string.Empty;
        }
    }
}
