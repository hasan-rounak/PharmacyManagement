namespace PharmacyManagement.API.Configuration
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddSwaggerGen
            (
                options =>
                {
                    options.DescribeAllParametersInCamelCase();
                    options.SwaggerDoc
                    (
                        "v1", new OpenApiInfo
                        {
                            Version = "v1",
                            Title = "Pharmacy Management Service API",
                            Description = "A service to manage Medicine inventory data of a pharmacy",
                            Contact = new OpenApiContact
                            {
                                Name = "ABC Pharmacy"
                            }
                        }
                    );

                }
            );

            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI
            (
                options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Pharmacy Management API v1");
                    options.RoutePrefix = string.Empty;
                }
            );

            return app;
        }
    }
}
