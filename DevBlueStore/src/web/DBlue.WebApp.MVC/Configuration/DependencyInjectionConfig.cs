using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DBlue.WebApp.MVC.Extensions;
using DBlue.WebApp.MVC.Services;
using DBlue.WebApp.MVC.Services.Handlers;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace DBlue.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IValidationAttributeAdapterProvider, CpfValidationAttributeAdapterProvider>();

            services.AddTransient<HttpClientAuthorizationDelegatingHandler>();
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddHttpClient<ICatalogoService, CatalogoService>()
                .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>();

            //services.AddHttpClient("Refif", options =>
            //    {
            //        options.BaseAddress = new System.Uri(configuration.GetSection("CatalogoUrl").Value);
            //    })
            //    .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>()
            //    .AddTypedClient(Refit.RestService.For<ICatalogoServiceRefit>);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}