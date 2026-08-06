using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class FranchiseRequestConfiguration
      : IEntityTypeConfiguration<FranchiseRequest>
    {
        public void Configure(EntityTypeBuilder<FranchiseRequest> builder)
        {
            builder.ToTable("FranchiseRequest");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProposedBranchName)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.ProposedAddressLine)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.ProposedCity)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ProposedProvince)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Message)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.ReviewNotes)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            // Main business receiving the request
            builder.HasOne(x => x.Business)
                .WithMany()
                .HasForeignKey(x => x.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);

            // User who submitted the request
            builder.HasOne(x => x.RequestedByUser)
                .WithMany()
                .HasForeignKey(x => x.RequestedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // User who reviewed the request
            builder.HasOne(x => x.ReviewedByUser)
                .WithMany()
                .HasForeignKey(x => x.ReviewedByUserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasIndex(x => new
            {
                x.BusinessId,
                x.Status
            }
            );
        }
    }
}
