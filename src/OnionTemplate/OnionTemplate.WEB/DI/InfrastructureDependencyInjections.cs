using OnionTemplate.API.DI.InfrastructureDI;

namespace OnionTemplate.API.DI;

public static class InfrastructureDependencyInjections
{
    public static IServiceCollection AddInfrastructureDependencyInjection(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabases(configuration);
        services.AddMessageBus(configuration);

        return services;
    }
}
