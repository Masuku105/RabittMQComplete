using Microsoft.Extensions.DependencyInjection;
using Reciever.Implementation;
using Reciever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace Reciever
{
    public class StartUp
    {
        public static IServiceProvider ConfigurServices()
        {
            var services = new ServiceCollection()
                .AddSingleton<IConnect, LocalConnection>()
                .AddSingleton<IMessageHandler, MessageReciever>()
                .BuildServiceProvider();
            return services;
        }
    }
}
