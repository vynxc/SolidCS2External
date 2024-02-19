using System.Collections.Concurrent;
using WinApi.User32;

namespace SolidCS2External.Game.Entity;

public class EntityManager
{
    private readonly Cs2Manager _cs2Manager;
    private readonly List<EntityPawn> _temp = new();


    public EntityManager(Cs2Manager manager)
    {
        _cs2Manager = manager;
        Task.Run(Update);
    }

    private void Update()
    {
        while (!User32Methods.GetAsyncKeyState(VirtualKey.INSERT).IsPressed)
            try
            {
                var localPlayer = _cs2Manager.Memory.Read<IntPtr>(_cs2Manager.ClientDll + client_dll.dwLocalPlayerPawn);
                if (localPlayer is not 0) _cs2Manager.LocalPlayer = new EntityPawn(_cs2Manager.Memory, localPlayer);

                var tempEntityAddress =
                    _cs2Manager.Memory.Read<IntPtr>(_cs2Manager.ClientDll + client_dll.dwEntityList);
                if (tempEntityAddress is 0) return;
                _temp.Clear();
                for (var i = 0; i < 64; i++)
                {
                    var listEntry =
                        _cs2Manager.Memory.Read<IntPtr>(tempEntityAddress + (((8 * (i & 0x7FFF)) >> 9) + 16));
                    if (listEntry is 0) continue;

                    var player = _cs2Manager.Memory.Read<IntPtr>(listEntry + 120 * (i & 0x1FF));
                    if (player is 0) continue;

                    var playerPawn = _cs2Manager.Memory.Read<IntPtr>(player + CCSPlayerController.m_hPlayerPawn);
                    if (playerPawn is 0) continue;

                    var listEntry2 =
                        _cs2Manager.Memory.Read<IntPtr>(tempEntityAddress + 0x8 * ((playerPawn & 0x7FFF) >> 9) + 16);
                    if (listEntry2 is 0) continue;

                    var pCsPlayerPawn = _cs2Manager.Memory.Read<IntPtr>(listEntry2 + 120 * (playerPawn & 0x1FF));
                    if (pCsPlayerPawn is 0) continue;

                    if (pCsPlayerPawn == _cs2Manager.LocalPlayer?.Location) continue;

                    var entityPawn = new EntityPawn(_cs2Manager.Memory, pCsPlayerPawn);
                    if (entityPawn.Health.Value.GetValueOrDefault() <= 0) continue;
                    _temp.Add(entityPawn);
                }

                lock (_cs2Manager.EntityListLock)
                {
                    _cs2Manager.EntityList = new ConcurrentBag<EntityPawn>(_temp);
                }

                _cs2Manager.Update();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        Console.WriteLine("Exiting EntityManager");
    }
}