using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DBlue.Pagamentos.API.Data;
using DBlue.Pagamentos.API.Data.Repository;
using DBlue.Pagamentos.API.Models;
using DBlue.Pagamentos.API.Services;
using DBlue.Pagamentos.CardAntiCorruption;
using DBlue.Pagamentos.Facade;
using DBlue.WebAPI.Core.Usuario;

namespace DBlue.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}