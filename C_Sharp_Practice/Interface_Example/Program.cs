using System.Collections.Generic;
using System;
using Interface_Example;

public class Program
{
    private readonly AlertDAO storage = new AlertDAO();

    public static void Main(string[] args)
    {
        IA1 a1 = new A();
        IA2 a2 = new A();

        IA1 c1 = new C();
        IA2 c2 = new C();

        AlertDAO alertDAO = new AlertDAO();

        Guid id = alertDAO.AddAlert(DateTime.Now);

        alertDAO.GetAlert(id);
    }

    //public Guid RaiseAlert()
    //{
    //    Guid id = IAlertDAO.AddAlert(DateTime.Now);
    //    return id; //this.storage.AddAlert(DateTime.Now);
    //}

    //public DateTime GetAlertTime(Guid id)
    //{
    //    DateTime dt = IAlertDAO.GetAlert(id);
    //    return dt; //this.storage.GetAlert(id);
    //}
}

interface IA1
{
    void Show();
}

interface IA2
{
    void Show();
}

public class A : IA1, IA2
{
    public void Show()
    {
        Console.WriteLine("A Show");
    }
}

class B
{
    public void Show1()
    {
        IA1 a1 = new A();

        IA2 a2 = new A();

        a1.Show();
        a2.Show();
    }
}

class C : IA1, IA2
{
    public void Show()
    {
        Console.WriteLine("C Show");
    }
}

//public class AlertDAO : IAlertDAO
//{
//    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

//    public Guid AddAlert(DateTime time)
//    {
//        Guid id = Guid.NewGuid();
//        this.alerts.Add(id, time);
//        return id;
//    }

//    public DateTime GetAlert(Guid id)
//    {
//        return this.alerts[id];
//    }
//}

//public interface IAlertDAO
//{
//    Guid AddAlert(DateTime time);
//    DateTime GetAlert(Guid id);
//}