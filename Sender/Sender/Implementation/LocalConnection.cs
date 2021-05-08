using RabbitMQ.Client;
using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sender.Implementation
{
    public class LocalConnection : IConnect
    {
        public ConnectionFactory GetConnection()
        {
            return new ConnectionFactory() { HostName = "localhost" };
        }
    }
}
