

namespace PharmacyManagement.API
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using API.Configuration;
    using Core.Model;
    using MediatR;
    using Core.Interface;
    using Data.Repository;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMedicineRepository, MedicineRepository>();

            services.AddSwaggerDoc()
                    .AddMediatR(typeof(Medicine).Assembly)
                    .AddAutomapperConfiguration()
                    .AddCorsPolicy()
                    .AddValidator()
                    .AddHealthChecks();
            
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            app.UseHttpsRedirection()
               .UseRouting()
               .UseCorsPolicy()
               .UseAuthorization()
               .UseEndpoints
               (
                   endpoints => { endpoints.MapControllers(); }
               )
               .UseHealthChecks("/health")
               .UseSwaggerDoc();
        }
    }
}
