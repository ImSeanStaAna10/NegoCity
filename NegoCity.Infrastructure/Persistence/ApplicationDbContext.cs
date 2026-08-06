using Microsoft.EntityFrameworkCore;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region EF Core DbSets
        public DbSet<User> Users => Set<User>();
        public DbSet<Business> Businesses => Set<Business>();
        public DbSet<BusinessMember> BusinessMembers => Set<BusinessMember>();
        public DbSet<Branch> Branches => Set<Branch>();
        public DbSet<BranchMember> BranchMembers => Set<BranchMember>();

        public DbSet<Service> Services => Set<Service>();
        public DbSet<ServiceVariant> ServiceVariants => Set<ServiceVariant>();
        public DbSet<BranchService> BranchServices => Set<BranchService>();
        public DbSet<BranchServiceVariant> BranchServiceVariants =>
            Set<BranchServiceVariant>();

        public DbSet<Media> Media => Set<Media>();
        public DbSet<BusinessMedia> BusinessMedia => Set<BusinessMedia>();
        public DbSet<BranchMedia> BranchMedia => Set<BranchMedia>();
        public DbSet<ServiceMedia> ServiceMedia => Set<ServiceMedia>();

        public DbSet<FranchiseRequest> FranchiseRequests =>
            Set<FranchiseRequest>();

        public DbSet<Booking> Bookings => Set<Booking>();

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationDbContext).Assembly);
        }
    }
}