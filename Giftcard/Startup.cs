using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giftcard.Repositories;
using Giftcard.Repositories.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Giftcard
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Giftcard API", Version = "v1" });
            });

            services.AddMvc();
         
            RegisterDependencies(services);
        }

        private void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IGiftcardItemRepository, GiftcardItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Giftcard API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc();
        }
    }
}
