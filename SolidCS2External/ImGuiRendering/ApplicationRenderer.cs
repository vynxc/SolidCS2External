using ClickableTransparentOverlay;
using SolidCS2External.ImGuiRendering.Windows;

namespace SolidCS2External.ImGuiRendering;

public class ApplicationRenderer : Overlay
{
    private readonly RendererInitializer _initializer;
    private readonly RenderableManager<IWindow> _renderableManager;

    public ApplicationRenderer()
    {
        _initializer = new RendererInitializer(this);
        _renderableManager = new RenderableManager<IWindow>();
        _renderableManager.Add(new NavigationWindow());
    }

    protected override void Render()
    {
        _initializer.Init();
        _renderableManager.RenderCurrent();
    }
}