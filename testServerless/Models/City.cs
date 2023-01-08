namespace testServerless.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string Name_seo { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
