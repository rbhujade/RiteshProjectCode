using Confluent.Kafka;

namespace UserService.Services
{
    public class UserAuditConsumerService :BackgroundService
    {
        private readonly string _topic = "order-topic";
        private readonly string _bootstrapServers = "localhost:9092";
        private readonly string _groupId = "user-audit-group";

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
                    Console.WriteLine($"User Service Audit log: {result.Message.Value}");
                    // Store to audit table, log to file, etc.
                }
            });

            return Task.CompletedTask;
        }
    }
}
