﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RepositoryPattern;
using Setting;

namespace WebAdmin
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
            services.Configure<SiteConfig>(Configuration.GetSection("SiteConfig"));

            services.AddScoped<IOnDatabaseConfiguring, EntityFrameWorkConfigure>();

            services.UseYhcdSetting(Configuration);
            services.UseAdminSetting(Configuration);

            services.AddSession();
            services.AddMvc()
                .AddJsonOptions(option => { option.SerializerSettings.DateFormatString = "yyyy-MM-dd"; }); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
