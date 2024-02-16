using System.Drawing;
using ClickableTransparentOverlay;
using WinApi.User32;

namespace SolidCS2External.ImGuiRendering;

public class RendererInitializer(Overlay overlay)
{
    private bool _isInit;

    public void Init()
    {
        if (_isInit) return;
        var width = User32Methods.GetSystemMetrics(SystemMetrics.SM_CXSCREEN);
        var height = User32Methods.GetSystemMetrics(SystemMetrics.SM_CYSCREEN);
        overlay.Size = new Size(width, height);
        Console.WriteLine($"Size: {overlay.Size}");
        _isInit = true;
    }
}