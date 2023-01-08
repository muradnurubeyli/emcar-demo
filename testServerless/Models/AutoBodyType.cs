namespace testServerless.Models
{
    public class AutoBodyType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
