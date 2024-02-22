using System.Drawing;
using System.Numerics;
using ImGuiNET;
using SolidCS2External.Game;
using SolidCS2External.Game.Features;
using SolidCS2External.Game.Managers;
using SolidCS2External.Interfaces;
using SolidCS2External.Utils;

namespace SolidCS2External.ImGuiRendering.Windows;

public class OverlayWindow(ApplicationRenderer renderer, Cs2Manager cs2Manager) : IWindow
{
    private readonly OnceFlag _onceFlag = new();
    private readonly Size _size = renderer.Size;

    public string Name => "Overlay";

    public bool AlwaysRender => true;

    public void Render()
    {
        Call.Once(_onceFlag, () => { Console.WriteLine($"Size: {_size}"); });

        ImGui.SetNextWindowSize(new Vector2(_size.Width, _size.Height), ImGuiCond.Once);
        ImGui.SetNextWindowPos(new Vector2(0, 0), ImGuiCond.Once);
        ImGui.Begin("overlay", ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
                               ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs |
                               ImGuiWindowFlags.NoBackground);

        // TODO: move FeaturesManager somewhere else
        // And avoid 
        var fm = new FeaturesManager([new Esp(cs2Manager), new Aimbot(cs2Manager)]);
        fm.Render();

        ImGui.End();
    }
}