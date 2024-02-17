using System.Collections.Concurrent;
using WinApi.User32;

namespace SolidCS2External.Game.Entity;

public class EntityManager
{
    private const int SleepTime = 40;
    public readonly ConcurrentBag<EntityPawn> ConcurrentBag = new();

    public EntityManager()
    {
        Task.Run(Update);
    }

    private void Update()
    {
        while (!User32Methods.GetAsyncKeyState(VirtualKey.INSERT).IsPressed) Thread.Sleep(SleepTime);
    }
}