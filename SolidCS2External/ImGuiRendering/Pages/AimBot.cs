using ImGuiNET;
using SolidCS2External.Interfaces;

namespace SolidCS2External.ImGuiRendering.Pages;

public class AimBot : IPage
{
    public string Name => "Aim";

    public void Render()
    {
        ImGui.TextUnformatted("AimBot Options:");
    }
}