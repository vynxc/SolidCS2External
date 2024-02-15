using ImGuiNET;

namespace SolidCS2External.ImGuiRendering.Pages;

public class Aimbot : IPage
{
    public string Name => "Aim";

    public void Render()
    {
        ImGui.TextUnformatted("Aimbot Options:");
    }
}