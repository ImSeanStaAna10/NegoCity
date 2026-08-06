using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BranchMediaConfiguration
        : IEntityTypeConfiguration<BranchMedia>
    {
        public void Configure(EntityTypeBuilder<BranchMedia> builder)
        {
            builder.ToTable("BranchMedia");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Media)
                .HasForeignKey(x => x.BranchId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Media)
                .WithMany()
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new
            {
                x.BranchId,
                x.MediaId
            })
            .IsUnique();
        }
    }
}
