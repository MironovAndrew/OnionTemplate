using OnionTemplate.WEB.DI.InfrastructureDI;

namespace OnionTemplate.WEB.DI;

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
