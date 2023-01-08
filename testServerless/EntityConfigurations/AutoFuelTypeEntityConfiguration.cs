using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoFuelTypeEntityConfiguration : BaseEntityConfiguration<AutoFuelType>
    {
        public override void Configure(EntityTypeBuilder<AutoFuelType> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoFuelType", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
