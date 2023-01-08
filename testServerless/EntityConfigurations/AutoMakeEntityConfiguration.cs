using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoMakeEntityConfiguration : BaseEntityConfiguration<AutoMake>
    {
        public override void Configure(EntityTypeBuilder<AutoMake> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoMake", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.AutoTransportType)
                .WithMany(i => i.AutoMakes)
                .HasForeignKey(i => i.AutoTransportTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
