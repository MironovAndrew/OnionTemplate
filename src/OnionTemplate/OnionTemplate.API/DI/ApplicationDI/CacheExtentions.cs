namespace OnionTemplate.API.DI.ApplicationDI;

public static class CacheExtentions
{
    public static IServiceCollection AddRedis(
        this IServiceCollection services, IConfiguration configuration)
    {
        
        return services;
    }
}
