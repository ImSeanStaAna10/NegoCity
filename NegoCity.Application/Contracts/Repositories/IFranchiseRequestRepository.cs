using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Repositories
{
    public interface IFranchiseRequestRepository
    {
        Task<FranchiseRequest?> GetByIdAsync(Guid id);
        Task AddAsync(FranchiseRequest franchiseRequest);
    }
}
