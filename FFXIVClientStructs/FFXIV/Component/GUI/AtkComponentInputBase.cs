using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkComponentInputBase
//   Component::GUI::AtkComponentBase
//     Component::GUI::AtkEventListener
// ctor "E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 48 C7 86 ?? ?? ?? ?? ?? ?? ?? ?? 48 89 06"
[GenerateInterop(isInherited: true)]
[Inherits<AtkComponentBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x1E0)]
public unsafe partial struct AtkComponentInputBase {
    [FieldOffset(0xC8)] public AtkTextNode* AtkTextNode;
    [FieldOffset(0xD0)] public AtkResNode* CursorContainer;
    [FieldOffset(0xE0)] public Utf8String UnkText1;
    [FieldOffset(0x148)] public Utf8String UnkText2;
    [FieldOffset(0x1B0)] public AtkUnitBase* ContainingAddon;
    [FieldOffset(0x1D0)] public AtkUldComponentDataInputBase InputDataBase;
    [FieldOffset(0x1C4)] public int SelectionStart;
    [FieldOffset(0x1C8)] public int SelectionEnd;
    [FieldOffset(0x1CC)] public int CursorPos;
}
