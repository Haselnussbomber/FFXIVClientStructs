using FFXIVClientStructs.FFXIV.Common.Component.Excel;

namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::EurekaManager
// Manager for Eureka
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe partial struct EurekaStoryProgressManager {
    [MemberFunction("E8 ?? ?? ?? ?? 48 8B C8 B2 1C")]
    public static partial EurekaStoryProgressManager* Instance();

    [FieldOffset(0x00)] public EurekaStoryProgressState* State;

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct EurekaStoryProgressState {
        [FieldOffset(0x01)] public byte ProgressRowId; // Index of ProgressRows array below
        [FieldOffset(0x04)] public uint Unk4;
        [FieldOffset(0x08)] public uint Unk8;

        [FieldOffset(0x20)] public ExcelSheetWaiter* ExcelSheetWaiter; // size: 0x50
        [FieldOffset(0x28)] public ExcelSheet* ExcelSheet; // EurekaStoryProgress
        [FieldOffset(0x30), FixedSizeArray] internal FixedSizeArray128<byte> _progressRows;
    }
}
