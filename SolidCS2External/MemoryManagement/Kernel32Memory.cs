using System.Runtime.InteropServices;

namespace SolidCS2External.MemoryManagement;

// ReSharper disable InconsistentNaming
public abstract class Kernel32Memory
{
    [Flags]
    public enum ThreadAccess
    {
        TERMINATE = 0x0001,
        SUSPEND_RESUME = 0x0002,
        GET_CONTEXT = 0x0008,
        SET_CONTEXT = 0x0010,
        SET_INFORMATION = 0x0020,
        QUERY_INFORMATION = 0x0040,
        SET_THREAD_TOKEN = 0x0080,
        IMPERSONATE = 0x0100,
        DIRECT_IMPERSONATION = 0x0200
    }

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(uint dwDesiredAccess, uint bInheritHandle, uint dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer,
        uint dwLength);

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

    [DllImport("kernel32.dll")]
    public static extern uint SuspendThread(IntPtr hThread);

    [DllImport("kernel32.dll")]
    public static extern int ResumeThread(IntPtr hThread);

    [DllImport("kernel32.dll")]
    public static extern int CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer,
        uint size, out IntPtr lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer,
        uint size, out IntPtr lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    public static extern unsafe int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, void* buffer,
        uint size, out IntPtr lpNumberOfBytesWritten);

    [Flags]
    protected enum ProcessAccessType
    {
        PROCESS_TERMINATE = 0x0001,
        PROCESS_CREATE_THREAD = 0x0002,
        PROCESS_SET_SESSIONID = 0x0004,
        PROCESS_VM_OPERATION = 0x0008,
        PROCESS_VM_READ = 0x0010,
        PROCESS_VM_WRITE = 0x0020,
        PROCESS_DUP_HANDLE = 0x0040,
        PROCESS_CREATE_PROCESS = 0x0080,
        PROCESS_SET_QUOTA = 0x0100,
        PROCESS_SET_INFORMATION = 0x0200,
        PROCESS_QUERY_INFORMATION = 0x0400,
        PROCESS_QUERY_LIMITED_INFORMATION = 0x1000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public IntPtr RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

    public struct SYSTEM_INFO
    {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
        public ushort processorArchitecture;
        public ushort reserved;
        public uint pageSize;
        public IntPtr minimumApplicationAddress;
        public IntPtr maximumApplicationAddress;
        public IntPtr activeProcessorMask;
        public uint numberOfProcessors;
        public uint processorType;
        public uint allocationGranularity;
        public ushort processorLevel;
        public ushort processorRevision;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
    }
}