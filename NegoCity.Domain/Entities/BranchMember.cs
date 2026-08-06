using NegoCity.Domain.Enums;

namespace NegoCity.Domain.Entities
{
    public class BranchMember
    {

        public Guid Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid UserId { get; set; }
        public BranchMemberRole Role { get; set; } = BranchMemberRole.Staff;
        public MembershipStatus Status { get; set; } = MembershipStatus.Pending;

        public DateTime JoinedAt { get; set; }


        //relationship
        public Branch Branch { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}
