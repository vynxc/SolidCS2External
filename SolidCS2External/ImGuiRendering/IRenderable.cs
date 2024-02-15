namespace SolidCS2External.ImGuiRendering;

public interface IRenderable
{
    string Name { get; }
    void Render();
}