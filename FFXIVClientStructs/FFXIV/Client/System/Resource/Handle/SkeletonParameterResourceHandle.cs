using FFXIVClientStructs.Havok.Common.Base.Math.Vector;

namespace FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

// Client::System::Resource::Handle::SkeletonParamResourceHandle
//   Client::System::Resource::Handle::DefaultResourceHandle
//     Client::System::Resource::Handle::ResourceHandle
//       Client::System::Common::NonCopyable
[GenerateInterop]
[Inherits<DefaultResourceHandle>]
[StructLayout(LayoutKind.Explicit, Size = 0x148)]
public unsafe partial struct SkeletonParamResourceHandle {
    // 0xC0: struct of size 0x20
    // 0xE0: struct of size 0x20
    // 0x100: struct of size 0x28
    // 0x128: struct of size 0x20

    //E0 some sort of flag, I think E0 and E1 are byte counters for how many objects the arrays have
    //E8 pointer to E1 bytes representing the # of elements in each group
    [FieldOffset(0xE0)] public byte ParameterCount;
    [FieldOffset(0xE1)] public byte GroupCount;
    [FieldOffset(0xE8)] public byte* GroupElementCount;
    [FieldOffset(0xF0)] public LookAtParam* Parameters;
    [FieldOffset(0xF8)] public LookAtGroup* Groups;

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct LookAtParam {
        [FieldOffset(0x00)] public hkVector4f ForwardLookAtVector;
        [FieldOffset(0x10)] public float ForwardRotationX;
        [FieldOffset(0x14)] public float ForwardRotationY;
        [FieldOffset(0x18)] public float ForwardRotationZ;
        [FieldOffset(0x1C)] public float LimitAngle;
        [FieldOffset(0x20)] public float EyePositionX;
        [FieldOffset(0x24)] public float EyePositionY;
        [FieldOffset(0x28)] public float EyePositionZ;
        [FieldOffset(0x2C)] public uint Flags;
        [FieldOffset(0x30)] public float Gain;
        [FieldOffset(0x34)] public uint Index;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public partial struct LookAtGroup {
        [FieldOffset(0x00), FixedSizeArray(isString: true)] internal FixedSizeArray8<byte> _groupId;
        [FieldOffset(0x20)] public byte ElementCount;
        [FieldOffset(0x28)] public LookAtElement* Elements;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x42)]
    public partial struct LookAtElement {
        [FieldOffset(0x00)] public byte Priority;
        [FieldOffset(0x01)] public byte SetupParameterIndex;
        [FieldOffset(0x02), FixedSizeArray(isString: true)] internal FixedSizeArray14<byte> _boneName;
        [FieldOffset(0x22), FixedSizeArray(isString: true)] internal FixedSizeArray14<byte> _parentBoneName;
    }
}
