using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ScheduledAt)
                .IsRequired();

            builder.Property(x => x.DurationMinutes)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.CustomerNotes)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            // Customer
            builder.HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Business
            builder.HasOne(x => x.Business)
                .WithMany()
                .HasForeignKey(x => x.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);

            // Branch
            builder.HasOne(x => x.Branch)
                .WithMany()
                .HasForeignKey(x => x.BranchId)
                .OnDelete(DeleteBehavior.Restrict);

            // Service
            builder.HasOne(x => x.Service)
                .WithMany()
                .HasForeignKey(x => x.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Optional Service Variant
            builder.HasOne(x => x.ServiceVariant)
                .WithMany()
                .HasForeignKey(x => x.ServiceVariantId)
                .OnDelete(DeleteBehavior.Restrict);

            // Useful for business/branch booking queries
            builder.HasIndex(x => new
            {
                x.BusinessId,
                x.BranchId,
                x.ScheduledAt
            });

            // Useful for customer booking history
            builder.HasIndex(x => new
            {
                x.CustomerId,
                x.ScheduledAt
            });
        }
    }
}
