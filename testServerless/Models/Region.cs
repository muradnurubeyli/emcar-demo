namespace testServerless.Models
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }
        public string Name_seo { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}