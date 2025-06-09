using Confluent.Kafka;
using KafkaConsumerConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var _consumerConfig = new ConsumerConfig 
{ 
    BootstrapServers = "localhost:9092",
    GroupId = "order-consumer",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, service) => 
    { 
        service.AddSingleton(new ConsumerBuilder<string,string>(_consumerConfig).Build());
        service.AddHostedService<ConsumerService>();
    });

var host = builder.Build();
var kafkaConsumerService = host.Services.GetRequiredService<IHostedService>();
await kafkaConsumerService.StartAsync(default);
//await kafkaConsumerService.StopAsync(default);
await Task.Delay(Timeout.Infinite);