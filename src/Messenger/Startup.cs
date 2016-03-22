using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messenger.Services;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;

namespace Messenger
{
    public class Startup
    {
        public Startup()
        {
            Configuration = new Configuration()
                                    .AddJsonFile("config.json")
                                    .AddEnvironmentVariables();
        }


        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IGreetingService>(
                p => new GreetingService(Configuration));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();


            app.UseMvc();


            //app.UseMvc(routes => routes.MapRoute("default",
            //    "{controller=Home}/{action=Default}"));

            //app.UseIISPlatformHandler();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //app.UseWelcomePage();


        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
