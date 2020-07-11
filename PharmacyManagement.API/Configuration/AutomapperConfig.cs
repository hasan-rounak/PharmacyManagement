namespace PharmacyManagement.API.Configuration
{
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using Core.Mapper;
    public static class AutomapperConfig
    {
        public static IServiceCollection AddAutomapperConfiguration(this IServiceCollection services)
        {
            MapperConfiguration mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
