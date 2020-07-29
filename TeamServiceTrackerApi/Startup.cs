using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TeamServiceTrackerApi.BusinessLayer.Interface;
using TeamServiceTrackerApi.BusinessLayer.Services;
using TeamServiceTrackerApi.BusinessLayer.Services.Repository;
using TeamServiceTrackerApi.DataLayer;
using TeamServiceTrackerApi.DataLayer.Context;

namespace TeamServiceTrackerApi
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
            //services.AddMvcCore().AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            //    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            //});

            services.Configure<MongoDbSetting>(sp =>
            {
                sp.ConnectionString = Configuration.GetSection("TeamTrackerDatabase:ConnectionString").Value;
                sp.Database = Configuration.GetSection("TeamTrackerDatabase:Database").Value;
            });
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMongoDbContext, MongoDbContext>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseHsts();
            }
               

            app.UseHttpsRedirection();



            app.UseMvc(route =>
            {
                route.MapRoute(
                        name: default,
                        template: "{controller}/{action=Index}/{id?}");  
            });
        }
    }
}
