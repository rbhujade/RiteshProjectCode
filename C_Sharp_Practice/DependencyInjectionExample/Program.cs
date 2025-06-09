namespace DependencyInjectionExample
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console Logger : " + message);
        }
    }

    public class FileLogger : ILogger 
    {
        public readonly string FileName = "E:\\Study Material\\Project\\C_Sharp_Practice\\log.txt";

        public void Log(string message)
        {
            File.AppendAllText(FileName, message + Environment.NewLine);
            Console.WriteLine("Filelogger : Log to " + FileName);
        }
    }

    public class Application
    {
        public readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void Run() 
        {
            _logger.Log("Application is Running....");
        }
    }

    public class Program
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine("Choose logging method.");
            Console.WriteLine("1. Console Logging");
            Console.WriteLine("2. File Logging");
            Console.WriteLine("Enter your choice ");

            string choice = Console.ReadLine();
            ILogger logger;

            switch(choice)
            {
                case "1":
                    logger = new ConsoleLogger();
                    break;
                case "2":
                    logger = new FileLogger();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Console Logging.");
                    logger = new ConsoleLogger();
                    break;
            }

            var app = new Application(logger);
            app.Run();
            Console.ReadLine();
        }
    }
}