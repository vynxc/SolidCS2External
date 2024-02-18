using System.Collections.Concurrent;
using SolidCS2External.Game.Offsets;
using WinApi.User32;

namespace SolidCS2External.Game.Entity;

public class EntityManager
{
    private const int SleepTime = 40;
    private readonly IntPtr _clientDll;


    private readonly Memory.Memory _memory = new("cs2");
    public readonly ConcurrentBag<EntityPawn> ConcurrentBag = new();

    public EntityManager()
    {
        _clientDll = _memory.GetModuleAddress("client.dll");
        Task.Run(Update);
    }

    private void Update()
    {
        while (!User32Methods.GetAsyncKeyState(VirtualKey.INSERT).IsPressed)
        {
            var localPlayer = _memory.Read<IntPtr>(_clientDll + client_dll.dwLocalPlayerPawn);
            Console.WriteLine($"LocalPlayer: {localPlayer}");
            Thread.Sleep(SleepTime);
        }
    }
}