namespace testServerless.Models
{
    public class Auto : BaseEntity
    {
        public Auto()
        {
            this.Auctions = new HashSet<Auction>();
            //this.AutoExchangesOutcome = new HashSet<AutoExchange>();
            //this.AutoExchangesIncome = new HashSet<AutoExchange>();
            //this.AutoFavorites = new HashSet<AutoFavorite>();
            //this.AutoPhotoes = new HashSet<AutoPhoto>();
            //this.ContactsRequests = new HashSet<ContactsRequest>();
            //this.AutoComforts = new HashSet<AutoComfort>();
            //this.AutoMiscs = new HashSet<AutoMisc>();
            //this.AutoMultimedias = new HashSet<AutoMultimedia>();
            //this.AutoSecurities = new HashSet<AutoSecurity>();
            //this.AutoStates = new HashSet<AutoState>();
            //this.AutoPriceOffers = new HashSet<AutoPriceOffer>();
        }

        public int UserId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<System.DateTime> DatePublished { get; set; }
        public Nullable<System.DateTime> DateExpires { get; set; }
        public Nullable<System.DateTime> DateAppearance { get; set; }
        public int StatusId { get; set; }
        public int CityId { get; set; }
        public int TransportTypeId { get; set; }
        public int BodyTypeId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int YearOfIssue { get; set; }
        public string Modification { get; set; }
        public int TSRegistrationId { get; set; }
        public int Probeg { get; set; }
        public int CurrencyId { get; set; }
        public Nullable<decimal> PriceUSD { get; set; }
        public Nullable<decimal> PriceUAH { get; set; }
        public decimal PriceUSDSearch { get; set; }
        public decimal PriceUAHSearch { get; set; }
        public bool IsTorgAvailable { get; set; }
        public bool IsExchangeAvailable { get; set; }
        public Nullable<int> TransmissionTypeId { get; set; }
        public Nullable<int> DriveTypeId { get; set; }
        public Nullable<int> NumberOfDoors { get; set; }
        public Nullable<int> NumberOfSeats { get; set; }
        public Nullable<int> ColorId { get; set; }
        public bool IsColorMetallic { get; set; }
        public Nullable<int> FuelTypeId { get; set; }
        public Nullable<decimal> FuelConsumptionCity { get; set; }
        public Nullable<decimal> FuelConsumptionHighway { get; set; }
        public Nullable<decimal> FuelConsumptionMixed { get; set; }
        public Nullable<decimal> EngineCapacity { get; set; }
        public Nullable<int> Power { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public string CompletionJobId { get; set; }
        public int Top { get; set; }
        public string PlaceLat { get; set; }
        public string PlaceLng { get; set; }
        public bool InAuction { get; set; }
        public Nullable<int> VipX { get; set; }
        public Nullable<System.DateTime> AddedVipDate { get; set; }
        public Nullable<System.DateTime> VipDateExpires { get; set; }
        public string CompletionVipJobID { get; set; }
        public bool IsNew { get; set; }
        public Nullable<int> AutoDealerId { get; set; }
        public bool IsAutoDealerAuto { get; set; }
        public string SeoFriendlyUrl { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public bool IsSold { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> AutoSalonId { get; set; }

        // Relations 
        public virtual AutoBodyType AutoBodyType { get; set; }
        public virtual AutoColor AutoColor { get; set; }
        public virtual AutoDriveType AutoDriveType { get; set; }
        public virtual AutoFuelType AutoFuelType { get; set; }
        public virtual AutoMake AutoMake { get; set; }
        public virtual AutoModel AutoModel { get; set; }
        public virtual AutoStatus AutoStatus { get; set; }
        public virtual AutoSalon AutoSalon { get; set; }
        public virtual AutoDealer AutoDealer { get; set; }
        public virtual AutoTransmissionType AutoTransmissionType { get; set; }
        public virtual AutoTransportType AutoTransportType { get; set; }
        public virtual AutoTSRegistration AutoTSRegistration { get; set; }
        public virtual City City { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
