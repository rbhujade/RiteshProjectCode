// See https://aka.ms/new-console-template for more information
using Unity;

IUnityContainer container = new UnityContainer();
container.RegisterType<IMessageService,EmailService>("Email");
container.RegisterType<IMessageService,SMSService>("SMS");

var sms = container.Resolve<IMessageService>("SMS");
var email = container.Resolve<IMessageService>("Email");
  
sms.SendMessages("SMS...");
email.SendMessages("EMAIL...");

Console.ReadKey();




public interface IMessageService
{
    void SendMessages(string msg);
}

public class EmailService : IMessageService
{
    public void SendMessages(string msg)
    {
        Console.WriteLine("Email Service => " + msg);
    }
}

public class SMSService : IMessageService
{
    public void SendMessages(string msg)
    {
        Console.WriteLine("SMS Service => " + msg);
    }
}