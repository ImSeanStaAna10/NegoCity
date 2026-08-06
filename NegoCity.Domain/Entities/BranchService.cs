namespace NegoCity.Domain.Entities
{
    public class BranchService
    {
        public Guid Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid ServiceId { get; set; }
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relationships
        public Branch Branch { get; set; } = null!;
        public Service Service { get; set; } = null!;

        public ICollection<BranchServiceVariant> Variants { get; set; } =
            new List<BranchServiceVariant>();

       

    }
}
