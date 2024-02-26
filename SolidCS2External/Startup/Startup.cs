using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using SolidCS2External.Game;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.Services;
using ILogger = Serilog.ILogger;

namespace SolidCS2External.Startup;

public static class Startup
{
    public static void ConfigureService(IServiceCollection services)
    {
        //use di for hack configuration  
        services.AddSingleton<CheetoService>();
        services.AddSingleton<ApplicationRenderer>();
        services.AddSingleton<RenderableResolverService>();
        services.AddSingleton<Cs2Manager>();
        services.AddSingleton<ILogger, Logger>(provider =>
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();

            return logger;
        });
        
        Console.WriteLine("Configured Services!");
    }
}