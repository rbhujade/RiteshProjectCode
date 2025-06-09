using Microsoft.Extensions.DependencyInjection;

namespace DI_Scoped_Transient_Singleton
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var service = new ServiceCollection();

            //service.AddSingleton<IMyService,MyService>();
            //service.AddScoped<IMyService, MyService>();
            service.AddTransient<IMyService, MyService>();

            var provider = service.BuildServiceProvider();

            var service1 = provider.GetService<IMyService>();
            var service2 = provider.GetService<IMyService>();

            Console.WriteLine($"Service 1 GUID: {service1.GetGuid()}");
            Console.WriteLine($"Service 2 GUID: {service2.GetGuid()}");

            using (var scope = provider.CreateScope())
            {
                var scopedService1 = scope.ServiceProvider.GetService<IMyService>();
                var scopedService2 = scope.ServiceProvider.GetService<IMyService>();

                Console.WriteLine($"Scoped Service 1 GUID: {scopedService1.GetGuid()}");
                Console.WriteLine($"Scoped Service 2 GUID: {scopedService2.GetGuid()}");
            }

            Console.ReadLine();
        }
    }
}