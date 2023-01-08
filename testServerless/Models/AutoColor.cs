namespace testServerless.Models
{
    public class AutoColor : BaseEntity
    {
        public string Name { get; set; }
        public string Hex { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
