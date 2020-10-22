﻿using System.Runtime.InteropServices;

namespace FFXIVClientStructs.Component.GUI
{
    // Component::GUI::AtkCollisionNode
    //   Component::GUI::AtkResNode
    //     Component::GUI::AtkEventTarget

    // size = 0xB8
    // common CreateAtkNode function E8 ? ? ? ? 48 8B 4E 08 49 8B D5 
    // type 8
    [StructLayout(LayoutKind.Explicit, Size = 0xB8)]
    public unsafe struct AtkCollisionNode
    {
        [FieldOffset(0x0)] public AtkResNode AtkResNode;
    }
}
