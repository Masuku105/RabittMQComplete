using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciever.Interfaces
{
    public interface IConnect
    {
        ConnectionFactory GetConnection();
    }
}
