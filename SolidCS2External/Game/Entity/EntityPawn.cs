using System.ComponentModel;
using System.Numerics;
using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class EntityPawn(Memory memory, IntPtr location)
{
    [Description("Location of the entity in memory.")]
    public readonly IntPtr Location = location;

    public GameSceneNode GameSceneNode = new(memory, memory.Read<nint>(location + C_BaseEntity.m_pGameSceneNode));
    public ExternalValue<int> Health = new(memory, location, C_BaseEntity.m_iHealth);
}

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

public class ModelState(Memory memory, IntPtr location)
{
    public ExternalValue<IntPtr> BoneArray = new(memory, location, 0x80);
}