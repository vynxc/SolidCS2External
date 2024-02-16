using ClickableTransparentOverlay;
using SolidCS2External.ImGuiRendering.Windows;

namespace SolidCS2External.ImGuiRendering;

public class ApplicationRenderer : Overlay
{
    private readonly RendererInitializer _initializer;
    private readonly RenderableManager<IWindow> _renderableManager;

    public ApplicationRenderer(NavigationWindow navigationWindow)
    {
        Console.WriteLine("ApplicationRenderer");
        _initializer = new RendererInitializer(this);
        _renderableManager = new RenderableManager<IWindow>();
        _renderableManager.Add(navigationWindow);
    }

    protected override void Render()
    {
        _initializer.Init();
        _renderableManager.RenderCurrent();
    }
}