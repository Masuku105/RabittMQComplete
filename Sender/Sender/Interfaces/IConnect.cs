using System;
using RabbitMQ.Client;
using System.Text;
namespace Sender.Interfaces
{
    public interface IConnect
    {
        ConnectionFactory GetConnection();
    }
}
