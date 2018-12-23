using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SWAPI.Application.Services;
using SWAPI.Domain.Interfaces.Service;
using SWAPI.Domain.Services;
using SWAPI.Infra.Cross.IoC;

namespace SWAPI
{
    public class Startup
    {
        private Container container = new Container();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Default lifestyle scoped + async
            // The recommendation is to use AsyncScopedLifestyle in for applications that solely consist of a Web API(or other asynchronous technologies such as ASP.NET Core)
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register services
            BootSrapper.RegisterServices(container);

            //Application Layer

            //container.Register<IPeopleAppService, PeopleAppService>(Lifestyle.Scoped);

            //Services Layer
            //container.Register<IPeopleService, PeopleService>(Lifestyle.Scoped);


            //container.Register<IHelloWorldService, HelloWorldService>(Lifestyle.Scoped); // lifestyle can set here, sometimes you want to change the default lifestyle like singleton exeptionally

            // Register controllers DI resolution
            //services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));

            // Wrap AspNet requests into Simpleinjector's scoped lifestyle
            services.UseSimpleInjectorAspNetRequestScoping(container);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            //container.Bootstrapper(app);

            // Verify Simple Injector configuration
            container.Verify();
        }
    }
}
