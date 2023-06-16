using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Doomlings.DataAccess;

namespace Doomlings.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayer(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDataAccessLayer(configuration);

            return services;
        }
    }
}
