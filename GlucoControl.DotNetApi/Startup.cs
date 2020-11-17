using AutoMapper;
using GlucoControl.Application.Configuration;
using GlucoControl.Application.Logic.Configuration;
using GlucoControl.Application.Logic.Services;
using GlucoControl.Application.Services;
using GlucoControl.Domain.Logic.Services;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using Unity;

namespace GlucoControl.DotNetApi
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
            // DbContext
            services.AddDbContext<GlucoControlDbContext>(
                opts => opts.UseMySql(Configuration["ConnectionString:GlucoControlDB"],
                options => options.EnableRetryOnFailure()).EnableDetailedErrors().EnableSensitiveDataLogging()

                );

            services.AddScoped<IApplicationConfig, ApplicationConfig>();

            services.AddScoped<IControlApplication, ControlApplication>();
            services.AddScoped<IControlLogic, ControlLogic>();
            services.AddScoped<IControlRepository, ControlRepository>();

            services.AddScoped<IInsulinApplication, InsulinApplication>();
            services.AddScoped<IInsulinLogic, InsulinLogic>();
            services.AddScoped<IInsulinRepository, InsulinRepository>();

            services.AddScoped<IInsulinTypeApplication, InsulinTypeApplication>();
            services.AddScoped<IInsulinTypeLogic, InsulinTypeLogic>();
            services.AddScoped<IInsulinTypeRepository, InsulinTypeRepository>();

            services.AddScoped<IRoleApplication, RoleApplication>();
            services.AddScoped<IRoleLogic, RoleLogic>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserLogic, UserLogic>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GlucoControl.DotNetApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GlucoControl.DotNetApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //private void RegisterAutoMapper(IUnityContainer container)
        //{
        //    container.RegisterType<IAutomapperProfileApplication, AutomapperProfileApplication>();

        //    var automapperProfilesApplication = container.Resolve<IAutomapperProfileApplication>();

        //    var mapperConfiguration = new MapperConfiguration(configuration =>
        //    {
        //        automapperProfilesApplication.GetProfiles()
        //            .ForEach(profileContainer => configuration.AddProfile(profileContainer.GetProfile()));
        //        configuration.AddProfile(new AutomapperPresentationProfile());
        //    });

        //    container.RegisterInstance<IMapper>(mapperConfiguration.CreateMapper());
        //}
    }
}