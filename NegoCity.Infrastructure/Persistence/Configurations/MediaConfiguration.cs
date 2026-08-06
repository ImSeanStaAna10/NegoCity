using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("Media");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Url)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.FileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.ContentType)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.FileSize)
                .IsRequired();

            builder.Property(x => x.DisplayOrder)
                .IsRequired();

            builder.Property(x => x.IsPrimary)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            // Uploaded by user
            builder.HasOne(x => x.UploadedByUser)
                .WithMany()
                .HasForeignKey(x => x.UploadedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
