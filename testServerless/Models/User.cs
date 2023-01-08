namespace testServerless.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
