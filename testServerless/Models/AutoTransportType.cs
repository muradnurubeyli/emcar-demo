namespace testServerless.Models
{
    public class AutoTransportType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<AutoBodyType> AutoBodyTypes { get; set; }
        public virtual ICollection<AutoMake> AutoMakes { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
