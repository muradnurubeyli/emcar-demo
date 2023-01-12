using System.ComponentModel.DataAnnotations;
using testServerless.Models;

namespace testServerless.ViewModel
{
    public class AuctionCreateVM
    {
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
    }
}
