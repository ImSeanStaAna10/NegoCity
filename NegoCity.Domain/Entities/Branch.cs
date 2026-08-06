namespace NegoCity.Domain.Entities
{
    public class Branch
    {
        public Guid Id { get; set; }

        public Guid BusinessId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string AddressLine { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relationships
        public Business Business { get; set; } = null!;

        public ICollection<BranchMember> Members { get; set; } =
            new List<BranchMember>();

        public ICollection<BranchMedia> Media { get; set; } =
    new List<BranchMedia>();

        public ICollection<BranchService> Services { get; set; } =
    new List<BranchService>();
    }
}