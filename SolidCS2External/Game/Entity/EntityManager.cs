using System.Collections.Concurrent;
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

    private unsafe void Update()
    {
        while (!User32Methods.GetAsyncKeyState(VirtualKey.INSERT).IsPressed)
        {
            /*var localPlayer = _memory.Read<IntPtr>(_clientDll + client_dll.dwLocalPlayerPawn + 12);
            if (localPlayer is 0) return;*/

            var tempEntityAddress = _memory.Read<IntPtr>(_clientDll + client_dll.dwEntityList);
            if (tempEntityAddress is 0) return;
            ConcurrentBag.Clear();
            for (var i = 0; i < 32; i++)
            {
                var listEntry = _memory.Read<IntPtr>(tempEntityAddress + (((8 * (i & 0x7FFF)) >> 9) + 16));
                if (listEntry is 0) continue;
                var player = _memory.Read<IntPtr>(listEntry + 120 * (i & 0x1FF));
                if (player is 0) continue;
                var playerPawn = _memory.Read<IntPtr>(player + CCSPlayerController.m_hPlayerPawn);
                if (playerPawn is 0) continue;
                var listEntry2 = _memory.Read<IntPtr>(tempEntityAddress + 0x8 * ((playerPawn & 0x7FFF) >> 9) + 16);
                if (listEntry2 is 0) continue;
                var pCsPlayerPawn = _memory.Read<IntPtr>(listEntry2 + 120 * (playerPawn & 0x1FF));
                if (pCsPlayerPawn is 0) continue;
                var entityPawn = _memory.Read<EntityPawn>(pCsPlayerPawn);
                ConcurrentBag.Add(entityPawn);
                Console.WriteLine("Health: " + entityPawn.Health);
                Console.WriteLine("ConcurrentBag: " + ConcurrentBag.Count);
                
            }

            Thread.Sleep(SleepTime);
        }

        Console.WriteLine("Exiting EntityManager");
    }
}