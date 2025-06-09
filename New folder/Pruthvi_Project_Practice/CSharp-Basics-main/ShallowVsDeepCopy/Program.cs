// See https://aka.ms/new-console-template for more information

// SHALLOW COPY
Person person = new Person() { Name = "John",Age = 36, Address = new Address() { City = "New York"} };
Person person1 = person.ShallowCopy();
person.Address.City = "Los Angeles";
Console.WriteLine("====== SHALLOW COPY =========");
Console.WriteLine("person => " + person.Address.City);
Console.WriteLine("person 1 => " + person1?.Address?.City);

// DEEP COPY
Person personDeep = new Person() { Name = "Sam", Age = 32, Address = new Address() { City = "Pune" } };
Person personDeep1 = personDeep.DeepCopy();
personDeep.Address.City = "Mumbai";

Console.WriteLine(Environment.NewLine);
Console.WriteLine("====== DEEP COPY =========");
Console.WriteLine("person Deep => " + personDeep.Address.City);
Console.WriteLine("person Deep 1 => " + personDeep1?.Address?.City);

Console.ReadLine();


// SHALLOW COPY
public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Address? Address { get; set; }

    public Person ShallowCopy()
    {
       return (Person)this.MemberwiseClone();
    }
    public Person DeepCopy()
    {
        Person clone = (Person)this.MemberwiseClone();               // Shallow copy first
        clone.Address = new Address { City = this?.Address?.City };  // Deep copy of reference type
        return clone;
    }
}

public class Address
{
    public string? City { get; set; }
}