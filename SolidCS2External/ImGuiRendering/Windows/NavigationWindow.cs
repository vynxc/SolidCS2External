using System.Numerics;
using ImGuiNET;
using SolidCS2External.ImGuiRendering.Components;
using SolidCS2External.ImGuiRendering.Managers;
using SolidCS2External.Interfaces;
using SolidCS2External.Services;
using SolidCS2External.Utils;

namespace SolidCS2External.ImGuiRendering.Windows;

public class NavigationWindow : IWindow
{
    private readonly RenderableManager<IPage> _renderableManager = new();

    public NavigationWindow(RenderableResolverService renderableResolverService)
    {
        var pages = renderableResolverService.GetFromInterface<IPage>();
        _renderableManager.AddRange(pages);
    }

    public string Name => "Navigation";

    public bool AlwaysRender => false;


    public void Render()
    {
        ImGui.SetNextWindowSize(new Vector2(500, 300), ImGuiCond.Once);
        ImGui.SetNextWindowPos(new Vector2(0, 0), ImGuiCond.Once);
        ImGui.SetNextWindowBgAlpha(1);
        ImGui.Begin(Name,
            ImGuiWindowFlags.NoScrollbar |
            ImGuiWindowFlags.NoCollapse);
        {
            ImGui.BeginChild("TabsAndContent", new Vector2(150, -1), ImGuiChildFlags.Border);
            {
                _renderableManager.SetCurrent(VerticalTabBar.Render(_renderableManager.GetNames().ToArray()));
            }
            ImGui.EndChild();
            ImGui.SameLine();
            ImGui.BeginChild("MainContent", new Vector2(0, -1), ImGuiChildFlags.Border);
            {
                _renderableManager.Render();
            }
        }
        ImGui.End();
    }
}