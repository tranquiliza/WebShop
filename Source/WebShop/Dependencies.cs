using Microsoft.Extensions.DependencyInjection;
using WebShop.Repositories;
using WebShop.Repositories.Abstractions;
using WebShop.Services;
using WebShop.Services.Abstractions;

namespace WebShop
{
    internal static class Dependencies
    {
        internal static void Register(IServiceCollection services)
        {
            //Application Services
            services.AddScoped<IGiftcardProductService, GiftcardProductService>();
            services.AddScoped<IOrderService, OrderService>();

            //Repositories
            services.AddScoped<IGiftcardProductRepository, GiftcardProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
