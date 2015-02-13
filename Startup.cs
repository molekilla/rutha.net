using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
// using Microsoft.AspNet.Diagnostics.Entity;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Security.Cookies;
//using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;
using Rutha.Models;

namespace Rutha.Mvc
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }
                                              
        public Startup() 
        {
            Configuration = Rutha.Shared.ConfigManager.Create();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddMvc();
          // services.AddSingleton<ITodoRepository, TodoRepository>();
          services.AddSingleton<IUserRepository, UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerfactory)
        {
            loggerfactory.AddConsole();
            // Add the following to the request pipeline only in development environment.
            if (string.Equals(Configuration.Get("ASPNET_ENV"), "Development", StringComparison.OrdinalIgnoreCase))
            {
                app.UseErrorPage(ErrorPageOptions.ShowAll);
                // app.UseDatabaseErrorPage(DatabaseErrorPageOptions.ShowAll);
            }
            else
            {
                // Add Error handling middleware which catches all application specific errors and
                // send the request to the following path or controller action.
                app.UseErrorHandler("/home/error");
            }
            
            // Add cookie-based authentication to the request pipeline.
            //app.UseIdentity();
            
            app.UseMvc();
            app.UseStaticFiles();
            app.UseWelcomePage();
        }
    }
}