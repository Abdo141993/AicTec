using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dal;
using ZKTeco.Interface;
using ZKTeco.Interface.Implementation;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace WebApplication1
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
            #region Session Configuration
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(180);//You can set Time   
            });
            services.AddMvc();
            #endregion

            #region Specify DB Connection Context
            services.AddDbContext<ZKTecoDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("AictecDbConnection")));
            #endregion

            #region Add Injection Scops
            //services.AddSingleton<ZKTecoDbContext>();
            services.AddScoped<UserDal>();
            services.AddScoped<CheckUserSession>();
            services.AddScoped<Mapping>();
            services.AddSingleton<IFileServices, FilesManager>();
            services.AddScoped<IDashboardRepo, DashboardDetail>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            services.AddControllersWithViews();
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

            app.UseRouting();

            app.UseAuthorization();

            #region Session Configuration
            app.UseSession();
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
