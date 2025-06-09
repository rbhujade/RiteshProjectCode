using Confluent.Kafka;
using Newtonsoft.Json;
using Payment.Models;
using System.Collections;

namespace Payment.Services
{
    public class PaymentService : BackgroundService
    {
        public readonly IConsumer<Ignore,string> _consumer;
        public readonly ConsumerConfig _consumerConfig;
        private readonly ILogger<PaymentService> _logger;

        public PaymentService(ILogger<PaymentService> logger)
        {
            _logger = logger;
            _consumerConfig = new ConsumerConfig
            { 
                BootstrapServers = "localhost:9092",
                GroupId = "payment-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            _consumer = new ConsumerBuilder<Ignore,string>(_consumerConfig).Build();
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _consumer.Subscribe("orders");
            while (!cancellationToken.IsCancellationRequested)
            {
                ProcessKafkaMessage(cancellationToken);
                Task.Delay(TimeSpan.FromMinutes(1), cancellationToken);
            }

            _consumer.Close();
        }

        public void ProcessKafkaMessage(CancellationToken cancellationToken)
        {
            var result = _consumer.Consume(cancellationToken);
            var orderResult = result.Message.Value;
            Console.WriteLine($"Payment processed for order: {orderResult}");
        }

        public OrderModel Get()
        {
            OrderModel m = new OrderModel();
            return m;
        }
    }
}
