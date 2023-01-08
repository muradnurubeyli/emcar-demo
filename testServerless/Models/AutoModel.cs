namespace testServerless.Models
{
    public class AutoModel : BaseEntity
    {
        public string Name { get; set; }
        public string Name_ru { get; set; }
        public int AutoMakeId { get; set; }

        public virtual AutoMake AutoMake { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
