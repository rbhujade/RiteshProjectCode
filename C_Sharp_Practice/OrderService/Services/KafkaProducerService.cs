using Confluent.Kafka;

namespace OrderService.Services
{
    public class KafkaProducerService
    {
        private readonly string _bootstrapServers = "localhost:9092";

        public async Task ProduceAsync(string topic, string message)
        {
            var config = new ProducerConfig { BootstrapServers = _bootstrapServers };

            using var producer = new ProducerBuilder<Null, string>(config).Build();
            var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
            Console.WriteLine($"Produced message to: {result.TopicPartitionOffset}");
        }

        //private readonly IProducer<Null, string> _producer;

        //public KafkaProducerService(string broker)
        //{
        //    var config = new ProducerConfig { BootstrapServers = broker };
        //    _producer = new ProducerBuilder<Null, string>(config).Build();
        //}

        //public async Task PublishOrderCreatedEvent(string message)
        //{
        //    await _producer.ProduceAsync("order-created-topic", new Message<Null, string> { Value = message });
        //}
    }
}
