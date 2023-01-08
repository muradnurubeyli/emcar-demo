using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoStatusEntityConfiguration : BaseEntityConfiguration<AutoStatus>
    {
        public override void Configure(EntityTypeBuilder<AutoStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoStatus", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
