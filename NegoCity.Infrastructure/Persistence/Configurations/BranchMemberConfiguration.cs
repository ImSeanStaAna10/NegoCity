using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NegoCity.Domain.Entities;

namespace NegoCity.Infrastructure.Persistence.Configurations
{
    public class BranchMemberConfiguration : IEntityTypeConfiguration<BranchMember>
    {
        public void Configure(EntityTypeBuilder<BranchMember> builder)
        {
            builder.ToTable("BranchMembers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Role)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.JoinedAt)
                .IsRequired();

            builder.HasOne(x => x.Branch)
                .WithMany(x => x.Members)
                .HasForeignKey(x => x.BranchId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new
            {
                x.BranchId,
                x.UserId
            })
            .IsUnique();
        }
    }

}
