using Confluent.Kafka;
using Newtonsoft.Json;

namespace KafkaConsumer
{
    public class KafkaConsumerService : BackgroundService
    {
        public readonly IConsumer<Null,string> _consumer;

        public KafkaConsumerService()
        { 
            var _config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "order-consumer",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            _consumer = new ConsumerBuilder<Null,string>(_config).Build();
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _consumer.Subscribe("order-events");
            var result = _consumer.Consume(cancellationToken);
            var json = JsonConvert.DeserializeObject<OrderDetails>(result.Message.Value);

            Console.WriteLine(json);
            _consumer.Close();
        }

        public class OrderDetails
        {
            public int OrderId { get; set; }
            public string? ProductName { get; set; }
            public decimal Price { get; set; }
            public DateTime OrderDate { get; set; }
        }
    }
}
