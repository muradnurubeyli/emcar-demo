using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoColorEntityConfiguration : BaseEntityConfiguration<AutoColor>
    {
        public override void Configure(EntityTypeBuilder<AutoColor> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoColor", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
