using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class CityEntityConfiguration : BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.ToTable("City", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Region)
                .WithMany(i => i.Cities)
                .HasForeignKey(i => i.RegionId);
        }
    }
}
