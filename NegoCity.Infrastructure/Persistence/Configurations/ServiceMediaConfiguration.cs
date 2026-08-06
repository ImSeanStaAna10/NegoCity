using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{

    public class ServiceMediaConfiguration
        : IEntityTypeConfiguration<ServiceMedia>
    {
        public void Configure(EntityTypeBuilder<ServiceMedia> builder)
        {
            builder.ToTable("ServiceMedia");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Service)
                .WithMany(x => x.Media)
                .HasForeignKey(x => x.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Media)
                .WithMany()
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new
            {
                x.ServiceId,
                x.MediaId
            })
            .IsUnique();
        }
    }
}
