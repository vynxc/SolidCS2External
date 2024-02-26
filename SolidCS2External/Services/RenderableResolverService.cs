using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Services;

public class RenderableResolverService(IServiceProvider serviceProvider, ILogger logger)
{
    public List<T> GetFromInterface<T>() where T : IRenderable
    {
        var list = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(T).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .Select(t => (T)ActivatorUtilities.CreateInstance(serviceProvider, t))
            .ToList();
        
        logger.Information("{ClassName} found {RenderableCount} renderables: {RenderableNames}",
            nameof(RenderableResolverService),
            list.Count,
            string.Join(", ", list.Select(r => r.GetType().Name)));

        return list;
    }
}