namespace testServerless.Models
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
