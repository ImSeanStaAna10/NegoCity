using Microsoft.EntityFrameworkCore;
using NegoCity.Application.Contracts.Repositories;
using NegoCity.Domain.Entities;
using NegoCity.Infrastructure.Persistence;

namespace NegoCity.Infrastructure.Repositories
{
    public class BusinessRepository : IBusinessRepository
    {
        private readonly ApplicationDbContext _context;

        public BusinessRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region METHODS

        public async Task<Business?> GetByIdAsync(Guid id)
        {
            return await _context.Businesses
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Business business)
        {
            await _context.Businesses.AddAsync(business);
        }

        public async Task<bool> ExistsByNameAsync(string name)
        {
            return await _context.Businesses
                .AnyAsync(x => x.Name == name);
        }

        #endregion
    }
}