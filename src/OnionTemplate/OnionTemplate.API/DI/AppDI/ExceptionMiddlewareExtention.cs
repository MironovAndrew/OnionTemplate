﻿namespace OnionTemplate.API.DI.AppDI;

public static class ExceptionMiddlewareExtention
{
    public static WebApplication UseExceptionHandler(this WebApplication app)
    {
        //application.UseMiddleware<ExceptionMiddleware>();

        return app;
    }
}
