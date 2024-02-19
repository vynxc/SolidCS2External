using System.Numerics;
using ImGuiNET;

namespace SolidCS2External.ImGuiRendering.Drawing;

public static class ImGuiDrawing
{
    public static void DrawGlowEsp(Vector2 head, Vector2 foot, uint glowColor, uint? outlineColor = null)
    {
        if (!(IsVectorOnScreen(head) || IsVectorOnScreen(foot)))
            return;
        var drawList = ImGui.GetWindowDrawList();
        var height = CalculateHeight(head, foot);
        var padding = new Vector2(height/300);
        var thickness = Math.Min(height/150, 4);
        height *= 1.2f;
        var width = height / 2f;
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var bottomRight = foot with { X = foot.X + width / 2 };
        var vector = ImGui.GetColorU32(new Vector4());
        var healthBarWidth = Math.Max(width / 25, 2);
        var health = 50;
        var healthPercentage = health / 100f;
        var healthBarHeight = height * healthPercentage;

        var healthBarTopLeft = topLeft with { X = topLeft.X - healthBarWidth * 2 };
        var healthBarTopLeftAdjusted = new Vector2(topLeft.X - healthBarWidth * 2, bottomRight.Y - healthBarHeight);


        var healthBarBottomRight = bottomRight with { X = topLeft.X - healthBarWidth };
        drawList.AddRect(healthBarTopLeft-padding, healthBarBottomRight+padding, ImGui.GetColorU32(new Vector4(0, 0, 0, 1)), 0, ImDrawFlags.None, thickness);

        drawList.AddRect(healthBarTopLeft, healthBarBottomRight, outlineColor ?? glowColor);
        drawList.AddRectFilled(healthBarTopLeftAdjusted, healthBarBottomRight,
            ImGui.GetColorU32(new Vector4(1, 0, 0, 1)));
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
        drawList.AddRect(topLeft-padding, bottomRight+padding, ImGui.GetColorU32(new Vector4(0, 0, 0, 1)), 0, ImDrawFlags.None, thickness);

        drawList.AddRect(topLeft, bottomRight, outlineColor ?? glowColor);
    }

    public static void DrawFilledBar()
    {
    }

    public static void DrawEsp(Vector2 head, Vector2 foot, uint color)
    {
        if (!(IsVectorOnScreen(head) || IsVectorOnScreen(foot)))
            return;

        var drawList = ImGui.GetWindowDrawList();
        var height = CalculateHeight(head, foot);
        var width = height / 2f;
        var topLeft = new Vector2(foot.X - width / 2, foot.Y - height);
        var bottomRight = foot with { X = foot.X + width / 2 };

        drawList.AddRectFilled(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 0.18f)));

        drawList.AddRect(topLeft, bottomRight,
            ImGui.ColorConvertFloat4ToU32(new Vector4(0, 0, 0, 1)), 3, ImDrawFlags.RoundCornersAll, 2);

        drawList.AddRect(topLeft, bottomRight, color, 3,
            ImDrawFlags.RoundCornersAll, 1);
    }

    private static float CalculateHeight(Vector2 head, Vector2 foot)
    {
        return Convert.ToSingle(
            Math.Sqrt(Math.Pow(head.X - foot.X, 2)
                      + Math.Pow(head.Y - foot.Y, 2)));
    }

    private static bool IsVectorOnScreen(Vector2 pos)
    {
        return pos.X > 0 && pos.X < 3440 && pos.Y > 0 && pos.Y < 1440;
    }
}