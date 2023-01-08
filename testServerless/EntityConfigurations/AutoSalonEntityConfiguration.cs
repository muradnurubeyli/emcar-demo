using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoSalonConfiguration : BaseEntityConfiguration<AutoSalon>
    {
        public override void Configure(EntityTypeBuilder<AutoSalon> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoSalon", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
