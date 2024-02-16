using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.ImGuiRendering.Pages;
using SolidCS2External.ImGuiRendering.Windows;
using SolidCS2External.Interfaces;
using SolidCS2External.Runners;

namespace SolidCS2External.Startup;

public class Startup(IRendererRunner rendererRunner)
{
    public async Task ConfigureAsync()
    {
        await rendererRunner.RunAsync();
    }

    public static void ConfigureService(IServiceCollection services)
    {
        services.AddSingleton<Startup>();
        services.AddSingleton<ApplicationRenderer>();
        services.AddSingleton<IPage, AimBot>();
        services.AddSingleton<IWindow, NavigationWindow>();
        services.AddSingleton<IRendererRunner, RendererRunner>();
        Console.WriteLine("Configured Services!");
    }
}