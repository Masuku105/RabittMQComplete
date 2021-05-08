using Microsoft.Extensions.DependencyInjection;
using Reciever.Interfaces;
using System;

namespace Reciever
{
    public class Program
    {
        public static void Main()
        {
            var container = StartUp.ConfigurServices();
            var reciever = container.GetRequiredService<IMessageHandler>();
            reciever.RecieveMessage();
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}