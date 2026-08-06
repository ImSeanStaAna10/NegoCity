namespace NegoCity.Domain.Entities
{
    public class ServiceMedia
    {
        public Guid Id { get; set; }

        public Guid ServiceId { get; set; }

        public Guid MediaId { get; set; }

        // Relationships
        public Service Service { get; set; } = null!;

        public Media Media { get; set; } = null!;
    }
}