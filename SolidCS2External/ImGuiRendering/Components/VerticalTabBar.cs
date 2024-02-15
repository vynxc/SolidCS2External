using System.Numerics;
using ImGuiNET;

namespace SolidCS2External.ImGuiRendering.Components;

public static class VerticalTabBar
{
    private static int _selectedTab;

    public static int Render(string[] tabNames)
    {
        ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 1.0f);
        ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 0.0f);

        for (var i = 0; i < tabNames.Length; ++i)
            if (ImGui.Button(tabNames[i], new Vector2(-1, 30)))
                _selectedTab = i;

        ImGui.PopStyleVar(2);
        return _selectedTab;
    }
}