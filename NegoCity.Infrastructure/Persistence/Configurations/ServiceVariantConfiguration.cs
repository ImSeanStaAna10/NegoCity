using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class ServiceVariantConfiguration
         : IEntityTypeConfiguration<ServiceVariant>
    {
        public void Configure(EntityTypeBuilder<ServiceVariant> builder)
        {
            builder.ToTable("ServiceVariants");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            builder.HasOne(x => x.Service)
                .WithMany(x => x.Variants)
                .HasForeignKey(x => x.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
