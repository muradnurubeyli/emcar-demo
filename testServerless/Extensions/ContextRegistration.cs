using Microsoft.EntityFrameworkCore;
using testServerless.Context;
using testServerless.Repositories;

namespace testServerless.Extensions
{
    public static class ContextRegistration
    {
        public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmcarContext>(conf =>
            {
                //var connStr = configuration["EmcarDbConnectionString"].ToString();
                var connStr = "Server=CBM; Database=Emcar; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true;Integrated Security=True;";
                conf.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAutoRepository, AutoRepository>();
            services.AddScoped<IAuctionRepository, AuctionRepository>();

            return services;
        }
    }
}
