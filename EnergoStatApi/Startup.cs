namespace EnergoStatApi
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;
    using EnergoStatApi.DataAccess;
    using EnergoStatApi.DataAccess.Interfaces;
    using EnergoStatApi.DataAccess.Repositories;
    using EnergoStatApi.DataAccess.Entity;
    using EnergoStatApi.Domain.Service;
    using EnergoStatApi.Domain.Interfaces;

    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DB:NpgSql");

            services.AddDbContext<ApplicationContext>(services =>
                                services.UseNpgsql(connectionString));

            services.AddScoped<IBaseRepository<ElectricRate>, ElectricRateRepository>();
            //services.AddScoped<IBaseRepository<ColdWhaterRate>, ElectricRateRepository>();
            //services.AddScoped<IBaseRepository<WarmWhaterRate>, ElectricRateRepository>();
            services.AddScoped<IRateGraphService, RateGraphService>();

            services.AddControllers();

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.RoutePrefix = String.Empty;
                config.SwaggerEndpoint("swagger/v1/swagger.json", "Notes API");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
