using Microsoft.EntityFrameworkCore;
using NegoCity.Application.Contracts.Repositories;
using NegoCity.Domain.Entities;
using NegoCity.Infrastructure.Persistence;

namespace NegoCity.Infrastructure.Repositories
{
    public class BranchRepository : IBranchRepository
    {

        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context)
        {
                _context = context;
        }

        public async Task<Branch?> GetByIdAsync(Guid id)
        {
            return await _context.Branches
                .FirstOrDefaultAsync(x => x.Id == id);
        }    


        public async Task AddAsync(Branch branch)
        {
            await _context.Branches.AddAsync(branch);
        }



    }
}
