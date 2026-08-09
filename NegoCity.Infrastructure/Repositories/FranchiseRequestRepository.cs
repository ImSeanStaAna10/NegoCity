using Microsoft.EntityFrameworkCore;
using NegoCity.Application.Contracts.Repositories;
using NegoCity.Domain.Entities;
using NegoCity.Infrastructure.Persistence;

namespace NegoCity.Infrastructure.Repositories
{
    public class FranchiseRequestRepository : IFranchiseRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public FranchiseRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region METHODS

        public async Task<FranchiseRequest?> GetByIdAsync(Guid id)
        {
            return await _context.FranchiseRequests
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(FranchiseRequest franchiseRequest)
        {
            await _context.FranchiseRequests.AddAsync(franchiseRequest);
        }

        #endregion
    }
}