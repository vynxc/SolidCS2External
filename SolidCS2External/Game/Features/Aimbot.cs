using System.Numerics;
using SolidCS2External.Game.Entity;
using SolidCS2External.Interfaces;
using WinApi.User32;

namespace SolidCS2External.Game.Features;

public class Aimbot(Cs2Manager manager) : IFeature
{
    public Cs2Manager Manager { get; } = manager;

    public bool Enabled { get; set; } = true;

    public string Name => "Aimbot";


    public void Initialize()
    {
    }

    public void Run(EntityList entityList)
    {
        try
        {
            if (Manager.LocalPlayer is null) return;
            var entityListAsList = entityList.Buffer.Where(x => x is not null).ToList();
            var lHead = Manager.LocalPlayer.GameSceneNode.Origin.Value.GetValueOrDefault();
            entityListAsList.Sort((a, b) =>
            {
                if (a is null) Console.WriteLine("a is null");
                if (b is null) Console.WriteLine("b is null");
                var aHead = a!.GameSceneNode.GetBonePositionCached(Esp.BoneOffsets.Head.Offset);
                var bHead = b!.GameSceneNode.GetBonePositionCached(Esp.BoneOffsets.Head.Offset);
                var distanceOne = Vector3.Distance(lHead, aHead);
                var distanceTwo = Vector3.Distance(lHead, bHead);
                var result = distanceOne > distanceTwo ? 1 : -1;
                Console.WriteLine(result);
                return result;
            });
            if (!User32Methods.GetAsyncKeyState(0x12).IsPressed) return;
            var closest = entityListAsList.FirstOrDefault();
            if (closest is not null)
            {
                Console.WriteLine("Aiming");
                Manager.AimAt(closest.GameSceneNode.GetBonePositionCached(Esp.BoneOffsets.Head.Offset));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void EntityLoop(EntityPawn pawn)
    {
    }
}