namespace FFXIVClientStructs.FFXIV.Client.Game.Event;

// Client::Game::Event::EventSceneModuleTaskManager
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe partial struct EventSceneModuleTaskManager {
    [FieldOffset(0x00)] public StdVector<Pointer<EventSceneTaskInterface>> Tasks;
    [FieldOffset(0x18)] public StdVector<Pointer<EventSceneTaskInterface>> GroupPoseTasks;

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 56 57 41 56 48 83 EC 20 48 8B 2D"), Obsolete("This function was inlined in 7.0 and the signature is no longer valid", true)]
    public partial void ProcessTasks();

    [MemberFunction("E8 ?? ?? ?? ?? EB 2E 48 85 C0")]
    public partial void AddTask(EventSceneTaskInterface* task);

    [MemberFunction("48 89 5C 24 ?? 48 89 54 24 ?? 57 48 83 EC 20 48 8B 02")]
    public partial void AddGroupPoseTask(EventSceneTaskInterface* task);
}
