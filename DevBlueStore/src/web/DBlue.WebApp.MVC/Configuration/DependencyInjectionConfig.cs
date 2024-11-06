using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DBlue.WebApp.MVC.Extensions;
using DBlue.WebApp.MVC.Services;

namespace DBlue.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}