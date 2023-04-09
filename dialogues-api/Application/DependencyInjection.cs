using Application.Services;
using AutoMapper;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuración AutoMapper
            var autoMapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddMaps(typeof(IMapperService).Assembly);
            });
            IMapper mapper = autoMapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Inyección de dependencias de servicios personalizados
            services.AddScoped<IMapperService, MapperService>();
            services.AddScoped<IGetAllCategoriesService, GetAllCategoriesService>();
            services.AddScoped<IGetTopicsService, GetTopicsService>();
            

            return services;
        }
    }
}