using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {

            // Xml Serializer
            XmlSerializer formatter = new XmlSerializer(typeof(EmployeeDetails));
            Stream stream = new FileStream(@"D:/Test1.xml", FileMode.Create);
            EmployeeDetails employeeDetails = new EmployeeDetails(1, "Vijay Shinde", 35, "Mum-Pun Road", "MH", "IND");
            formatter.Serialize(stream, employeeDetails);
            stream.Close();

            stream = new FileStream(@"D:/Test1.xml", FileMode.Open);
            EmployeeDetails empDetails = (EmployeeDetails)formatter.Deserialize(stream);

            // Binary Formatter
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream(@"D:/Test.txt", FileMode.Create);
            //EmployeeDetails employeeDetails = new EmployeeDetails(1, "Vijay Shinde", 35, "Mum-Pun Road", "MH", "IND");
            //formatter.Serialize(stream, employeeDetails);

            TupleValue tv = new TupleValue();
            (int, string) result = tv.ReturnRate();
            Console.WriteLine($"Value 1 :- {result.Item1} Value 2 :-{result.Item2}");

            var x = 5 + 6 + "4";
            Console.WriteLine($"Result is :- {x}");

            Console.ReadKey();
        }
    }

    public class TupleValue
    {
        public (int, string) ReturnRate()
        {
            return (1, "Test Value");
        }
    }

    [Serializable]
    public class EmployeeDetails
    {
        public EmployeeDetails()
        {
        }

        public EmployeeDetails(int id, string name, int age, string streetName, string state, string country)
        {
            this.Employee  = new Employee();
            //Employee emp = this.Employee;
            this.Employee.ID = id;
            this.Employee.Name = name;
            this.Employee.Age = age;

            this.Address  = new Address();
            //Address address = this.Address;
            this.Address.StreetName = streetName;
            this.Address.State = state;
            this.Address.Country = country;
        }       

        public Employee Employee { get; set; }              
        public Address Address { get; set; }
    }

    [Serializable]
    public class Employee
    {
        [XmlElement("Roll_Number")]
        public int ID { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }
    }

    [Serializable]
    public class Address
    {
        [XmlElement("Street_Name")]
        public string StreetName { get; set; }
        [XmlElement("State")]
        public string State { get; set; }
        [XmlElement("Country")]
        public string Country { get; set; }
    }
}
