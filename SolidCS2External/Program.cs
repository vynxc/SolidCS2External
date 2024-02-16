using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.Startup;

var serviceCollection = new ServiceCollection();
Startup.ConfigureService(serviceCollection);
serviceCollection.AddSingleton<RenderablesGetter>(x => new RenderablesGetter(x));
await using var serviceProvider = serviceCollection.BuildServiceProvider();
var startup = serviceProvider.GetRequiredService<Startup>();
await startup.ConfigureAsync();

public class RenderablesGetter
{
    private readonly IServiceProvider _serviceProvider;

    public RenderablesGetter(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T GetService<T>() where T : IRenderable
    {
        return _serviceProvider.GetRequiredService<T>();
    }

    public List<T> GetAll<T>() where T : IRenderable
    {
        return _serviceProvider.GetServices<T>().ToList();
    }
}