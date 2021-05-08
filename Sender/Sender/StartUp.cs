using Microsoft.Extensions.DependencyInjection;
using Sender.Implementation;
using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace Sender
{
    class StartUp
    {
        public static IServiceProvider ConfigurServices()
        {
            var services = new ServiceCollection()
                .AddSingleton<IConnect, LocalConnection>()
                .AddSingleton<IMessageHandler, SendMessage>()
                .BuildServiceProvider();
            return services;
        }
    }
}
