using System.Drawing;
using ClickableTransparentOverlay;
using Serilog;
using Serilog.Core;
using SolidCS2External.ImGuiRendering.Managers;
using SolidCS2External.Interfaces;
using SolidCS2External.Services;
using SolidCS2External.Utils;
using WinApi.User32;

namespace SolidCS2External.ImGuiRendering;

public class ApplicationRenderer(RenderableResolverService renderableResolverService, ILogger logger) : Overlay
{
    private readonly OnceFlag _callFlag = new();


    private RenderableManager<IWindow> _renderableManager = null!;

    protected override Task PostInitialized()
    {
        VSync = false;
        return base.PostInitialized();
    }

    protected override void Render()
    {
        Call.Once(_callFlag, () =>
        {
            logger.Debug("Executing call.once render (resizing overlay)");
            var width = User32Methods.GetSystemMetrics(SystemMetrics.SM_CXSCREEN);
            var height = User32Methods.GetSystemMetrics(SystemMetrics.SM_CYSCREEN);
            Size = new Size(width, height);
            var navigationWindow = renderableResolverService.GetFromInterface<IWindow>();
            _renderableManager = new RenderableManager<IWindow>(navigationWindow);
            
            logger.Information("Overlay size: {Size}", Size);
        });
        
        _renderableManager.Render();
    }
}