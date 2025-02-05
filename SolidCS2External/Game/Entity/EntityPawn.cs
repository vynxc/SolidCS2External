using System.ComponentModel;
using System.Numerics;
using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class EntityPawn(Memory memory, IntPtr location)
{
    public readonly GameSceneNode GameSceneNode =
        new(memory, memory.Read<nint>(location + CS2Dumper.Schemas.ClientDll.C_BaseEntity.m_pGameSceneNode));

    [Description("Location of the entity in memory.")]
    public readonly IntPtr Location = location;

    public readonly ExternalValue<Vector3> ViewOffset = new(memory, location, CS2Dumper.Schemas.ClientDll.C_BaseModelEntity.m_vecViewOffset);
    public ExternalValue<int> Health = new(memory, location, CS2Dumper.Schemas.ClientDll.C_BaseEntity.m_iHealth);
}