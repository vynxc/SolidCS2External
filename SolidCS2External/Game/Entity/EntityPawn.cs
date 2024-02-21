using System.ComponentModel;
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