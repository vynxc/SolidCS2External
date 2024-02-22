using System.Collections.Concurrent;

namespace SolidCS2External.Game.Entity;

public class EntityManager
{
    public const int MaxEntityCount = 64;
    
    private readonly Cs2Manager _cs2Manager;
    private EntityList _entityListBackBuffer = CreateEntityListBuffer();

    public EntityManager(Cs2Manager manager)
    {
        _cs2Manager = manager;
        Task.Run(Update);
    }

    public static EntityList CreateEntityListBuffer()
        => new(new EntityPawn?[MaxEntityCount], new object());

    private void Update()
    {
        while (true)
            try
            {
                var localPlayer = _cs2Manager.Memory.Read<IntPtr>(_cs2Manager.ClientDll + client_dll.dwLocalPlayerPawn);
                if (localPlayer is not 0) _cs2Manager.LocalPlayer = new EntityPawn(_cs2Manager.Memory, localPlayer);

                var tempEntityAddress =
                    _cs2Manager.Memory.Read<IntPtr>(_cs2Manager.ClientDll + client_dll.dwEntityList);
                
                var i = 0;
                if (tempEntityAddress is 0)
                {
                    Array.Fill(_entityListBackBuffer.Buffer, null);
                    i = MaxEntityCount;
                }
                
                for (; i < MaxEntityCount; i++)
                {
                    var listEntry =
                        _cs2Manager.Memory.Read<IntPtr>(tempEntityAddress + (((8 * (i & 0x7FFF)) >> 9) + 16));
                    if (listEntry is 0) goto Failed;

                    var player = _cs2Manager.Memory.Read<IntPtr>(listEntry + 120 * (i & 0x1FF));
                    if (player is 0) goto Failed;

                    var playerPawn = _cs2Manager.Memory.Read<IntPtr>(player + CCSPlayerController.m_hPlayerPawn);
                    if (playerPawn is 0) goto Failed;

                    var listEntry2 =
                        _cs2Manager.Memory.Read<IntPtr>(tempEntityAddress + 0x8 * ((playerPawn & 0x7FFF) >> 9) + 16);
                    if (listEntry2 is 0) goto Failed;

                    var pCsPlayerPawn = _cs2Manager.Memory.Read<IntPtr>(listEntry2 + 120 * (playerPawn & 0x1FF));
                    if (pCsPlayerPawn is 0) goto Failed;

                    if (pCsPlayerPawn == _cs2Manager.LocalPlayer?.Location) goto Failed;

                    var entityPawn = new EntityPawn(_cs2Manager.Memory, pCsPlayerPawn);
                    if (entityPawn.Health.Value.GetValueOrDefault() <= 0) goto Failed;
                    
                    _entityListBackBuffer.Buffer[i]= entityPawn;
                    continue;
                    
                    Failed:
                    _entityListBackBuffer.Buffer[i] = null;
                }

                SwapEntityListBuffers();

                _cs2Manager.Update();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        Console.WriteLine("Exiting EntityManager");
    }

    private void SwapEntityListBuffers()
    {
        lock (_cs2Manager.EntityListFrontBuffer.Lock)
        {
            (_cs2Manager.EntityListFrontBuffer, _entityListBackBuffer) =
                (_entityListBackBuffer, _cs2Manager.EntityListFrontBuffer);
        }
    }
}