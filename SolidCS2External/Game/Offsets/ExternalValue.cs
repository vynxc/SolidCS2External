using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Offsets;

public struct ExternalValue<T> where T : unmanaged
{
    private readonly nint _address;
    public T? Value { get; private set; }

    private readonly Memory _memory;

    public ExternalValue(Memory memory, params nint[] baseAndOffsets)
    {
        _memory = memory;
        _address = baseAndOffsets[0];
        foreach (var offset in baseAndOffsets.Skip(1).SkipLast(1)) _address = memory.Read<nint>(_address + offset);

        _address += baseAndOffsets[^1];

        Update();
    }

    public void Update()
    {
        Value = _memory.Read<T>(_address);
    }

    public void Write(T value)
    {
        _memory.Write(_address, value);
    }
}