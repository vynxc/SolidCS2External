using System.Collections.Frozen;
using ImGuiNET;
using SolidCS2External.Game.Entity;
using SolidCS2External.Game.Offsets;
using SolidCS2External.ImGuiRendering.Drawing;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Game.Features;

public class Esp(Cs2Manager manager) : IFeature
{
    public static readonly FrozenDictionary<BoneOffset, BoneOffset[]> BoneConnections =
        new Dictionary<BoneOffset, BoneOffset[]>
        {
            { BoneOffsets.Cou, [BoneOffsets.Head, BoneOffsets.ShoulderR, BoneOffsets.ShoulderL, BoneOffsets.Cock] },
            { BoneOffsets.BrasL, [BoneOffsets.ShoulderL, BoneOffsets.HandL] },
            { BoneOffsets.BrasR, [BoneOffsets.ShoulderR, BoneOffsets.HandR] },
            { BoneOffsets.KneesR, [BoneOffsets.FeetR, BoneOffsets.Cock] },
            { BoneOffsets.KneesL, [BoneOffsets.FeetL, BoneOffsets.Cock] }
        }.ToFrozenDictionary();

    public Cs2Manager Manager { get; } = manager;

    public bool Enabled { get; set; } = true;

    public string Name => "ESP";

    public void Initialize()
    {
    }

    public void Run(EntityList entityList)
    {
    }

    public void EntityLoop(EntityPawn pawn)
    {
        var head = pawn.GameSceneNode.GetBonePositionCached(BoneOffsets.Head.Offset);
        var foot = pawn.GameSceneNode.Origin.Value.GetValueOrDefault();
        var screenHead = Manager.WorldToScreen(head);
        var screenFoot = Manager.WorldToScreen(foot);

        if (!screenHead.HasValue || !screenFoot.HasValue)
            return;

        ImGuiDrawing.DrawGlowEsp(screenHead.Value, screenFoot.Value, ImGui.GetColorU32(ImGuiCol.Button),
            ImGui.GetColorU32(ImGuiCol.ButtonActive));
        DrawSkeleton(pawn);
    }

    private void DrawSkeleton(EntityPawn entityPawn)
    {
        foreach (var baseBone in BoneConnections)
        {
            var boneOffset1 = baseBone.Key.Offset;
            foreach (var connectedBone in baseBone.Value)
            {
                var boneOffset2 = connectedBone.Offset;

                var bone1Pos = entityPawn.GameSceneNode.GetBonePositionCached(boneOffset1);
                var bone2Pos = entityPawn.GameSceneNode.GetBonePositionCached(boneOffset2);


                var screenBone1 = Manager.WorldToScreen(bone1Pos);
                var screenBone2 = Manager.WorldToScreen(bone2Pos);
                if (!screenBone1.HasValue || !screenBone2.HasValue)
                    continue;

                ImGui.GetWindowDrawList().AddLine(screenBone1.Value, screenBone2.Value,
                    ImGui.GetColorU32(ImGuiCol.ButtonActive), 2);
            }
        }
    }

    public static class BoneOffsets
    {
        public static readonly BoneOffset Head = new("head", 6);
        public static readonly BoneOffset Cou = new("cou", 5);
        public static readonly BoneOffset ShoulderR = new("shoulderR", 8);
        public static readonly BoneOffset ShoulderL = new("shoulderL", 13);
        public static readonly BoneOffset BrasR = new("brasR", 9);
        public static readonly BoneOffset BrasL = new("brasL", 14);
        public static readonly BoneOffset HandR = new("handR", 11);
        public static readonly BoneOffset HandL = new("handL", 16);
        public static readonly BoneOffset Cock = new("cock", 0);
        public static readonly BoneOffset KneesR = new("kneesR", 23);
        public static readonly BoneOffset KneesL = new("kneesL", 26);
        public static readonly BoneOffset FeetR = new("feetR", 24);
        public static readonly BoneOffset FeetL = new("feetL", 27);
    }
}