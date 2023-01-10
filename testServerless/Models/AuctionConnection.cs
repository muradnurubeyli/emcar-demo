namespace testServerless.Models
{
    public class AuctionConnection : BaseEntity
    {
        public int AuctionID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Connection { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Auction Auction { get; set; }
        public virtual User User { get; set; }
    }
}
