namespace NegoCity.Domain.Entities
{
    public class Business
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

        //relationship
        public ICollection<BusinessMember> Members { get; set; } = new List<BusinessMember>();
        public ICollection<Branch> Branches { get; set; } =
    new List<Branch>();

        public ICollection<BusinessMedia> Media { get; set; } =
    new List<BusinessMedia>();

        public ICollection<Service> Services { get; set; } =
    new List<Service>();
    }




}
