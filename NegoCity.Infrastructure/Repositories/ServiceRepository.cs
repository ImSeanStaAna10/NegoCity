using Microsoft.EntityFrameworkCore;
using NegoCity.Application.Contracts.Repositories;
using NegoCity.Domain.Entities;
using NegoCity.Infrastructure.Persistence;

namespace NegoCity.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region METHODS

        public async Task<Service?> GetByIdAsync(Guid id)
        {
            return await _context.Services
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Service service)
        {
            await _context.Services.AddAsync(service);
        }

        #endregion
    }
}