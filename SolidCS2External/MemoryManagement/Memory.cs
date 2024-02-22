using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SolidCS2External.MemoryManagement;

/// <summary>
///     Represents a class that manages memory operations for a specified process.
/// </summary>
public class Memory : Kernel32Memory, IDisposable
{
    /// <summary>
    ///     Represents a memory manager for accessing process memory.
    /// </summary>
    /// <remarks>
    ///     The <see cref="_handle" /> field stores the handle to the opened process.
    /// </remarks>
    private readonly IntPtr _handle;

    /// <summary>
    ///     Represents a class for managing memory of a process.
    /// </summary>
    private readonly Process _process;


    /// <summary>
    ///     Represents a class for interacting with the memory of a specified process.
    /// </summary>
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

    /// <summary>
    ///     Gets the base address of the main module of the process.
    /// </summary>
    /// <remarks>
    ///     The base address is the starting address of the main module in the process's virtual memory.
    /// </remarks>
    /// <value>
    ///     The base address of the main module, or null if the process's main module is not available.
    /// </value>
    public IntPtr? BaseAddress => _process.MainModule?.BaseAddress;

    /// <summary>
    ///     Disposes the Memory object, releasing any associated resources.
    /// </summary>
    public void Dispose()
    {
        _process.Dispose();
    }


    /// <summary>
    ///     Retrieves the base address of the specified module in the target process.
    /// </summary>
    /// <param name="moduleName">The name of the module to retrieve the address of.</param>
    /// <returns>
    ///     The base address of the specified module in the target process.
    /// </returns>
    public IntPtr GetModuleAddress(string moduleName)
    {
        foreach (ProcessModule module in _process.Modules)
            if (module.ModuleName == moduleName)
                return module.BaseAddress;
        throw new InvalidOperationException();
    }

    /// <summary>
    ///     Returns the <see cref="Process" /> instance associated with the given process name.
    /// </summary>
    /// <returns>The <see cref="Process" /> instance associated with the given process name.</returns>
    public Process GetProcess()
    {
        return _process;
    }

    /// <summary>
    ///     Reads a value of type T from the specified memory address.
    /// </summary>
    /// <typeparam name="T">The type of value to read.</typeparam>
    /// <param name="address">The memory address to read from.</param>
    /// <returns>The value read from the memory address.</returns>
    public unsafe T Read<T>(IntPtr address) where T : unmanaged
    {
        var bytes = ReadMemory(address, (uint)sizeof(T));
        return MemoryMarshal.Read<T>(bytes);
    }

    /// <summary>
    ///     Reads an array of elements from the specified memory address.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the array.</typeparam>
    /// <param name="address">The memory address to read from.</param>
    /// <param name="count">The number of elements to read.</param>
    /// <returns>An array of elements read from the memory address.</returns>
    public T[] ReadArray<T>(IntPtr address, int count) where T : struct
    {
        var size = Marshal.SizeOf(default(T));
        var bytes = ReadMemory(address, (uint)(count * size));
        return MemoryMarshal.Cast<byte, T>(bytes).ToArray();
    }

    /// <summary>
    ///     Writes data of type <typeparamref name="T" /> to the specified memory address.
    /// </summary>
    /// <typeparam name="T">The type of data to write</typeparam>
    /// <param name="address">The memory address to write the data to</param>
    /// <param name="data">The data to be written</param>
    /// <exception cref="InvalidOperationException">Thrown when the process module with the specified address is not found</exception>
    /// <exception cref="ArgumentNullException">Thrown when the data is null</exception>
    public unsafe void Write<T>(IntPtr address, T data) where T : unmanaged
    {
        var span = MemoryMarshal.CreateReadOnlySpan(ref data, 1);
        fixed (void* bufPtr = span)
        {
           // WriteProcessMemory(_handle, address, bufPtr, (uint)span.Length, out _);
        }
    }

    /// <summary>
    ///     Read memory from a specific address.
    /// </summary>
    /// <param name="address">The address to read from.</param>
    /// <param name="byteArrayLength">The length to read.</param>
    /// <returns>The data read from the given address.</returns>
    private Span<byte> ReadMemory(IntPtr address, uint byteArrayLength)
    {
        var buffer = new byte[byteArrayLength];
        ReadProcessMemory(_handle, address, buffer, byteArrayLength, out _);
        return buffer;
    }
}