using OnionTemplate.API.DI.ApplicationDI;

namespace OnionTemplate.API.DI;

public static class ApplicationDependencyInjections
{
    public static IServiceCollection AddApplicationDependencyInjection(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRedis(configuration);
        services.AddMassTransitConfig(configuration);
        services.AddOpenTelemetryMetrics();

        return services;
    }
}
