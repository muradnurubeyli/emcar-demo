
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoDriveTypeEntityConfiguration : BaseEntityConfiguration<AutoDriveType>
    {
        public override void Configure(EntityTypeBuilder<AutoDriveType> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoDriveType", EmcarContext.DEFAULT_SCHEMA);
        }
    }
}
