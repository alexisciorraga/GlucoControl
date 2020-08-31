using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using AutoMapper;
using GlucoControl.Application.Logic.Services;
using GlucoControl.Application.Services;
using GlucoControl.Domain.Logic.Services;
using GlucoControl.Domain.Services;
using GlucoControl.Repository;
using Microsoft.Extensions.Hosting;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Repositories;
using GlucoControl.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace GlucoControl.NetCoreApi
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
            services.AddControllers();


            services.AddDbContext<GlucoControlDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:GlucoControlDb"]));


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

            services.AddAutoMapper(typeof(Startup));

            services.AddMvc()
                .AddControllersAsServices();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
