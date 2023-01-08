using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoBodyTypeEntityConfiguration : BaseEntityConfiguration<AutoBodyType>
    {
        public override void Configure(EntityTypeBuilder<AutoBodyType> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoBodyType", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
