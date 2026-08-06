using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(2000);

            builder.Property(x => x.AddressLine)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Province)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.PostalCode)
                .HasMaxLength(20);

            builder.Property(x => x.Latitude)
                .HasPrecision(9, 6);

            builder.Property(x => x.Longitude)
                .HasPrecision(9, 6);

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            builder.HasOne(x => x.Business)
                .WithMany(x => x.Branches)
                .HasForeignKey(x => x.BusinessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new
            {
                x.BusinessId,
                x.Name
            })
            .IsUnique();
        }


    }
}
