using Serilog;
using SolidCS2External.ImGuiRendering;

namespace SolidCS2External.Services;

public class CheetoService(ApplicationRenderer appRenderer, ILogger logger)
{
    public async Task Run()
    {
        logger.Debug("Running app renderer in {SvcName}", nameof(CheetoService));
        await appRenderer.Run();
    }
}