namespace testServerless.ViewModel
{
    public class GetAutoViewModel
    {
        public int Id { get; set; }
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
    }
}
