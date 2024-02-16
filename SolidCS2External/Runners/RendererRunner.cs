using SolidCS2External.ImGuiRendering;

namespace SolidCS2External.Runners;

public class RendererRunner(ApplicationRenderer renderer) : IRendererRunner
{
    public async Task RunAsync()
    {
        await renderer.Run();
    }
}