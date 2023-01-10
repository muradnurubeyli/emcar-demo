using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionFavoriteEntityConfiguration : BaseEntityConfiguration<AuctionFavorite>
    {
        public override void Configure(EntityTypeBuilder<AuctionFavorite> builder)
        {
            base.Configure(builder);
            builder.ToTable("AuctionFavorite", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Auction)
               .WithMany(i => i.AuctionFavorites)
               .HasForeignKey(i => i.AuctionID);

            builder.HasOne(i => i.User)
              .WithMany(i => i.AuctionFavorites)
              .HasForeignKey(i => i.UserID);
        }
    }
}