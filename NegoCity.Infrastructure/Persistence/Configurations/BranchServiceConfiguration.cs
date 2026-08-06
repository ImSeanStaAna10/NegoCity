using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BranchServiceConfiguration : IEntityTypeConfiguration<BranchService>
    {
        public void Configure(EntityTypeBuilder<BranchService> builder)
        {
            builder.ToTable("BranchServices");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsAvailable)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Services)
                .HasForeignKey(x => x.BranchId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Service)
                  .WithMany(x => x.BranchServices)
                  .HasForeignKey(x => x.ServiceId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new
            {
                x.BranchId,
                x.ServiceId
            })
            .IsUnique();
        }
    }
}
