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
using Microsoft.AspNetCore.Http;
using DBlue.WebAPI.Core.Usuario;

namespace DBlue.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IMediatorHandler, MediatorHandler>();

            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<AdicionarEnderecoCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}