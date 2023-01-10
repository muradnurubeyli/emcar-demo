using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionBidEntityConfiguration : BaseEntityConfiguration<AuctionBid>
    {
        public override void Configure(EntityTypeBuilder<AuctionBid> builder)
        {
            base.Configure(builder);
            builder.ToTable("AuctionBid", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Auction)
               .WithMany(i => i.AuctionBids)
               .HasForeignKey(i => i.AuctionID);

            builder.HasOne(i => i.User)
              .WithMany(i => i.AuctionBids)
              .HasForeignKey(i => i.UserID);
        }
    }
}