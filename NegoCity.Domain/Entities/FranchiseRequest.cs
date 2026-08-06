using NegoCity.Domain.Enums;

namespace NegoCity.Domain.Entities
{
    public class FranchiseRequest
    {
        public Guid Id { get; set; }

        public Guid BusinessId { get; set; }

        public Guid RequestedByUserId { get; set; }

        public string ProposedBranchName { get; set; } = string.Empty;

        public string ProposedAddressLine { get; set; } = string.Empty;

        public string ProposedCity { get; set; } = string.Empty;

        public string ProposedProvince { get; set; } = string.Empty;

        public string? Message { get; set; }

        public FranchiseRequestStatus Status { get; set; }

        public Guid? ReviewedByUserId { get; set; }

        public DateTime? ReviewedAt { get; set; }

        public string? ReviewNotes { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Relationships
        public Business Business { get; set; } = null!;

        public User RequestedByUser { get; set; } = null!;

        public User? ReviewedByUser { get; set; }
    }
}
