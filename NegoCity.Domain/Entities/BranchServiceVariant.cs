namespace NegoCity.Domain.Entities
{
    public class BranchServiceVariant
    {
        public Guid Id { get; set; }
        public Guid BranchServiceId { get; set; }
        public Guid ServiceVariantId { get; set; }
        public decimal? PriceOverride { get; set; }
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relationships
        public BranchService BranchService { get; set; } = null!;
        public ServiceVariant ServiceVariant { get; set; } = null!;

    }
}
