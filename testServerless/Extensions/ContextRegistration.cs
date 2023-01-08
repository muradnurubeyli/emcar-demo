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
                var connStr = "Server=emcar.chmm0uo74534.eu-central-1.rds.amazonaws.com,1433;Database=Emcar;User Id=master;Password=Master12345;TrustServerCertificate=True; TrustServerCertificate=True;";
                conf.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAutoRepository, AutoRepository>();

            return services;
        }
    }
}
