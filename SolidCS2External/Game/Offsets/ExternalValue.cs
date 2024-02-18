using System.Numerics;

namespace SolidCS2External.Game.Offsets;

public struct ExternalValue<T> where T : unmanaged
{
    private readonly nint _address;
    public T? Value { get; private set; }

    public ExternalValue(Memory.Memory memory, params nint[] baseAndOffsets)
    {
        _address = baseAndOffsets[0];
        foreach (var offset in baseAndOffsets.Skip(1).SkipLast(1))
        {
            _address = memory.Read<nint>(_address + offset);
        }

        _address += baseAndOffsets[^1];
    }

    public void Update(Memory.Memory memory)
    {
        Value = memory.Read<T>(_address);
    }

    public T UpdateAndGet(Memory.Memory memory)
    {
        Update(memory);
        return Value!.Value;
    }
}