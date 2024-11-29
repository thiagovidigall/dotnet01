using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DBlue.Core.Utils;
using DBlue.MessageBus;
using DBlue.Pagamentos.API.Services;

namespace DBlue.Pagamentos.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<PagamentoIntegrationHandler>();
        }
    }
}