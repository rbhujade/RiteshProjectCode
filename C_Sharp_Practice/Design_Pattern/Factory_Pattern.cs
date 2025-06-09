using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class Factory_Pattern
    {
        public static INotification GetNotification(string type) 
        {
            switch (type.ToLower())
            {
                case "email" :
                    return new EmailNotification();
                case "sms":
                    return new SMSNotifucation();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }

    public interface INotification
    {
        void Notify(string msg);
    }

    public class EmailNotification : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine($"Email Notification: {msg}");
        }
    }

    public class  SMSNotifucation : INotification
    {
        public void Notify(string msg) 
        {
            Console.WriteLine($"SMS Notification: {msg}");
        }
    }
}
