using Confluent.Kafka;

namespace InventoryProducer.Services
{
    public class ProducerService
    {
        public readonly IConfiguration _configuration;
        public readonly IProducer<Null,string> _producer;

        public ProducerService(IConfiguration configuration)
        {
            _configuration = configuration;

            var producerconfig = new ProducerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"]
            };

            _producer = new ProducerBuilder<Null, string>(producerconfig).Build();
        }

        public async Task ProduceAsync(string topic,string message)
        {
            var kafkaMessage = new Message<Null,string> { Value = message, };
            await _producer.ProduceAsync(topic, kafkaMessage);
        }
    }
}
