namespace testServerless.Models
{
    public class AuctionBid : BaseEntity
    {
        public int AuctionID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int Amount { get; set; }

        public virtual Auction Auction { get; set; }
        public virtual User User { get; set; }
    }
}
