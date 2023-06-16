using Doomlings.Application;

namespace Doomlings.API.ServiceConfigurations
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllers();

            // Swagger/OpenAPI Learn more at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddApplicationLayer(configuration);

            return services;
        }
    }
}
