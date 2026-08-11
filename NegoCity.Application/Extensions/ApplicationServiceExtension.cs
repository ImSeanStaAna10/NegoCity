using FluentValidation;
using NegoCity.Application.Contracts.Services;
using NegoCity.Application.Services;
using NegoCity.Application.Validators.Business;


namespace NegoCity.Application.Extensions
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           
            services.AddValidatorsFromAssemblyContaining<CreateBusinessRequestValidator>();
            // Existing application services/repositories registrations
            // stay here.

            services.AddScoped<IBusinessService, BusinessService>();

            return services;
        }

    }
}
