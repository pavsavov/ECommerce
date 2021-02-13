using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ECommerce.Services.Extensions;
using ECommerce.Web.Extensions;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using ECommerce.Web.Models.BookViewModels;
using ECommerce.Services.Models.Book.ServiceModels;
using System.Reflection;
using ECommerce.Services.AutoMapper;
using AutoMapper;

namespace ECommerce.Web
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
            //TODO: move to Extensions project and research on a method to dynamicly load all mappable types.


            services.AddSpaStaticFiles();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //automapper
            AutoMapperConfig.RegisterMappings(
                typeof(BookViewModel).Assembly, 
                typeof(BookServiceModel).Assembly
                );

            services.AddSingleton(typeof(IMapper), AutoMapperConfig.MapperInstance);

            //services.AddRazorPages();
            services.AddMvc();

            //Application custom extensions.
            services.Registrator();

            services.AddECommerceDbContext(this.Configuration);

            services.AddECommerceAuthentication();

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "ClientApp/build";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCors();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "area",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller}/{action}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
