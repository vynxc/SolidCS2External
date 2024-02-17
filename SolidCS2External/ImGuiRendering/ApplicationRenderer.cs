using ClickableTransparentOverlay;
using SolidCS2External.ImGuiRendering.Initializers;
using SolidCS2External.ImGuiRendering.Managers;
using SolidCS2External.ImGuiRendering.Windows;
using SolidCS2External.Utils;

namespace SolidCS2External.ImGuiRendering;

public class ApplicationRenderer : Overlay
{
    private readonly RendererInitializer _initializer;
    private readonly RenderableManager<IWindow> _renderableManager;

    public ApplicationRenderer(RenderablesGetter renderablesGetter)
    {
        var navigationWindow = renderablesGetter.GetAll<IWindow>();
        _initializer = new RendererInitializer(this);
        _renderableManager = new RenderableManager<IWindow>(navigationWindow);
        Console.WriteLine("trash");
    }

    protected override void Render()
    {
        _initializer.Init();
        _renderableManager.RenderCurrent();
    }
}