using Microsoft.Extensions.DependencyInjection;
using Sender.Interfaces;
using System;

namespace Sender
{
    public class Program
    {
        public static void Main()
        {
            var container = StartUp.ConfigurServices();
            var sender = container.GetRequiredService<IMessageHandler>();
            sender.Send();
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
