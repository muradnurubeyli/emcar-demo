using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoTransportTypeEntityConfiguration : BaseEntityConfiguration<AutoTransportType>
    {
        public override void Configure(EntityTypeBuilder<AutoTransportType> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoTransportType", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
