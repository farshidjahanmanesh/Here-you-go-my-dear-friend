using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using RouteConfigurations.contracts;
using RouteConfigurations.Models;
namespace TestProject
{

    public class Profile : IProfileRouteMapper
    {
        public MapperSetting Routes(MapperSetting settings)
        {
            return settings.AddRoute(
                new RouteMapBuilder("default", "/")
                .SetDefault(new { controller = "home", action = "index" }))

               .AddRoute(new RouteMapBuilder("testMethod", "/test")
               .SetDefault(new { controller = "home", action = "test" }));
        }
    }


    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSingleton<IProfileRouteMapper, Profile>();
            services.Configure<Profile>(c => { });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
            , IOptions<Profile> configure)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapperEndPoint(configure.Value);
            });
        }
    }


}
