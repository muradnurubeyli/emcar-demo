namespace testServerless.Models
{
    public class AutoMake : BaseEntity
    {
        public string Name { get; set; }
        public string Name_ru { get; set; }
        public Nullable<int> AutoTransportTypeId { get; set; }
        public string Name_seo { get; set; }

        public virtual AutoTransportType AutoTransportType { get; set; }
        public virtual ICollection<AutoModel> AutoModels { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
