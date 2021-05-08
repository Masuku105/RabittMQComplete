using RabbitMQ.Client;
using Reciever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciever.Implementation
{
    public class LocalConnection : IConnect
    {
        public ConnectionFactory GetConnection()
        {
            return new ConnectionFactory() { HostName = "localhost" };
        }
    }
}
