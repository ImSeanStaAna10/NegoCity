using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Repositories
{
    public interface IServiceRepository
    {
        Task<Service?> GetByIdAsync(Guid id);
        Task AddAsync(Service service);
    }
}
