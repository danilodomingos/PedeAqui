using PedeAqui.Infra.Publishers.Interfaces;
using PedeAqui.Infra.Publishers.Request;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;

namespace PedeAqui.Infra.Publishers
{
    public class OrderPublisher : IOrderPublisher
    {
        private readonly IModel _channel;

        public OrderPublisher(IModel channel)
        {
            _channel = channel;
        }

        public void OrderCreated(PostOrderRequest order)
        {
            // _channel.QueueDeclare(queue: "waiting.confirmation.orders",
            //                           durable: false,
            //                           exclusive: false,
            //                           autoDelete: false,
            //                           arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(order));

            _channel.BasicPublish(exchange: "orders",
                                          routingKey: "confirmation.orders",
                                          basicProperties: null,
                                          body: body);

            _channel.WaitForConfirmsOrDie(new TimeSpan(0, 0, 0, 0, 30));

        }
    }
}