namespace NegoCity.Domain.Entities
{
    public class ServiceVariant
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relationships
        public Service Service { get; set; } = null!;
        public ICollection<BranchServiceVariant> BranchServiceVariants { get; set; } =
            new List<BranchServiceVariant>();
    }
}
