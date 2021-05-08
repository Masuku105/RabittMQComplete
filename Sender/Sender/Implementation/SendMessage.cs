using Sender.Interfaces;
using System;
using System.Text;
using RabbitMQ.Client;

namespace Sender.Implementation
{
    public class SendMessage : IMessageHandler
    {
        private readonly IConnect _connect;

        public string Name { get; set; }
        public SendMessage(IConnect connect)
        {
            _connect = connect;
        }
        public void Send()
        {
            using var connection = _connect.GetConnection().CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
            string message = $"Hello my name is, {Name}";
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
            Console.WriteLine("Message Sent :)");

        }
    }
}
