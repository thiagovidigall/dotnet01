using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DBlue.Core.Utils;
using DBlue.MessageBus;

namespace DBlue.Pedidos.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"));
        }
    }
}