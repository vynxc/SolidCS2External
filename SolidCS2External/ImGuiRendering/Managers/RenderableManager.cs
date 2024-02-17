using SolidCS2External.Interfaces;

namespace SolidCS2External.ImGuiRendering.Managers;

public class RenderableManager<TRenderable> where TRenderable : IRenderable
{
    private readonly List<TRenderable> _renderables;
    private TRenderable? _currentRenderable;

    public RenderableManager()
    {
        _renderables = new List<TRenderable>();
        _currentRenderable = _renderables.FirstOrDefault();
    }

    public RenderableManager(List<TRenderable> renderables)
    {
        _renderables = renderables;
        _currentRenderable = _renderables.FirstOrDefault();
    }


    public void Add(TRenderable renderable)
    {
        _renderables.Add(renderable);
        _currentRenderable ??= renderable;
    }

    public void AddRange(IEnumerable<TRenderable> renderables)
    {
        _renderables.AddRange(renderables);
    }

    public void Remove(string renderableName)
    {
        var renderable = _renderables.FirstOrDefault(w => w.Name == renderableName);
        if (renderable == null) return;
        _renderables.Remove(renderable);
        _currentRenderable = _renderables.FirstOrDefault();
    }

    public void Render()
    {
        foreach (var renderable in _renderables)
            if (renderable is IWindow { AlwaysRender: true } window)
                window.Render();

        _currentRenderable?.Render();
    }

    public void SetCurrent(string renderableName)
    {
        var currentRenderable = _renderables.FirstOrDefault(w => w.Name == renderableName);
        if (currentRenderable != null) _currentRenderable = currentRenderable;
    }

    public void SetCurrent(int renderableIndex)
    {
        var currentRenderable = _renderables.Where((_, w) => w == renderableIndex).FirstOrDefault();

        if (currentRenderable != null) _currentRenderable = currentRenderable;
    }

    public IEnumerable<string> GetNames()
    {
        return _renderables.Select(x => x.Name);
    }
}