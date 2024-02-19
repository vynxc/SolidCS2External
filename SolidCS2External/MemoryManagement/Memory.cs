using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SolidCS2External.MemoryManagement;

public class Memory : Kernel32Memory, IDisposable
{
    private readonly IntPtr _handle;
    private readonly Process _process;


    public Memory(string processName)
    {
        _process = Process.GetProcessesByName(processName).FirstOrDefault() ??
                   throw new Exception(
                       "Process not found. Make sure the game is running and processName is correct.");
        var access = ProcessAccessType.PROCESS_QUERY_INFORMATION |
                     ProcessAccessType.PROCESS_VM_READ |
                     ProcessAccessType.PROCESS_VM_WRITE |
                     ProcessAccessType.PROCESS_VM_OPERATION;

        _handle = OpenProcess((uint)access, 1, (uint)_process.Id);
    }

    public IntPtr? BaseAddress => _process.MainModule?.BaseAddress;

    public void Dispose()
    {
        _process.Dispose();
    }


    public IntPtr GetModuleAddress(string moduleName)
    {
        foreach (ProcessModule module in _process.Modules)
            if (module.ModuleName == moduleName)
                return module.BaseAddress;
        throw new InvalidOperationException();
    }

    public Process GetProcess()
    {
        return _process;
    }

    public T Read<T>(IntPtr address)
    {
        var size = Marshal.SizeOf(default(T));
        var bytes = ReadMemory(address, (uint)size);
        var ptr = Marshal.AllocHGlobal(size);
        Marshal.Copy(bytes, 0, ptr, size);
        var toReturn = (T)(Marshal.PtrToStructure(ptr, typeof(T)) ?? throw new InvalidOperationException());
        Marshal.FreeHGlobal(ptr);
        return toReturn;
    }

    public T[] ReadArray<T>(IntPtr address, int count)
    {
        var size = Marshal.SizeOf(default(T));
        var bytes = ReadMemory(address, (uint)(count * size));
        var toReturn = new T[count];
        var ptr = Marshal.AllocHGlobal(size);

        for (var i = 0; i < count; i++)
        {
            Marshal.Copy(bytes, i * size, ptr, size);
            toReturn[i] = (T)(Marshal.PtrToStructure(ptr, typeof(T)) ?? throw new InvalidOperationException());
        }

        Marshal.FreeHGlobal(ptr);
        return toReturn;
    }

    public void Write<T>(IntPtr address, T data) where T : notnull
    {
        var size = Marshal.SizeOf(data);
        var bytes = new byte[size];
        var ptr = Marshal.AllocHGlobal(size);
        Marshal.StructureToPtr(data, ptr, false);
        Marshal.Copy(ptr, bytes, 0, size);
        Marshal.FreeHGlobal(ptr);
        WriteMemory(address, bytes);
    }

    public byte[] ReadMemory(IntPtr address, uint byteArrayLength)
    {
        var buffer = new byte[byteArrayLength];
        ReadProcessMemory(_handle, address, buffer, byteArrayLength, out _);
        return buffer;
    }

    private void WriteMemory(IntPtr address, byte[] data)
    {
        WriteProcessMemory(_handle, address, data, (uint)data.Length, out _);
    }

    public float[] BytesToFloatArray(byte[] bytes)
    {
        var floats = new float[bytes.Length / 4];
        for (var i = 0; i < bytes.Length; i += 4)
            floats[i / 4] = BitConverter.ToSingle(bytes, i);
        return floats;
    }
}