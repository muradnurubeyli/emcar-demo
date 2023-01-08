namespace testServerless.Models
{
    public class AutoTSRegistration : BaseEntity
    {
        public string Name { get; set; }
        public string NameFull { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
