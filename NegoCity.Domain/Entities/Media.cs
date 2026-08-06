namespace NegoCity.Domain.Entities
{
    public class Media
    {
        public Guid Id { get; set; }

        public Guid UploadedByUserId { get; set; }

        public string Url { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string ContentType { get; set; } = string.Empty;

        public long FileSize { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPrimary { get; set; }

        public DateTime CreatedAt { get; set; }

        // Relationship
        public User UploadedByUser { get; set; } = null!;
    }
}