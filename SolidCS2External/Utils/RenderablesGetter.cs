using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Utils;

public class RenderablesGetter(IServiceProvider serviceProvider)
{
    public List<T> GetAll<T>() where T : IRenderable
    {
        return serviceProvider.GetServices<T>().ToList();
    }
}