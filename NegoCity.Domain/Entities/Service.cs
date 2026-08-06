namespace NegoCity.Domain.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        //Relatioship
        public Business Business { get; set; } = null!;

        public ICollection<ServiceMedia> Media { get; set; } =
    new List<ServiceMedia>();

        public ICollection<ServiceVariant> Variants { get; set; } =
            new List<ServiceVariant>();

        public ICollection<BranchService> BranchServices { get; set; } =
            new List<BranchService>();

        

    }
}
