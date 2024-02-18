using System.Runtime.InteropServices;
using SolidCS2External.Game.Offsets;

namespace SolidCS2External.Game.Entity;

public class EntityPawn(Memory.Memory memory)
{
    public ExternalValue<int> Health = new(memory, 0x0, 0x1);
}