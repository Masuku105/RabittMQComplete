using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Reciever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciever.Implementation
{
    public class MessageReciever : IMessageHandler
    {
        private readonly IConnect _connect;

        public MessageReciever(IConnect connect)
        {
            _connect = connect;
        }
        public void RecieveMessage()
        {
            using (var connection = _connect.GetConnection().CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

                Console.WriteLine("Waiting for messages....");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine("{0}", message);
                    Console.WriteLine("Messeage Received!!! ");
                };
                channel.BasicConsume(queue: "hello", autoAck: true, consumer: consumer);

                
            }
        }
    }
}
