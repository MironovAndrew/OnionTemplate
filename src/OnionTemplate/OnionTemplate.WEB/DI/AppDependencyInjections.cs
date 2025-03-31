﻿using OnionTemplate.API.DI.AppDI;

namespace OnionTemplate.API.DI;

public static class AppDependencyInjections
{
    public static WebApplication AddAppDependencyInjection(
        this WebApplication app)
    {
        app.AddCORS("http://localhost:5173");
        app.UseExceptionHandler();
        app.AddGRPCServices(); 
        app.UseOpenTelemetryPrometheusScrapingEndpoint(); 
        return app;
    }
}
