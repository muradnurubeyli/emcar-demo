namespace testServerless.Models
{
    public class AutoStatus : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
