using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DBlue.Carrinho.API.Services;
using DBlue.Core.Utils;
using DBlue.MessageBus;

namespace DBlue.Carrinho.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<CarrinhoIntegrationHandler>();
        }
    }
}