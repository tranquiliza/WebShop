﻿using Microsoft.Extensions.DependencyInjection;
using WebShop.Repositories;
using WebShop.Repositories.Interfaces;
using WebShop.Services;
using WebShop.Services.Interfaces;

namespace WebShop
{
    internal static class Dependencies
    {
        internal static void Register(IServiceCollection services)
        {
            //Application Services
            services.AddScoped<IGiftcardProductService, GiftcardProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ILabelService, LabelService>();

            //Repositories
            services.AddScoped<IGiftcardProductRepository, GiftcardProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ILabelRepository, LabelRepository>();
        }
    }
}
