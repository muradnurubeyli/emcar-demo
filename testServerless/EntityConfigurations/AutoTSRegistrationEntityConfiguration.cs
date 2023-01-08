using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoTSRegistrationEntityConfiguration : BaseEntityConfiguration<AutoTSRegistration>
    {
        public override void Configure(EntityTypeBuilder<AutoTSRegistration> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoTSRegistration", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
