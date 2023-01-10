namespace testServerless.Models
{
    public class Currency : BaseEntity
    {
        public Currency()
        {
            this.Auctions = new HashSet<Auction>();
            //this.AutoExchanges = new HashSet<AutoExchange>();
            //this.Autoes = new HashSet<Auto>();
            //this.AutoPriceOffers = new HashSet<AutoPriceOffer>();
            //this.BuyRequests = new HashSet<BuyRequest>();
        }

        public string Name { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
