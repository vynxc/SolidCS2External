using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class ModelState(Memory memory, IntPtr location)
{
    public ExternalValue<IntPtr> BoneArray = new(memory, location, 0x80);
}