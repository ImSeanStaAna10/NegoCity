using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Services
{
    public interface IServiceService
    {
        Task<Service?> GetByIdAsync(Guid id);
        Task<Service> CreateAsync(Service service);
    }
}