using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Services
{
    public interface IBusinessService
    {
        Task<Business?> GetByIdAsync(Guid id);
        Task<Business> CreateAsync(Business business);
    }
}
