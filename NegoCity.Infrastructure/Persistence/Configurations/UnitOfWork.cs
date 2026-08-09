using NegoCity.Application.Contracts.Repositories;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }   



    }
}
