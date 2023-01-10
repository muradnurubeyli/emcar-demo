using Microsoft.EntityFrameworkCore;
using System.Reflection;
using testServerless.Models;

namespace testServerless.Context
{
    public class EmcarContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "dbo";

        public EmcarContext()
        {

        }

        public EmcarContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionBid> AuctionBids { get; set; }
        public DbSet<AuctionConnection> AuctionConnections { get; set; }
        public DbSet<AuctionFavorite> AuctionFavorites { get; set; }
        public DbSet<AuctionPhoto> AuctionPhotos { get; set; }
        public DbSet<AuctionStatus> AuctionStatuses { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoBodyType> AutoBodyTypes { get; set; }
        public DbSet<AutoColor> AutoColors { get; set; }
        public DbSet<AutoDealer> AutoDealers { get; set; }
        public DbSet<AutoDriveType> AutoDriveTypes { get; set; }
        public DbSet<AutoFuelType> AutoFuelTypes { get; set; }
        public DbSet<AutoMake> AutoMakes { get; set; }
        public DbSet<AutoModel> AutoModels { get; set; }
        public DbSet<AutoSalon> AutoSalons { get; set; }
        public DbSet<AutoStatus> AutoStatuses { get; set; }
        public DbSet<AutoTransmissionType> AutoTransmissionTypes { get; set; }
        public DbSet<AutoTransportType> AutoTransportTypes { get; set; }
        public DbSet<AutoTSRegistration> AutoTSRegistrations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connStr = "Server=CBM2; Database=Emcar; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true;Integrated Security=True;";

                var connStr = "Server=emcar.chmm0uo74534.eu-central-1.rds.amazonaws.com;Database=Emcar;User Id=master;Password=Master12345;TrustServerCertificate=True; TrustServerCertificate=True;";

                optionsBuilder.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            OnBeforeSave();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSave();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSave();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void OnBeforeSave()
        {
            var addedEntites = ChangeTracker.Entries()
                                    .Where(i => i.State == EntityState.Added)
                                    .Select(i => (BaseEntity)i.Entity);

            //PrepareAddedEntities(addedEntites);
        }

        //private void PrepareAddedEntities(IEnumerable<BaseEntity> entities)
        //{
        //    foreach (var entity in entities)
        //    {
        //        if (entity.CreateDate == DateTime.MinValue)
        //            entity.CreateDate = DateTime.Now;
        //    }
        //}
    }
}
