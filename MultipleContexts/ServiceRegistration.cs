using Microsoft.EntityFrameworkCore;
using MultipleContexts.Models.Contexts;

namespace MultipleContexts
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services, string productConnStr, string connCustomerStr)
        {
            services.AddDbContext<ProductDbContext>(options =>
            {
                options.UseSqlServer(productConnStr, sqlServerAction =>
                {
                    sqlServerAction.EnableRetryOnFailure(3);

                    sqlServerAction.CommandTimeout(30);
                });

                options.EnableDetailedErrors(true);
                options.EnableSensitiveDataLogging(true);

            }, ServiceLifetime.Singleton);

            services.AddDbContext<CustomerDbContext>(options =>
            {
                options.UseSqlServer(connCustomerStr, sqlServerAction =>
                {
                    sqlServerAction.EnableRetryOnFailure(3);

                    sqlServerAction.CommandTimeout(30);
                });

                options.EnableDetailedErrors(true);
                options.EnableSensitiveDataLogging(true);

            }, ServiceLifetime.Singleton);
        }
    }
}
