using NegoCity.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NegoCity.Infrastructure.Extensions
{
    public static class InfrastructureServiceExtensions 
    {
        // CONSTANTS
        const string DEFAULT_CONNECTION_STRING_NAME = "DefaultConnection";
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(DEFAULT_CONNECTION_STRING_NAME));
            });


            return services;

        }
    }
}
