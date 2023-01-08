namespace testServerless.Models
{
    public class AutoDealer : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
