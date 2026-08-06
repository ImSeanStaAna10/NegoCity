namespace NegoCity.Domain.Entities
{
    public class BranchMedia
    {
        public Guid Id { get; set; }

        public Guid BranchId { get; set; }
        public Guid MediaId { get; set; }

        // Relationships
        public Branch Branch { get; set; } = null!;
        public Media Media { get; set; } = null!;
    }
}
