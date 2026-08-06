using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BranchServiceVariantConfiguration
    : IEntityTypeConfiguration<BranchServiceVariant>
    {
        public void Configure(EntityTypeBuilder<BranchServiceVariant> builder)
        {
            builder.ToTable("BranchServiceVariants");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PriceOverride)
                .HasPrecision(18, 2)
                .IsRequired(false);

            builder.Property(x => x.IsAvailable)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            builder.HasOne(x => x.BranchService)
                .WithMany(x => x.Variants)
                .HasForeignKey(x => x.BranchServiceId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.ServiceVariant)
                .WithMany(x => x.BranchServiceVariants)
                .HasForeignKey(x => x.ServiceVariantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new
            {
                x.BranchServiceId,
                x.ServiceVariantId
            })
            .IsUnique();
        }
    }
}
