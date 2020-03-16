using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeExchange.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BikeExchange
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
            services.AddControllersWithViews();

            // HH: Add the BikeDbContext and specify its ConnectionString 
            services.AddDbContext<BikeDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BikeDbConnection")));

            // HH: for identity
            //services.AddDefaultIdentity<IdentityUser>()
            //        .AddEntityFrameworkStores<BikeDbContext>();

            // HH: for enhancing Identity
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<BikeDbContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();

            services.AddMvc();  // HH: for identity
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
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // HH: for idenity
                endpoints.MapControllers();
                endpoints.MapRazorPages();

                //endpoints.MapControllerRoute(
                //    name: "byYearMoth",
                //    pattern: "make/bikes/{year:int:length(4)}/{month:int:range(1,12)}",
                //    defaults: new { controller = "make", action = "ByYearMonth" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
