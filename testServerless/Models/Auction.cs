namespace testServerless.Models
{
    public class Auction : BaseEntity
    {
        public Auction()
        {
            AuctionBids = new HashSet<AuctionBid>();
            AuctionConnections = new HashSet<AuctionConnection>();
            AuctionFavorites = new HashSet<AuctionFavorite>();
            AuctionPhotos = new HashSet<AuctionPhoto>();
        }

        public int AutoID { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public decimal StartPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<System.DateTime> DateStopped { get; set; }
        public System.DateTime Deadline { get; set; }
        public string CompletionJobID { get; set; }
        public string DeletionJobID { get; set; }
        public int Views { get; set; }
        public decimal PriceUSDSearch { get; set; }
        public decimal PriceUAHSearch { get; set; }
        public int StatusID { get; set; }
        public string SeoFriendlyUrl { get; set; }

        public virtual AuctionStatus AuctionStatus { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Auto Auto { get; set; }

        public virtual ICollection<AuctionBid> AuctionBids { get; set; }
        public virtual ICollection<AuctionConnection> AuctionConnections { get; set; }
        public virtual ICollection<AuctionFavorite> AuctionFavorites { get; set; }
        public virtual ICollection<AuctionPhoto> AuctionPhotos { get; set; }
    }
}
