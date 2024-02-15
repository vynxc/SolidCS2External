using ClickableTransparentOverlay;
using SolidCS2External.Utils;
using WinApi.User32;

namespace SolidCS2External.ImGuiRendering;

public class RendererInitializer(Overlay overlay)
{
    private readonly OnceFlag _initFlag = new ();

    public void Init()
    {
        Call.Once(_initFlag,() =>
        {
            var width= User32Methods.GetSystemMetrics(SystemMetrics.SM_CXSCREEN);
            var height = User32Methods.GetSystemMetrics(SystemMetrics.SM_CYSCREEN);
            overlay.Size = new System.Drawing.Size(width, height);
            Console.WriteLine($"Size: {overlay.Size}");
        });
    }

    public void Reset()
    {
        _initFlag.Reset();
    }
}