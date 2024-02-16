using SolidCS2External.ImGuiRendering;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Runners;

public class RendererRunner(ApplicationRenderer renderer) : IRendererRunner
{
    public async Task RunAsync()
    {
        await renderer.Run();
    }
}