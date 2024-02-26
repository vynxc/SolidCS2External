using System.Numerics;
using Serilog;
using SolidCS2External.Game.Entity;
using SolidCS2External.ImGuiRendering;
using SolidCS2External.MemoryManagement;
using WinApi.User32;

namespace SolidCS2External.Game;

public class Cs2Manager
{
    private readonly int _windowHeight;
    private readonly int _windowWidth;
    public readonly IntPtr ClientDll;
    public readonly Memory Memory = new("cs2");
    private float[]? _viewMatrix;
    public EntityList EntityListFrontBuffer;
    public EntityManager EntityManager;
    public EntityPawn? LocalPlayer;
    public ApplicationRenderer Renderer;
    // Although checking if the logger should log at a min level
    // is a simple if statement that comes first before anything else,
    // if there is a noticeable and unwanted slowdown then just
    // remove the logger from the hot paths
    private ILogger _logger;

    public Cs2Manager(ApplicationRenderer renderer, ILogger logger)
    {
        ClientDll = Memory.GetModuleAddress("client.dll");
        EntityManager = new EntityManager(this);
        _windowWidth = renderer.Size.Width;
        _windowHeight = renderer.Size.Height;
        GlobalManager = this;
        Renderer = renderer;
        EntityListFrontBuffer = EntityManager.CreateEntityListBuffer();
        _logger = logger;
    }

    public static Cs2Manager GlobalManager { get; private set; } = null!;

    public void Update()
    {
        _viewMatrix ??= new float[16];
        Memory.Read(ClientDll + client_dll.dwViewMatrix, _viewMatrix.AsSpan());
        
        _logger.Verbose("Updated view matrix");

        if (User32Methods.GetAsyncKeyState(VirtualKey.INSERT).IsPressed) SetViewAngles(new Vector3(0, 0, 0));
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public void SetViewAngles(Vector3 angles)
    {
        Memory.Write(ClientDll + client_dll.dwViewAngles, angles);
        _logger.Verbose("View angles set");
    }

    public Vector3 GetViewAngles()
    {
        var viewAngles = Memory.Read<Vector3>(ClientDll + client_dll.dwViewAngles);
        _logger.Verbose("View angles loaded");
        
        return viewAngles;
    }

    public void AimAt(Vector3 target)
    {
        const float smoothingFactor = 1;
        if (LocalPlayer is null) return;
        var origin = LocalPlayer.GameSceneNode.Origin.Value.GetValueOrDefault();
        if (origin == Vector3.Zero) return;
        var viewOffset = LocalPlayer.ViewOffset.Value.GetValueOrDefault();
        var myPos = origin + viewOffset;
        var deltaVec = target - myPos;
        var deltaVecLength = Math.Sqrt(deltaVec.X * deltaVec.X + deltaVec.Y * deltaVec.Y + deltaVec.Z * deltaVec.Z);
        var pitch = (float)-Math.Asin(deltaVec.Z / deltaVecLength) * (180 / (float)Math.PI);
        var yaw = (float)Math.Atan2(deltaVec.Y, deltaVec.X) * (180 / (float)Math.PI);
        if (!(pitch >= -89) || !(pitch <= 89) || !(yaw >= -180) || !(yaw <= 180)) return;
        var currentViewAngle = GetViewAngles();
        var newPitch = currentViewAngle.X + smoothingFactor * (pitch - currentViewAngle.X);
        var newYaw = currentViewAngle.Y + smoothingFactor * (yaw - currentViewAngle.Y);
        var currentAngles = new Vector3(
            newPitch,
            newYaw,
            0);

        SetViewAngles(currentAngles);
        
        _logger.Verbose("Aimed at target");
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

        // Inlining it all may be slightly faster and help the jitter out
        // return v2Wnd / v22 * v2Ndc * new Vector2(1, -1) + (v2Ndc + v2Wnd / v22);
    }
}