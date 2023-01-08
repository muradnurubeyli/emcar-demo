namespace testServerless.Models
{
    public class AutoSalon : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
