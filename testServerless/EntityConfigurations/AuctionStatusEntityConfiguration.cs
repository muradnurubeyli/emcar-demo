using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AuctionStatusEntityConfiguration : BaseEntityConfiguration<AuctionStatus>
    {
        public override void Configure(EntityTypeBuilder<AuctionStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("AuctionStatus", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}