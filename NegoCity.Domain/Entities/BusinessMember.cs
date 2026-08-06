namespace NegoCity.Domain.Entities
{
    public class BusinessMember
    {
        public Guid Id { get; set; }
        public Guid BusinessId { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; }

        //relationship
        public Business Business { get; set; } = null!;

        public User User { get; set; } = null!;

    }
}
