using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.ImGuiRendering.Windows;
using SolidCS2External.Utils;

namespace SolidCS2External.Startup;

public class Startup(ApplicationRenderer rendererRunner)
{
    public async Task ConfigureAsync()
    {
        await rendererRunner.Run();
    }

    public static void ConfigureService(IServiceCollection services)
    {
        //use di for hack configuration  
        services.AddSingleton<Startup>();
        services.AddSingleton<ApplicationRenderer>();
        services.AddSingleton<OverlayWindow>();
        services.AddSingleton<RenderablesGetter>();

        Console.WriteLine("Configured Services!");
    }
}