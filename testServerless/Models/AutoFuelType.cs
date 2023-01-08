namespace testServerless.Models
{
    public class AutoFuelType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
