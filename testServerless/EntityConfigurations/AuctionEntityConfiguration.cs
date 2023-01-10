using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionEntityConfiguration : BaseEntityConfiguration<Auction>
    {
        public override void Configure(EntityTypeBuilder<Auction> builder)
        {
            base.Configure(builder);
            builder.ToTable("Auction", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.AuctionStatus)
               .WithMany(i => i.Auctions)
               .HasForeignKey(i => i.StatusID);

            builder.HasOne(i => i.Currency)
              .WithMany(i => i.Auctions)
              .HasForeignKey(i => i.CurrencyID);

            builder.HasOne(i => i.Auto)
             .WithMany(i => i.Auctions)
             .HasForeignKey(i => i.AutoID);
        }
    }
}