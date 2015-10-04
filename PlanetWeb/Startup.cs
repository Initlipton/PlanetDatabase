using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Runtime;
using PlanetWeb.Services;

namespace PlanetWeb
{
    public class Startup
    {
        IConfiguration config;

        public Startup(IApplicationEnvironment env)
        {
            var builder = new ConfigurationBuilder(env.ApplicationBasePath)
               .AddJsonFile("config.json");

            config = builder.Build();
        }

        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPlanetService, PlanetService>();

            services.AddInstance(new Config
            {
                ApiEndpoint = config.Get("api"),
                Url = config.Get("url")
            });  

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
