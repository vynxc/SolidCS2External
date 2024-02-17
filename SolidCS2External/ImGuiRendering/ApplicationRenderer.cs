using System.Numerics;
using ClickableTransparentOverlay;
using ImGuiNET;
using SolidCS2External.ImGuiRendering.Initializers;
using SolidCS2External.ImGuiRendering.Managers;
using SolidCS2External.Interfaces;
using SolidCS2External.Utils;

namespace SolidCS2External.ImGuiRendering;

public class ApplicationRenderer : Overlay
{
    private static float _staticHue;
    private readonly RendererInitializer _initializer;
    private readonly RenderableManager<IWindow> _renderableManager;

    public ApplicationRenderer(RenderablesGetter renderablesGetter)
    {
        var navigationWindow = renderablesGetter.GetAll<IWindow>();
        _initializer = new RendererInitializer(this);
        _renderableManager = new RenderableManager<IWindow>(navigationWindow);
    }

    protected override void Render()
    {
        _initializer.Init();
        _renderableManager.RenderCurrent();
        ImGui.SetNextWindowSize(new Vector2(2560, 1440));
        ImGui.Begin("overlay", ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove |
                               ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoInputs |
                               ImGuiWindowFlags.NoBackground);
        {
            var widthCenter = 2560 / 2;
            var heightCenter = 1440 / 2;

            DrawGlowEsp(new Vector2(widthCenter - 150, heightCenter - 150),
                new Vector2(widthCenter, heightCenter + 150));
        }
        ImGui.End();
    }

    private void DrawGlowEsp(Vector2 head, Vector2 foot)
    {
        var drawList = ImGui.GetWindowDrawList();
        var height = Convert.ToSingle(
            Math.Sqrt(Math.Pow(head.X - foot.X, 2)
                      + Math.Pow(head.Y - foot.Y, 2)));

        var width = height / 2f;
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var bottomRight = new Vector2(foot.X + width / 2, foot.Y);
        //  var glowColor = ImGui.GetColorU32(new Vector4(0f, 0f, .3f, .25f));
        var vector = ImGui.GetColorU32(new Vector4());
        var rainbowSpeed = 0.001f;
        _staticHue -= rainbowSpeed;
        if (_staticHue < -1f)
            _staticHue += 1f;
        var length = ImGui.GetWindowHeight();
        //left right
        const float fillWidth = 1.2f;
        const float fillHeight = 1.1f;

        var hue = _staticHue + 1f / length;
        if (hue < 0f)
            hue += 1f;
        ImGui.ColorConvertHSVtoRGB(hue, 1, 1, out var r, out var g, out var b);
        var tempColor = ImGui.GetColorU32(new Vector4(r, g, b, 1));
        var convertedColor = ImGui.ColorConvertU32ToFloat4(tempColor);
        convertedColor.W = .25f;
        Console.WriteLine(convertedColor.ToString());
        var glowColor = ImGui.GetColorU32(convertedColor);
        drawList.AddRectFilledMultiColor(topLeft, new Vector2(bottomRight.X - width / fillWidth, bottomRight.Y),
            glowColor, vector,
            vector, glowColor);

        //right left
        drawList.AddRectFilledMultiColor(new Vector2(topLeft.X + width / fillWidth, topLeft.Y), bottomRight,
            vector, glowColor,
            glowColor, vector);


        // // bottom top
        drawList.AddRectFilledMultiColor(new Vector2(topLeft.X, topLeft.Y + height / fillHeight), bottomRight,
            vector, vector,
            glowColor, glowColor);
        //
        // // top bottom
        drawList.AddRectFilledMultiColor(topLeft, new Vector2(bottomRight.X, bottomRight.Y - height / fillHeight),
            glowColor, glowColor,
            vector, vector);

        drawList.AddRect(topLeft, bottomRight, ImGui.GetColorU32(convertedColor * 10), 5);
    }

    private void DrawEsp(Vector2 head, Vector2 foot)
    {
        var drawList = ImGui.GetWindowDrawList();
        var height = Convert.ToSingle(
            Math.Sqrt(Math.Pow(head.X - foot.X, 2)
                      + Math.Pow(head.Y - foot.Y, 2)));

        var width = height / 2f;
        var bumpHeight = height / 15;
        var bottomLeft = new Vector2(foot.X - width / 2, foot.Y);
        var bottomRight = new Vector2(foot.X + width / 2, foot.Y);
        var bumpCenter = foot with { Y = foot.Y - height + bumpHeight };
        var center = new Vector2(foot.X, foot.Y - height);
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var topRight = new Vector2(foot.X + width / 2, foot.Y - height);
        var topLeftThird = new Vector2(foot.X - width / 4, foot.Y - height);
        var topRightThird = new Vector2(foot.X + width / 4, foot.Y - height);

        drawList.AddLine(topLeft, bottomLeft, ImGui.GetColorU32(ImGuiCol.ButtonActive));
        drawList.AddLine(topLeft, topLeftThird, ImGui.GetColorU32(ImGuiCol.ButtonActive));
        drawList.AddLine(bottomRight, topRight, ImGui.GetColorU32(ImGuiCol.ButtonActive));
        drawList.AddLine(topRight, topRightThird, ImGui.GetColorU32(ImGuiCol.ButtonActive));
        drawList.AddLine(bottomLeft, bottomRight, ImGui.GetColorU32(ImGuiCol.ButtonActive));
        drawList.AddText(center - new Vector2(ImGui.CalcTextSize("John").X / 2, ImGui.CalcTextSize("John").Y / 2),
            ImGui.GetColorU32(ImGuiCol.ButtonActive), "John");
        drawList.AddBezierQuadratic(topLeftThird, bumpCenter, topRightThird, ImGui.GetColorU32(ImGuiCol.ButtonActive),
            1);
    }
}