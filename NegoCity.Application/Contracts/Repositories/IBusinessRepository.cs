using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Repositories
{
    public interface IBusinessRepository
    {
        Task<Business?> GetByIdAsync(Guid id);
        Task AddAsync(Business business);
    }
}
