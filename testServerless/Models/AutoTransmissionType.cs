namespace testServerless.Models
{
    public class AutoTransmissionType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
