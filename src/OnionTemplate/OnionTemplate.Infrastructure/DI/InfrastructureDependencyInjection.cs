﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PetHome.Volunteers.Infrastructure.DI;
public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(
       this IServiceCollection services, IConfiguration configuration)
    {
        
        return services;
    }
}
