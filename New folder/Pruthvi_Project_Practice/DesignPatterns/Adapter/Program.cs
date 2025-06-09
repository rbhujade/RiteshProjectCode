// See https://aka.ms/new-console-template for more information
ITarget adapter = new EmployeeAdapter();
ThirdPartyBillingSystem billingSystem = new ThirdPartyBillingSystem(adapter);
billingSystem.ShowEmployeeList();

Console.ReadKey();



/// <summary>
/// ITarger Interface
/// </summary>
public interface ITarget
{
    List<string> GetEmployeeList();
}

/// <summary>
/// Client
/// </summary>
public class ThirdPartyBillingSystem (ITarget empSource)
{
    private ITarget empSource = empSource;

    //public ThirdPartyBillingSystem(ITarget empSource)
    //{
    //    this.empSource = empSource;f
    //}

    public void ShowEmployeeList()
    {
        List<string> employee = empSource.GetEmployeeList();
        Console.WriteLine("######### Employee List ##########");
        foreach (var item in employee)
        {
            Console.WriteLine(item);
        }
    }
}

/// <summary>
/// The 'Adaptee' class
/// </summary>
public class HRSystem
{
    public string[][] GetEmployees()
    {
        string[][] list = new string[4][];
        list[0] = ["100", "Deepak", "Team Leader"];
        list[1] = ["101", "Rohit", "Developer" ];
        list[2] = ["102", "Gautam", "Developer" ];
        list[3] = ["103", "Dev", "Tester" ];
        return list;
    }
}

/// <summary>
/// The 'Adapter' class
/// </summary>
public class EmployeeAdapter : HRSystem, ITarget
{    
    public List<string> GetEmployeeList()
    {
        List<string> employeeList = new List<string>();
        string[][] list = GetEmployees();

        foreach (string[] employee in list)
        {
            employeeList.Add($"{employee[0]}, {employee[1]}, {employee[2]}");
        }
        return employeeList;
    }
}