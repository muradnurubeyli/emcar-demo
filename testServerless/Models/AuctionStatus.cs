namespace testServerless.Models
{
    public class AuctionStatus : BaseEntity
    {
        public AuctionStatus()
        {
            this.Auctions = new HashSet<Auction>();
        }

        public string Name { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
    }
}