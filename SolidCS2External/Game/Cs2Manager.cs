using System.Collections.Concurrent;
using System.Numerics;
using SolidCS2External.Game.Entity;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game;

public class Cs2Manager
{
    private readonly int _windowHeight;
    private readonly int _windowWidth;
    public readonly IntPtr ClientDll;
    public readonly object EntityListLock = new();
    public readonly Memory Memory = new("cs2");
    private float[]? _viewMatrix;
    public ConcurrentBag<EntityPawn> EntityList = new();
    public EntityManager EntityManager;
    public EntityPawn? LocalPlayer;

    public Cs2Manager()

    {
        ClientDll = Memory.GetModuleAddress("client.dll");
        EntityManager = new EntityManager(this);
        //TODO: Get window size
        _windowWidth = 3440;
        _windowHeight = 1440;
    }

    public void Update()
    {
        _viewMatrix = Memory.ReadArray<float>(ClientDll + client_dll.dwViewMatrix, 16);
        /*var viewMatrixPtr = new ReadOnlySpan<float>(floatPtr, 16);
        ViewMatrixPtr = viewMatrixPtr.ToArray();
        Console.WriteLine(ViewMatrixPtr[0] + " " + ViewMatrixPtr[1] + " " + ViewMatrixPtr[2] + " " + ViewMatrixPtr[3]);*/
    }

    public Vector2? WorldToScreen(Vector3 pos)
    {
        if (_viewMatrix is null)
            return null;
        var vx = new Vector4(pos.X);
        var v1 = new Vector4(_viewMatrix[0], _viewMatrix[4], _viewMatrix[8], _viewMatrix[12]);
        var vy = new Vector4(pos.Y);
        var v2 = new Vector4(_viewMatrix[1], _viewMatrix[5], _viewMatrix[9], _viewMatrix[13]);
        var vz = new Vector4(pos.Z);
        var v3 = new Vector4(_viewMatrix[2], _viewMatrix[6], _viewMatrix[10], _viewMatrix[14]);
        var v4 = new Vector4(_viewMatrix[3], _viewMatrix[7], _viewMatrix[11], _viewMatrix[15]);

        var clipCoords = vx * v1 + vy * v2 + vz * v3 + v4;

        if (clipCoords.W < 0.01f)
            return null;

        var v2Ndc = new Vector2(clipCoords.X, clipCoords.Y);
        v2Ndc /= clipCoords.W;

        var v2Wnd = new Vector2(_windowWidth, _windowHeight);
        var v22 = new Vector2(2);
        var screen = v2Wnd / v22 * v2Ndc;
        screen *= new Vector2(1, -1);
        screen += v2Ndc + v2Wnd / v22;

        return screen;
    }
}