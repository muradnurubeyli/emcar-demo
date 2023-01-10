using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionConnectionEntityConfiguration : BaseEntityConfiguration<AuctionConnection>
    {
        public override void Configure(EntityTypeBuilder<AuctionConnection> builder)
        {
            base.Configure(builder);
            builder.ToTable("AuctionConnection", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.User)
               .WithMany(i => i.AuctionConnections)
               .HasForeignKey(i => i.UserID);

            builder.HasOne(i => i.Auction)
              .WithMany(i => i.AuctionConnections)
              .HasForeignKey(i => i.AuctionID);
        }
    }
}