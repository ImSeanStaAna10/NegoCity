using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Services
{
    public interface IFranchiseRequestService
    {
        Task<FranchiseRequest?> GetByIdAsync(Guid id);
        Task<FranchiseRequest> CreateAsync(FranchiseRequest franchiseRequest);
    }
}