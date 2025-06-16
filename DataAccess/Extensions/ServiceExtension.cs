using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)

    {
        services
            .AddDbContext<EntityContext>(x => x.UseNpgsql(
                configuration.GetConnectionString("Database")));

        return services;
    }
}