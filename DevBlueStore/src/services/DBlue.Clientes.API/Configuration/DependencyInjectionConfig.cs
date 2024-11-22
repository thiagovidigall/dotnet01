using Microsoft.Extensions.DependencyInjection;
using DBlue.Clientes.API.Data;
using DBlue.Clientes.API.Data.Repository;
using DBlue.Clientes.API.Models;
using DBlue.Core.Mediator;
using MediatR;
using DBlue.Clientes.API.Application.Commands;
using FluentValidation.Results;
using DBlue.Clientes.API.Application.Events;
using DBlue.Clientes.API.Services;

namespace DBlue.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();

            // vai ser responsabilidade da abstração "MessageBusConfig"
            //services.AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}