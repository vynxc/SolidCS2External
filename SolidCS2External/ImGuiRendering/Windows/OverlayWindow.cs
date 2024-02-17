using System.Drawing;
using System.Numerics;
using ImGuiNET;
using SolidCS2External.Interfaces;

namespace SolidCS2External.ImGuiRendering.Windows;

public class OverlayWindow(ApplicationRenderer renderer) : IWindow
{
    private readonly Size _size = renderer.Size;

    public string Name => "Overlay";

    public bool AlwaysRender => true;

    public void Render()
    {
        ImGui.SetNextWindowSize(new Vector2(_size.Width, _size.Height), ImGuiCond.Once);
        ImGui.SetNextWindowPos(new Vector2(0, 0), ImGuiCond.Once);
        ImGui.Begin("overlay", ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
                               ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs |
                               ImGuiWindowFlags.NoBackground);
        {
            ImGui.Text("Hello, world! This is the overlay window.");
        }
        ImGui.End();
    }
}