using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NegoCity.Application.Contracts.Repositories;
using NegoCity.Infrastructure.Persistence;
using NegoCity.Infrastructure.Persistence.Configurations;
using NegoCity.Infrastructure.Repositories;

namespace NegoCity.Infrastructure.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        // CONSTANTS
        private const string DEFAULT_CONNECTION_STRING_NAME = "DefaultConnection";

        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString(
                        DEFAULT_CONNECTION_STRING_NAME));
            });

            // REPOSITORY REGISTRATION
            services.AddScoped<IBusinessRepository, BusinessRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IFranchiseRequestRepository, FranchiseRequestRepository>();

            // UNIT OF WORK
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}