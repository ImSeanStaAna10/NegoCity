using NegoCity.Application.DTOs.Business;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Services
{
    public interface IBusinessService
    {
        Task<BusinessResponse?> GetByIdAsync(Guid id);
        Task<BusinessResponse> CreateAsync(CreateBusinessRequest request);
    }
}
