namespace testServerless.Models
{
    public class AuctionFavorite : BaseEntity
    {
        public int AuctionID { get; set; }
        public int UserID { get; set; }

        public virtual Auction Auction { get; set; }
        public virtual User User { get; set; }
    }
}
