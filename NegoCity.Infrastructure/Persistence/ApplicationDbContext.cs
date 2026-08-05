using Microsoft.EntityFrameworkCore;

namespace NegoCity.Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
        {
            
        }

        

    }
}
