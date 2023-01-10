using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionPhotoEntityConfiguration : BaseEntityConfiguration<AuctionPhoto>
    {
        public override void Configure(EntityTypeBuilder<AuctionPhoto> builder)
        {
            base.Configure(builder);
            builder.ToTable("AuctionPhoto", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Auction)
               .WithMany(i => i.AuctionPhotos)
               .HasForeignKey(i => i.AuctionID);
        }
    }
}