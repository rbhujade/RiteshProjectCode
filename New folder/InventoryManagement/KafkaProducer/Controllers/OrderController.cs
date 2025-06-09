using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KafkaProducer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        public readonly IProducer<Null, string> _producer;
        public const string Topic = "order-events";

        public OrderController()
        {
            var _producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
            _producer = new ProducerBuilder<Null,string>(_producerConfig).Build();
            
        }

        [HttpPost("place-order")]
        public async Task<IActionResult> PlaceOrder(OrderDetails orderDetails)
        {
            var message = new Message<Null, string>
            {
                Value = JsonConvert.SerializeObject(orderDetails)
            };

            await _producer.ProduceAsync(Topic , message);
            return Ok("Order placed successfully.");
        }
    }
}
