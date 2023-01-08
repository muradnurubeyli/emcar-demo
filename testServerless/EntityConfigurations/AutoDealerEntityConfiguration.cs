using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoDealerEntityConfiguration : BaseEntityConfiguration<AutoDealer>
    {
        public override void Configure(EntityTypeBuilder<AutoDealer> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoDealer", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
