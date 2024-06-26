namespace FFXIVClientStructs.Havok.Common.Base.Object;

[GenerateInterop(isInherited: true)]
[Inherits<hkBaseObject>]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public partial struct hkReferencedObject {
    [FieldOffset(0x8)] public uint MemSizeAndRefCount;
    // private uint Padding;

    [MemberFunction("E8 ?? ?? ?? ?? 48 89 77 18 4C 8D 9C 24 ?? ?? ?? ??")]
    public partial void RemoveReference();
}
