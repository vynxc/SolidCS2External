using System.Numerics;
using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class EntityPawn(Memory memory, IntPtr location)
{
    public GameSceneNode GameSceneNode = new(memory, memory.Read<nint>(location + C_BaseEntity.m_pGameSceneNode));
    public ExternalValue<int> Health = new(memory, location, C_BaseEntity.m_iHealth);
}

public struct GameSceneNode(Memory memory, IntPtr location)
{
    public ExternalValue<Vector3> Origin = new(memory, location,
        CGameSceneNode.m_vecAbsOrigin);
}