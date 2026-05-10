using FFXIVClientStructs.FFXIV.Common.Math;
using FFXIVClientStructs.Havok.Common.Base.Math.Vector;

namespace FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

[GenerateInterop]
[Inherits<DefaultResourceHandle>]
[StructLayout(LayoutKind.Explicit, Size = 0x148)]
public unsafe partial struct SkeletonParameterResourceHandle  {

    //E0 some sort of flag, I think E0 and E1 are byte counters for how many objects the arrays have
    //E8 pointer to E1 bytes representing the # of elements in each group
    [FieldOffset(0xE0)] public byte ParameterCount;
    [FieldOffset(0xE1)] public byte GroupCount;
    [FieldOffset(0xE8)] public byte* GroupElementCount;
    [FieldOffset(0xF0)] public LookAtParam* Parameters;
    [FieldOffset(0xF8)] public Group* Groups;




    [StructLayout(LayoutKind.Sequential, Size = 0x56)]
    public struct LookAtParam {
        public hkVector4f m_fwdLS;
        public Vector3 ForwardRotation;
        public float Limit_Angle;
        public Vector3 Eye_positions;
        public Int32 Flags;
        public float Gain;
        public uint Index;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct Group {
        [FieldOffset(0x00), FixedSizeArray(isString: true)] internal FixedSizeArray8<byte> _groupId; //char[8]
        [FieldOffset(0x20)] public Byte ElementCount;
        [FieldOffset(0x28)] public Element* Elements;
    }

    //written in +1784EF0 
    [StructLayout(LayoutKind.Explicit, Size = 0x42)]
    public struct Element {
        [FieldOffset(0x00)] public byte Priority;
        [FieldOffset(0x01)] public byte SetupParameterIndex;
        [FieldOffset(0x02)] public StdString BoneName;
        [FieldOffset(0x22)] public StdString ParentBoneName;
    }
    
}

