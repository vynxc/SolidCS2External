using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Utils;

public class RenderablesGetter(IServiceProvider serviceProvider)
{
    public T GetService<T>() where T : IRenderable
    {
        return serviceProvider.GetRequiredService<T>();
    }

    public List<T> GetAll<T>() where T : IRenderable
    {
        return serviceProvider.GetServices<T>().ToList();
    }
}