using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoModelEntityConfiguration : BaseEntityConfiguration<AutoModel>
    {
        public override void Configure(EntityTypeBuilder<AutoModel> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutoModel", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.AutoMake)
                .WithMany(i => i.AutoModels)
                .HasForeignKey(i => i.AutoMakeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
