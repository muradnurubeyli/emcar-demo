using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoTransmissionTypeEntityConfiguration : BaseEntityConfiguration<AutoTransmissionType>
    {
        public override void Configure(EntityTypeBuilder<AutoTransmissionType> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoTransmissionType", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
