namespace NegoCity.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public Guid BranchId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid? ServiceVariantId { get; set; }
        public DateTime ScheduledAt { get; set; }

        public int DurationMinutes { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? CustomerNotes { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Relationships
        public User Customer { get; set; } = null!;
        public Business Business { get; set; } = null!;
        public Branch Branch { get; set; } = null!;
        public Service Service { get; set; } = null!;
        public ServiceVariant? ServiceVariant { get; set; }

    }
}
