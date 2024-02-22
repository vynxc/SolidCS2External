using System.Numerics;
using BenchmarkDotNet.Attributes;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Benchmarks;

public class MemoryBenchmark
{
    private readonly Vector3 _angles = new();
    private readonly nint _clientDll;
    private readonly Memory _memory = new("cs2");

    public MemoryBenchmark()
    {
        _clientDll = _memory.GetModuleAddress("client.dll");
    }

    [Benchmark]
    public void WriteRegular()
    {
        _memory.Write(_clientDll + client_dll.dwViewAngles, _angles);
    }

    [Benchmark]
    public void WriteMarshal()
    {
        _memory.WriteWithMarshal(_clientDll + client_dll.dwViewAngles, _angles);
    }
}