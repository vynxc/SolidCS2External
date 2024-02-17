using System.Numerics;
using ImGuiNET;

namespace SolidCS2External.ImGuiRendering.Drawing;

public static class ImGuiDrawing
{
    public static void DrawGlowEsp(Vector2 head, Vector2 foot, uint glowColor, uint? outlineColor = null)
    {
        var drawList = ImGui.GetWindowDrawList();
        var height = CalculateHeight(head, foot);

        var width = height / 2f;
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var bottomRight = foot with { X = foot.X + width / 2 };
        var vector = ImGui.GetColorU32(new Vector4());

        const float fillWidth = 1.2f;
        const float fillHeight = 1.1f;

        drawList.AddRectFilledMultiColor(topLeft, bottomRight with { X = bottomRight.X - width / fillWidth },
            glowColor, vector,
            vector, glowColor);

        drawList.AddRectFilledMultiColor(topLeft with { X = topLeft.X + width / fillWidth }, bottomRight,
            vector, glowColor,
            glowColor, vector);

        drawList.AddRectFilledMultiColor(topLeft with { Y = topLeft.Y + height / fillHeight }, bottomRight,
            vector, vector,
            glowColor, glowColor);

        drawList.AddRectFilledMultiColor(topLeft, bottomRight with { Y = bottomRight.Y - height / fillHeight },
            glowColor, glowColor,
            vector, vector);

        drawList.AddRect(topLeft, bottomRight, outlineColor ?? glowColor, 5);
    }

    public static void DrawEsp(Vector2 head, Vector2 foot, uint color)
    {
        var drawList = ImGui.GetWindowDrawList();
        var height = CalculateHeight(head, foot);
        var width = height / 2f;
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var bottomRight = foot with { X = foot.X + width / 2 };
        drawList.AddRect(topLeft, bottomRight, color, 5);
    }

    private static float CalculateHeight(Vector2 head, Vector2 foot)
    {
        return Convert.ToSingle(
            Math.Sqrt(Math.Pow(head.X - foot.X, 2)
                      + Math.Pow(head.Y - foot.Y, 2)));
    }
}