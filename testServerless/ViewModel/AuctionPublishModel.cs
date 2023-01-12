namespace testServerless.ViewModel
{
    public class AuctionPublishModel
    {
        public decimal StartPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public int CurrencyID { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int AutoId { get; set; }
        public int AuctionId { get; set; }
        public DateTime Deadline { get; set; }
    }
}