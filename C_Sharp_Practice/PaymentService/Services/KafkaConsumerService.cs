using Confluent.Kafka;
using System.Text.Json;

namespace PaymentService.Services
{
    public class KafkaConsumerService : BackgroundService
    {
        private readonly string _topic = "order-topic";
        private readonly string _bootstrapServers = "localhost:9092";
        private readonly string _groupId = "payment-group";

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = _bootstrapServers,
                GroupId = _groupId,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            Task.Run(() =>
            {
                using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
                consumer.Subscribe(_topic);

                while (!stoppingToken.IsCancellationRequested)
                {
                    var result = consumer.Consume(stoppingToken);
                    Console.WriteLine($"Payment Service consumed: {result.Message.Value}");

                    // Deserialize and simulate payment processing
                    var order = JsonSerializer.Deserialize<Order>(result.Message.Value);
                    // Save payment logic here...
                }
            });

            return Task.CompletedTask;
        }
    }
}
