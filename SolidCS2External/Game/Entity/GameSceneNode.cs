using System.Numerics;
using System.Runtime.InteropServices;
using SolidCS2External.Game.Offsets;
using SolidCS2External.MemoryManagement;

namespace SolidCS2External.Game.Entity;

public class GameSceneNode(Memory memory, IntPtr location)
{
    public ModelState ModelState = new(memory, location + CS2Dumper.Schemas.ClientDll.CSkeletonInstance.m_modelState);

    public ExternalValue<Vector3> Origin = new(memory, location,
        CS2Dumper.Schemas.ClientDll.CGameSceneNode.m_vecAbsOrigin);
    
    public Vector3 GetBonePosition(int bone)
    {
        return memory.Read<Vector3>(ModelState.BoneArray.Value.GetValueOrDefault() + bone * 32);
    }

    private readonly Dictionary<int, Vector3> _boneMap = new();
    public Vector3 GetBonePositionCached(int bone)
    {
        ref var bonePos = ref CollectionsMarshal.GetValueRefOrAddDefault(_boneMap, bone, out var exists);
        
        if (!exists)
            bonePos = GetBonePosition(bone);

        return bonePos;
    }

    public void ClearBonePositionCache()
    {
        _boneMap.Clear();
    }
}