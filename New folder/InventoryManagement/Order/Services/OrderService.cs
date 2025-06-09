using Confluent.Kafka;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Order.Models;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Order.Services
{
    public class OrderService : IOrderService
    {
        public readonly IProducer<Null,string> _producer;
        public readonly ProducerConfig _config;

        public OrderService() 
        {
            _config = new ProducerConfig { BootstrapServers = "localhost:9092" };
            _producer = new ProducerBuilder<Null,string>(_config).Build();
        }

        public async void Post(OrderModel orderModel)
        {
            var message = JsonConvert.SerializeObject(orderModel);
            var kafkaMessage = new Message<Null, string> {  Value = message };
            await _producer.ProduceAsync("orders", kafkaMessage);
        }
    }
}
