using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaConsumerConsole
{
    public class ConsumerService : IHostedService
    {
        public readonly IConsumer<string,string> _consumer;

        public ConsumerService(IConsumer<string, string> consumer)
        {
            _consumer = consumer;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _consumer.Subscribe("order-events");

            Task.Run(() => {
                while (!cancellationToken.IsCancellationRequested) 
                {
                    var result = _consumer.Consume(cancellationToken);
                    if (result == null)
                    {
                        return;
                    }
                    var data = JsonConvert.DeserializeObject<OrderDetails>(result.Message.Value);
                }
            
            },cancellationToken);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            return null;
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
