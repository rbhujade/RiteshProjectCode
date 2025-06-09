using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    public interface IMessegeService
    {
        void SendMsg(string msg);
    }

    public class MessageService : IMessegeService
    {
        public void SendMsg(string msg) 
        {
            Console.WriteLine($"Sending message : {msg}");
        }
    }

    public class Notification
    {
        public readonly IMessegeService _messegeService;

        public Notification(IMessegeService messegeService)
        {
            _messegeService = messegeService;
        }

        public void SendMsg(string msg) 
        { 
            _messegeService.SendMsg(msg);
        }
    }

    // Violates DIP: High-level class depends on a low-level class
    public class EmailService
    {
        public void SendEmail(string msg)
        {
            Console.WriteLine($"Sending email : {msg}");
        }
    }

    public class Notification1
    {
        private readonly EmailService _service;

        public Notification1(EmailService service)
        {
            _service = service;
        }

        public void Notify(string msg)
        {
            _service.SendEmail(msg);
        }
    }
}
