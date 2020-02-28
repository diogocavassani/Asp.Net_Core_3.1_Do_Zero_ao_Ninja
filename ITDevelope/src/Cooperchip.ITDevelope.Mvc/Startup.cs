using Cooperchip.ITDeveloper.Data.ORM._Object_Relacional_Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cooperchip.ITDevelope.Mvc
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<ITDeveloperDbContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString("DefaultITDeveloper")));
            services.AddControllersWithViews();
            services.AddRazorPages();
             
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=pagina-inicial}/{id?}");

            });

            //app.UseMvc(routes =>
            //{
            //    //routes.MapRoute(
            //    //    name:"modulos", 
            //    //    template: "Prontuario/ {controller=Home}/{action=Index}/{id?}" );

            //    //routes.MapRoute(
            //    //    name: "pacientes",
            //    //    template: "{controller=Home}/{action=Index}/{id}/{paciente?}");

            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=pagina-inicial}/{id?}");
            //});
        }
    }
}
