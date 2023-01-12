using System.ComponentModel.DataAnnotations;
using testServerless.Models;

namespace testServerless.ViewModel
{
    public class AuctionCreateVM
    {
        public int ID { get; set; }

        public int AutoID { get; set; }

        [Range(1, int.MaxValue)]
        public int StartPrice { get; set; }

        public int CurrencyID { get; set; }

        public int Days { get; set; }

        public int Hours { get; set; }

        public string Description { get; set; }

        //public List<AuctionPhotoVM> AuctionPhotoes { get; set; }

        public static implicit operator AuctionCreateVM(Auction model)
        {
            AuctionCreateVM vm = new AuctionCreateVM()
            {
                ID = model?.Id ?? 0,
                AutoID = model?.AutoID ?? 0,
                CurrencyID = model?.CurrencyID ?? 0,
                StartPrice = Convert.ToInt32(model?.StartPrice ?? 0),
                Description = model?.Description
            };
            //vm.AuctionPhotoes = new List<AuctionPhotoVM>();

            //foreach (var item in model.AuctionPhotoes)
            //    vm.AuctionPhotoes.Add(item);

            return vm;
        }
    }
}
