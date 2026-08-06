using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BusinessMediaConfiguration
          : IEntityTypeConfiguration<BusinessMedia>
    {
        public void Configure(EntityTypeBuilder<BusinessMedia> builder)
        {
            builder.ToTable("BusinessMedia");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Business)
                .WithMany(x => x.Media)
                .HasForeignKey(x => x.BusinessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Media)
                .WithMany()
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new
            {
                x.BusinessId,
                x.MediaId
            })
            .IsUnique();
        }
    }
}
