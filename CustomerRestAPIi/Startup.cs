using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAppBLL;
using CustomerAppBLL.BusinessObjects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CustomerRestAPIi
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
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug();

                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();

                /*var address = facade.AddressService.Create(
                    new AddressBO()
                    {
                        City = "Skagen",
                        Street = "Skagenvej",
                        Number = "1"
                    });

                var address2 = facade.AddressService.Create(
                    new AddressBO()
                    {
                        City = "Esbjerg",
                        Street = "Nygårdsvej",
                        Number = "200"
                    });

                var address3 = facade.AddressService.Create(
                    new AddressBO()
                    {
                        City = "Tjæreborg",
                        Street = "Upsvej",
                        Number = "122a"
                    });*/
            }

            app.UseMvc();
        }
    }
}