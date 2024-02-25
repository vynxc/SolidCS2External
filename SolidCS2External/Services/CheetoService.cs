using SolidCS2External.ImGuiRendering;

namespace SolidCS2External.Services;

public class CheetoService(ApplicationRenderer appRenderer)
{
    public async Task Run()
    {
        await appRenderer.Run();
    }
}