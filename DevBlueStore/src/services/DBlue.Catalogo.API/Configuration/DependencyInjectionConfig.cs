using Microsoft.Extensions.DependencyInjection;
using DBlue.Catalogo.API.Data;
using DBlue.Catalogo.API.Data.Repository;
using DBlue.Catalogo.API.Models;

namespace DBlue.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}