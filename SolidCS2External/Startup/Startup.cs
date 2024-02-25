using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Game;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.Services;
using SolidCS2External.Utils;

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
        Console.WriteLine("Configured Services!");
    }
}