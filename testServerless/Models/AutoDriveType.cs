namespace testServerless.Models
{
    public class AutoDriveType : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
