using System.Collections.Frozen;
using System.Collections.Immutable;
using ImGuiNET;
using SolidCS2External.Game.Entity;
using SolidCS2External.ImGuiRendering.Drawing;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Game.Features;

public class Esp(Cs2Manager manager) : IFeature
{
    private static readonly FrozenDictionary<string, int> BoneOffsetMap = new Dictionary<string, int>
    {
        { "head", 6 },
        { "cou", 5 },
        { "shoulderR", 8 },
        { "shoulderL", 13 },
        { "brasR", 9 },
        { "brasL", 14 },
        { "handR", 11 },
        { "handL", 16 },
        { "cock", 0 }, // nice
        { "kneesR", 23 },
        { "kneesL", 26 },
        { "feetR", 24 },
        { "feetL", 27 }
    }.ToFrozenDictionary();

    private static readonly ImmutableArray<(string Bone1, string Bone2)> BoneConnections = new[]
    {
        ("cou", "head"),
        ("cou", "shoulderR"),
        ("cou", "shoulderL"),
        ("brasL", "shoulderL"),
        ("brasR", "shoulderR"),
        ("brasR", "handR"),
        ("brasL", "handL"),
        ("cou", "cock"),
        ("kneesR", "cock"),
        ("kneesL", "cock"),
        ("kneesL", "feetL"),
        ("kneesR", "feetR")
    }.ToImmutableArray();

    public Cs2Manager Manager { get; } = manager;

    public bool Enabled { get; set; } = true;

    public string Name => "ESP";

    public void Initialize()
    {
    }

    public void Render()
    {
        List<EntityPawn> tempPawns;
        lock (Manager.EntityListLock)
        {
            tempPawns = [..Manager.EntityList];
        }

        Console.WriteLine($"Rendering {tempPawns.Count} players");
        foreach (var player in tempPawns)
        {
            var head = player.GameSceneNode.GetBonePosition(BoneOffsetMap["head"]);
            var foot = player.GameSceneNode.Origin.Value.GetValueOrDefault();
            var screenHead = Manager.WorldToScreen(head);
            var screenFoot = Manager.WorldToScreen(foot);

            if (!screenHead.HasValue || !screenFoot.HasValue)
                continue;

            ImGuiDrawing.DrawGlowEsp(screenHead.Value, screenFoot.Value, ImGui.GetColorU32(ImGuiCol.Button),
                ImGui.GetColorU32(ImGuiCol.ButtonActive));
            DrawSkeleton(player);
        }
    }

    private void DrawSkeleton(EntityPawn entityPawn)
    {
        foreach (var connection in BoneConnections)
        {
            var bone1 = BoneOffsetMap[connection.Bone1];
            var bone2 = BoneOffsetMap[connection.Bone2];

            var bone1Pos = entityPawn.GameSceneNode.GetBonePosition(bone1);
            var bone2Pos = entityPawn.GameSceneNode.GetBonePosition(bone2);


            var screenBone1 = Manager.WorldToScreen(bone1Pos);
            var screenBone2 = Manager.WorldToScreen(bone2Pos);
            if (!screenBone1.HasValue || !screenBone2.HasValue)
                continue;

            ImGui.GetWindowDrawList().AddLine(screenBone1.Value, screenBone2.Value,
                ImGui.GetColorU32(ImGuiCol.ButtonActive), 2);
        }
    }
}