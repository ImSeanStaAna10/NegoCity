using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BusinessMemberConfiguration : IEntityTypeConfiguration<BusinessMember> 
    {
        public void Configure(EntityTypeBuilder<BusinessMember> builder)
        {

            builder.ToTable("BusinessMember");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Role)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.JoinedAt)
                .IsRequired();

            builder.HasOne(x => x.Business)
                .WithMany(x => x.Members)
                .HasForeignKey(x => x.BusinessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new
            {
                x.BusinessId,
                x.UserId
            })
            .IsUnique();

        }

    }
}
