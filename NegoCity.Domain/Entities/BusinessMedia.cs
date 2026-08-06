namespace NegoCity.Domain.Entities
{
    public class BusinessMedia
    {
        public Guid Id { get; set; }

        public Guid BusinessId { get; set; }
        public Guid MediaId { get; set; }

        // Relationships
        public Business Business { get; set; } = null!;
        public Media Media { get; set; } = null!;
    }
}






