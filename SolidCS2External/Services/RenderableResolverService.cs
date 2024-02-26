using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Services;

public class RenderableResolverService(IServiceProvider serviceProvider)
{
    public List<T> GetFromInterface<T>() where T : IRenderable
    {
        return Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(T).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .Select(t => (T)ActivatorUtilities.CreateInstance(serviceProvider, t))
            .ToList();
    }
}