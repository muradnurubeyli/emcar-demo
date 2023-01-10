namespace testServerless.Models
{
    public class AuctionPhoto : BaseEntity
    {
        public int AuctionID { get; set; }
        public bool IsMain { get; set; }
        public string uuid { get; set; }

        public virtual Auction Auction { get; set; }
    }
}
