using NegoCity.Application.Contracts.Repositories;
using NegoCity.Application.Contracts.Services;
using NegoCity.Domain.Entities;

namespace NegoCity.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }


        public async Task<Branch?> GetByIdAsync(Guid id)
        {
            return await _branchRepository.GetByIdAsync(id);
        }


        public async Task<Branch> CreateAsync(Branch branch)
        {
            await _branchRepository.AddAsync(branch);
            return branch;
        }
    }
}
