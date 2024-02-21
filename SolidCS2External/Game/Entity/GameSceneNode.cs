using System.Numerics;
using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class GameSceneNode(Memory memory, IntPtr location)
{
    public ModelState ModelState = new(memory, location + CSkeletonInstance.m_modelState);

    public ExternalValue<Vector3> Origin = new(memory, location,
        CGameSceneNode.m_vecAbsOrigin);
    
    public Vector3 GetBonePosition(int bone)
    {
        return memory.Read<Vector3>(ModelState.BoneArray.Value.GetValueOrDefault() + bone * 32);
    }
}