using System.Runtime.InteropServices;

namespace SolidCS2External.Game.Entity;

[StructLayout(LayoutKind.Explicit)]
public struct EntityPawn
{
    [FieldOffset(0x334)] public int Health;
}