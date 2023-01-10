namespace testServerless.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            this.AuctionBids = new HashSet<AuctionBid>();
            this.AuctionConnections = new HashSet<AuctionConnection>();
            this.AuctionFavorites = new HashSet<AuctionFavorite>();
            //this.AutoBuyBacks = new HashSet<AutoBuyBack>();
            //this.AutoFavorites = new HashSet<AutoFavorite>();
            //this.AutoReviews = new HashSet<AutoReview>();
            //this.ContactsRequests = new HashSet<ContactsRequest>();
            //this.Orders = new HashSet<Order>();
            //this.Transactions = new HashSet<Transaction>();
            //this.UserConnections = new HashSet<UserConnection>();
            //this.UserPhoneNumbers = new HashSet<UserPhoneNumber>();
            //this.Roles = new HashSet<Role>();
            //this.Autoes = new HashSet<Auto>();
            //this.AutoDealers = new HashSet<AutoDealer>();
            //this.AutoPriceOffers = new HashSet<AutoPriceOffer>();
            //this.BuyRequests = new HashSet<BuyRequest>();
            //this.AutoSalons = new HashSet<AutoSalon>();
        }

        public string Name { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
        public virtual ICollection<AuctionBid> AuctionBids { get; set; }
        public virtual ICollection<AuctionConnection> AuctionConnections { get; set; }
        public virtual ICollection<AuctionFavorite> AuctionFavorites { get; set; }
    }
}
