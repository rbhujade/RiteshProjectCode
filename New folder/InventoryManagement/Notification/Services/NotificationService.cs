using Confluent.Kafka;
using Newtonsoft.Json;

namespace Notification.Services
{
    public class NotificationService : BackgroundService
    {
        public readonly IConsumer<Ignore,string> _consumer;
        public readonly ConsumerConfig _consumerConfig;

        public NotificationService()
        {
            _consumerConfig = new ConsumerConfig()
            {
                BootstrapServers = "localhost:9092",
                GroupId = "notification-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            _consumer = new ConsumerBuilder<Ignore,string>(_consumerConfig).Build();
            //_consumer.Subscribe("orders");
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _consumer.Subscribe("orders");
            while (!cancellationToken.IsCancellationRequested)
            {
                var message = _consumer.Consume(cancellationToken);
                var result = message.Message.Value;
                Console.WriteLine(result);

                Task.Delay(TimeSpan.FromMinutes(1), cancellationToken);
            }
            _consumer.Close();
        }
    }
}
