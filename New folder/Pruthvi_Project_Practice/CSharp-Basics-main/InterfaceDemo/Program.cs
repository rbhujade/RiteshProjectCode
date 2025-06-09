// See https://aka.ms/new-console-template for more information

ICustomerWithInterest a = new Customer();
a.Name = "ABC";
a.Age = 32;
a.CalculateDiscout();
a.CalculateInterest();
Console.ReadLine();


public interface ICustomer
{
    string Name { get; set; }
    int Age { get; set; }
    void CalculateDiscout();
}

// ISP - Interface segragation Pricipal 
public interface ICustomerWithInterest : ICustomer
{
    void CalculateInterest();
}

public class Customer : ICustomerWithInterest
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void CalculateDiscout()
    {
        Console.WriteLine("Calculate Discout...");
    }

    public void CalculateInterest()
    {
        Console.WriteLine("Calculate Interest...");
    }
}
