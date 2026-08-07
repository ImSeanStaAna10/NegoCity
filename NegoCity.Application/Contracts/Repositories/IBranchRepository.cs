using NegoCity.Domain.Entities;

namespace NegoCity.Application.Contracts.Repositories
{
    public interface IBranchRepository
    {
        Task<Branch?> GetByIdAsync(Guid id);
        Task AddAsync(Branch branch);
    }
}
