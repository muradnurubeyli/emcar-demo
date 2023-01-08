using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testServerless.Context;
using testServerless.Models;

namespace testServerless.EntityConfigurations
{
    public class AutoEntityConfiguration : BaseEntityConfiguration<Auto>
    {
        public override void Configure(EntityTypeBuilder<Auto> builder)
        {
            base.Configure(builder);
            builder.ToTable("Auto", EmcarContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.AutoBodyType)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.BodyTypeId);

            builder.HasOne(i => i.AutoColor)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.ColorId);

            builder.HasOne(i => i.AutoDriveType)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.DriveTypeId);

            builder.HasOne(i => i.AutoFuelType)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.FuelTypeId);

            builder.HasOne(i => i.AutoMake)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.MakeId);

            builder.HasOne(i => i.AutoModel)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.ModelId);

            builder.HasOne(i => i.AutoStatus)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.StatusId);

            builder.HasOne(i => i.AutoSalon)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.AutoSalonId);

            builder.HasOne(i => i.AutoDealer)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.AutoDealerId);

            builder.HasOne(i => i.AutoTransmissionType)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.TransmissionTypeId);

            builder.HasOne(i => i.AutoTransportType)
                .WithMany(i => i.Autos)
                .HasForeignKey(i => i.TransportTypeId);

            builder.HasOne(i => i.AutoTSRegistration)
               .WithMany(i => i.Autos)
               .HasForeignKey(i => i.TSRegistrationId);

            builder.HasOne(i => i.City)
               .WithMany(i => i.Autos)
               .HasForeignKey(i => i.CityId);

            builder.HasOne(i => i.Currency)
               .WithMany(i => i.Autos)
               .HasForeignKey(i => i.CurrencyId);

            builder.HasOne(i => i.User)
               .WithMany(i => i.Autos)
               .HasForeignKey(i => i.UserId);
        }
    }
}
