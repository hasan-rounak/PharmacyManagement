
namespace PharmacyManagement.API.Configuration
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    public static class CorsConfig
    {
        private const string CorsPolicyName = "PharmacyManagementCorsPolicy";
        public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
        {
            return services.AddCors
            (
                options => options.AddPolicy
                (
                    CorsPolicyName,
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                )
            );
        }

        public static IApplicationBuilder UseCorsPolicy(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseCors(CorsPolicyName);
        }
    }
}
