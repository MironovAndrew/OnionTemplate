﻿namespace OnionTemplate.WEB.DI.AppDI;

public static class CORSExtentions
{
    public static WebApplication AddCORS(
        this WebApplication app, params string[] urls)
    {
        app.UseCors(config =>
        {
            config.WithOrigins(urls)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
        });

        return app;
    }
}
