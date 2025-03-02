// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

/// <summary>
/// ConfigOption indexes for use with ConfigModule.
/// This enum will be incorrect after any patch that adds or removes any config options.
/// </summary>
public enum ConfigOption : short {
    Invalid = -1,
    None = 0,

    #region System
    // <FINAL FANTASY XIV Config File>
    // <Version>
    GuidVersion = 2,
    ConfigVersion = 3,
    Language = 4,
    Region = 5,
    // <Network Settings>
    UPnP = 7,
    Port = 8,
    LastLogin0 = 9,
    LastLogin1 = 10,
    WorldId = 11,
    ServiceIndex = 12,
    DktSessionId = 13,
    // <Display Settings>
    MainAdapter = 15,
    ScreenLeft = 16,
    ScreenTop = 17,
    ScreenWidth = 18,
    ScreenHeight = 19,
    ScreenMode = 20,
    FullScreenWidth = 21,
    FullScreenHeight = 22,
    Refreshrate = 23,
    Fps = 24,
    AntiAliasing = 25,
    FPSInActive = 26,
    ResoMouseDrag = 27,
    MouseOpeLimit = 28,
    LangSelectSub = 29,
    Gamma = 30,
    UiBaseScale = 31,
    CharaLight = 32,
    UiHighScale = 33,
    // <Graphics Settings>
    TextureFilterQuality = 35,
    TextureAnisotropicQuality = 36,
    SSAO = 37,
    Glare = 38,
    DistortionWater = 39,
    DepthOfField = 40,
    RadialBlur = 42,
    Vignetting = 43,
    GrassQuality = 44,
    TranslucentQuality = 45,
    ShadowVisibilityType = 46,
    ShadowSoftShadowType = 47,
    ShadowTextureSizeType = 48,
    ShadowCascadeCountType = 49,
    LodType = 50,
    StreamingType = 51,
    GeneralQuality = 52,
    OcclusionCulling = 53,
    ShadowLOD = 54,
    PhysicsType = 59,
    MapResolution = 60,
    ShadowVisibilityTypeSelf = 61,
    ShadowVisibilityTypeParty = 62,
    ShadowVisibilityTypeOther = 63,
    ShadowVisibilityTypeEnemy = 64,
    PhysicsTypeSelf = 65,
    PhysicsTypeParty = 66,
    PhysicsTypeOther = 67,
    PhysicsTypeEnemy = 68,
    ReflectionType = 69,
    ScreenShotImageType = 70,
    // <Sound Settings>
    IsSoundDisable = 72,
    IsSoundAlways = 73,
    IsSoundBgmAlways = 74,
    IsSoundSeAlways = 75,
    IsSoundVoiceAlways = 76,
    IsSoundSystemAlways = 77,
    IsSoundEnvAlways = 78,
    IsSoundPerformAlways = 79,
    // <Font Settings>
    // <GamePad Settings>
    PadGuid = 82,
    InstanceGuid = 83,
    ProductGuid = 84,
    DeadArea = 85,
    Alias = 86,
    AlwaysInput = 87,
    ForceFeedBack = 88,
    PadPovInput = 89,
    PadMode = 90,
    PadAvailable = 91,
    PadReverseConfirmCancel = 92,
    PadSelectButtonIcon = 93,
    PadMouseMode = 94,
    TextPasteEnable = 95,
    EnablePsFunction = 96,
    ActiveInstanceGuid = 97,
    ActiveProductGuid = 98,
    WaterWet = 99,
    DisplayObjectLimitType = 100,
    WindowDispNum = 101,
    ScreenShotDir = 102,
    // <Graphics Settings DX11>
    AntiAliasing_DX11 = 104,
    TextureFilterQuality_DX11 = 105,
    TextureAnisotropicQuality_DX11 = 106,
    SSAO_DX11 = 107,
    Glare_DX11 = 108,
    DistortionWater_DX11 = 109,
    DepthOfField_DX11 = 110,
    RadialBlur_DX11 = 111,
    Vignetting_DX11 = 112,
    GrassQuality_DX11 = 113,
    TranslucentQuality_DX11 = 114,
    ShadowSoftShadowType_DX11 = 115,
    ShadowTextureSizeType_DX11 = 116,
    ShadowCascadeCountType_DX11 = 117,
    LodType_DX11 = 118,
    OcclusionCulling_DX11 = 119,
    ShadowLOD_DX11 = 120,
    MapResolution_DX11 = 121,
    ShadowVisibilityTypeSelf_DX11 = 122,
    ShadowVisibilityTypeParty_DX11 = 123,
    ShadowVisibilityTypeOther_DX11 = 124,
    ShadowVisibilityTypeEnemy_DX11 = 125,
    PhysicsTypeSelf_DX11 = 126,
    PhysicsTypeParty_DX11 = 127,
    PhysicsTypeOther_DX11 = 128,
    PhysicsTypeEnemy_DX11 = 129,
    ReflectionType_DX11 = 130,
    WaterWet_DX11 = 131,
    ParallaxOcclusion_DX11 = 132,
    Tessellation_DX11 = 133,
    GlareRepresentation_DX11 = 134,
    DynamicRezoThreshold = 135,
    GraphicsRezoScale = 136,
    GraphicsRezoUpscaleType = 137,
    GrassEnableDynamicInterference = 138,
    ShadowBgLOD = 139,
    TextureRezoType = 140,
    ShadowLightValidType = 141,
    DynamicRezoEnableCutScene = 142,
    UiSystemEnlarge = 143,
    SoundPadSeType = 144,
    SoundPad = 145,
    IsSoundPad = 146,
    TouchPadMouse = 147,
    TouchPadCursorSpeed = 148,
    TouchPadButtonExtension = 149,
    TouchPadButton_Left = 150,
    TouchPadButton_Right = 151,
    RemotePlayRearTouchpadEnable = 152,
    SupportButtonAutorunEnable = 153,
    R3ButtonWindowScalingEnable = 154,
    AutoAfkSwitchingTime = 155,
    AutoChangeCameraMode = 156,
    MsqProgress = 157,
    PromptConfigUpdate = 158,
    TitleScreenType = 159,
    AccessibilitySoundVisualEnable = 160,
    AccessibilitySoundVisualDispSize = 161,
    AccessibilitySoundVisualPermeabilityRate = 162,
    AccessibilityColorBlindFilterEnable = 163,
    AccessibilityColorBlindFilterType = 164,
    AccessibilityColorBlindFilterStrength = 165,
    // <Mouse Settings>
    MouseAutoFocus = 167,
    // <UI Settings>
    FPSDownAFK = 169,
    IdlingCameraAFK = 170,
    FirstConfigBackup = 171,
    MouseSpeed = 192,
    CameraZoom = 214,
    DynamicRezoType = 329,
    // <Move Operation>
    Is3DAudio = 339,
    BattleEffect = 341,
    BGEffect = 342,
    ColorThemeType = 750,
    SystemMouseOperationSoftOn = 839,
    SystemMouseOperationTrajectory = 840,
    SystemMouseOperationCursorScaling = 841,
    HardwareCursorSize = 842,
    UiAssetType = 843,
    FellowshipShowNewNotice = 864,
    // <Cutscene Settings>
    CutsceneMovieVoice = 882,
    CutsceneMovieCaption = 883,
    CutsceneMovieOpening = 884,
    // <SoundPlay Settings>
    SoundMaster = 887,
    SoundBgm = 888,
    SoundSe = 889,
    SoundVoice = 890,
    SoundEnv = 891,
    SoundSystem = 892,
    SoundPerform = 893,
    SoundPlayer = 894,
    SoundParty = 895,
    SoundOther = 896,
    IsSndMaster = 897,
    IsSndBgm = 898,
    IsSndSe = 899,
    IsSndVoice = 900,
    IsSndEnv = 901,
    IsSndSystem = 902,
    IsSndPerform = 903,
    SoundDolby = 904,
    SoundMicpos = 905,
    SoundChocobo = 906,
    SoundFieldBattle = 907,
    SoundCfTimeCount = 908,
    SoundHousing = 909,
    SoundEqualizerType = 910,
    // <GamePad Button Settings>
    PadButton_L2 = 912,
    PadButton_R2 = 913,
    PadButton_L1 = 914,
    PadButton_R1 = 915,
    PadButton_Triangle = 916,
    PadButton_Circle = 917,
    PadButton_Cross = 918,
    PadButton_Square = 919,
    PadButton_Select = 920,
    PadButton_Start = 921,
    PadButton_LS = 922,
    PadButton_RS = 923,
    PadButton_L3 = 924,
    PadButton_R3 = 925,
    // <CUSTOM CONFIGURATION>
    #endregion

    #region Ui
    BattleEffectSelf = 55,
    BattleEffectParty = 56,
    BattleEffectOther = 57,
    BattleEffectPvPEnemyPc = 58,
    // <GamePad Settings>
    // <UI Settings>
    // <Charcter Settings>
    WeaponAutoPutAway = 173,
    WeaponAutoPutAwayTime = 174,
    LipMotionType = 175,
    // <Game Camera Settings>
    FirstPersonDefaultYAngle = 177,
    FirstPersonDefaultZoom = 178,
    FirstPersonDefaultDistance = 179,
    ThirdPersonDefaultYAngle = 180,
    ThirdPersonDefaultZoom = 181,
    ThirdPersonDefaultDistance = 182,
    LockonDefaultYAngle = 183,
    LockonDefaultZoom = 184,
    LockonDefaultZoom_185 = 185,
    CameraProductionOfAction = 209,
    FPSCameraInterpolationType = 210,
    FPSCameraVerticalInterpolation = 211,
    LegacyCameraCorrectionFix = 212,
    LegacyCameraType = 213,
    EventCameraAutoControl = 215,
    CameraLookBlinkType = 216,
    IdleEmoteTime = 217,
    IdleEmoteRandomType = 218,
    CutsceneSkipIsShip = 219,
    CutsceneSkipIsContents = 220,
    CutsceneSkipIsHousing = 221,
    PetTargetOffInCombat = 313,
    GroundTargetFPSPosX = 314,
    GroundTargetFPSPosY = 315,
    GroundTargetTPSPosX = 316,
    GroundTargetTPSPosY = 317,
    TargetDisableAnchor = 318,
    TargetCircleClickFilterEnableNearestCursor = 319,
    TargetEnableMouseOverSelect = 320,
    GroundTargetCursorCorrectType = 321,
    GroundTargetActionExcuteType = 322,
    AutoNearestTarget = 327,
    AutoNearestTargetType = 328,
    RightClickExclusionPC = 330,
    RightClickExclusionBNPC = 331,
    RightClickExclusionMinion = 332,
    EnableMoveTiltCharacter = 333,
    EnableMoveTiltMountGround = 334,
    EnableMoveTiltMountFly = 335,
    TurnSpeed = 338,
    FootEffect = 340,
    LegacySeal = 343,
    GBarrelDisp = 344,
    EgiMirageTypeGaruda = 345,
    EgiMirageTypeTitan = 346,
    EgiMirageTypeIfrit = 347,
    BahamutSize = 348,
    PetMirageTypeCarbuncleSupport = 349,
    PhoenixSize = 350,
    GarudaSize = 351,
    TitanSize = 352,
    IfritSize = 353,
    SolBahamutSize = 354,
    PetMirageTypeFairy = 355,
    TimeMode = 356,
    Time12 = 357,
    TimeEorzea = 358,
    TimeLocal = 359,
    TimeServer = 360,
    ActiveLS_H = 361,
    ActiveLS_L = 362,
    HotbarLock = 364,
    HotbarDispRecastTime = 366,
    HotbarCrossContentsActionEnableInput = 367,
    HotbarDispRecastTimeDispType = 368,
    ExHotbarChangeHotbar1 = 381,
    HotbarCommon01 = 383,
    HotbarCommon02 = 384,
    HotbarCommon03 = 385,
    HotbarCommon04 = 386,
    HotbarCommon05 = 387,
    HotbarCommon06 = 388,
    HotbarCommon07 = 389,
    HotbarCommon08 = 390,
    HotbarCommon09 = 391,
    HotbarCommon10 = 392,
    HotbarCrossCommon01 = 393,
    HotbarCrossCommon02 = 394,
    HotbarCrossCommon03 = 395,
    HotbarCrossCommon04 = 396,
    HotbarCrossCommon05 = 397,
    HotbarCrossCommon06 = 398,
    HotbarCrossCommon07 = 399,
    HotbarCrossCommon08 = 400,
    HotbarCrossHelpDisp = 401,
    HotbarCrossOperation = 402,
    HotbarCrossDisp = 403,
    HotbarCrossLock = 404,
    HotbarCrossUsePadGuide = 407,
    HotbarCrossActiveSet = 408,
    HotbarCrossActiveSetPvP = 409,
    HotbarCrossSetChangeCustomIsAuto = 410,
    HotbarCrossSetChangeCustom = 412,
    HotbarCrossSetChangeCustomSet1 = 413,
    HotbarCrossSetChangeCustomSet2 = 414,
    HotbarCrossSetChangeCustomSet3 = 415,
    HotbarCrossSetChangeCustomSet4 = 416,
    HotbarCrossSetChangeCustomSet5 = 417,
    HotbarCrossSetChangeCustomSet6 = 418,
    HotbarCrossSetChangeCustomSet7 = 419,
    HotbarCrossSetChangeCustomSet8 = 420,
    HotbarCrossSetChangeCustomIsSword = 421,
    HotbarCrossSetChangeCustomIsSwordSet1 = 422,
    HotbarCrossSetChangeCustomIsSwordSet2 = 423,
    HotbarCrossSetChangeCustomIsSwordSet3 = 424,
    HotbarCrossSetChangeCustomIsSwordSet4 = 425,
    HotbarCrossSetChangeCustomIsSwordSet5 = 426,
    HotbarCrossSetChangeCustomIsSwordSet6 = 427,
    HotbarCrossSetChangeCustomIsSwordSet7 = 428,
    HotbarCrossSetChangeCustomIsSwordSet8 = 429,
    HotbarCrossAdvancedSetting = 430,
    HotbarCrossAdvancedSettingLeft = 431,
    HotbarCrossAdvancedSettingRight = 432,
    HotbarCrossSetPvpModeActive = 433,
    HotbarCrossSetChangeCustomPvp = 434,
    HotbarCrossSetChangeCustomIsAutoPvp = 435,
    HotbarCrossSetChangeCustomSet1Pvp = 436,
    HotbarCrossSetChangeCustomSet2Pvp = 437,
    HotbarCrossSetChangeCustomSet3Pvp = 438,
    HotbarCrossSetChangeCustomSet4Pvp = 439,
    HotbarCrossSetChangeCustomSet5Pvp = 440,
    HotbarCrossSetChangeCustomSet6Pvp = 441,
    HotbarCrossSetChangeCustomSet7Pvp = 442,
    HotbarCrossSetChangeCustomSet8Pvp = 443,
    HotbarCrossSetChangeCustomIsSwordPvp = 444,
    HotbarCrossSetChangeCustomIsSwordSet1Pvp = 445,
    HotbarCrossSetChangeCustomIsSwordSet2Pvp = 446,
    HotbarCrossSetChangeCustomIsSwordSet3Pvp = 447,
    HotbarCrossSetChangeCustomIsSwordSet4Pvp = 448,
    HotbarCrossSetChangeCustomIsSwordSet5Pvp = 449,
    HotbarCrossSetChangeCustomIsSwordSet6Pvp = 450,
    HotbarCrossSetChangeCustomIsSwordSet7Pvp = 451,
    HotbarCrossSetChangeCustomIsSwordSet8Pvp = 452,
    HotbarCrossAdvancedSettingPvp = 453,
    HotbarCrossAdvancedSettingLeftPvp = 454,
    HotbarCrossAdvancedSettingRightPvp = 455,
    HotbarWXHBEnable = 456,
    HotbarWXHBSetLeft = 457,
    HotbarWXHBSetRight = 458,
    HotbarWXHBEnablePvP = 459,
    HotbarWXHBSetLeftPvP = 460,
    HotbarWXHBSetRightPvP = 461,
    HotbarWXHB8Button = 462,
    HotbarWXHB8ButtonPvP = 463,
    HotbarWXHBSetInputTime = 464,
    HotbarWXHBDisplay = 465,
    HotbarWXHBFreeLayout = 466,
    HotbarXHBActiveTransmissionAlpha = 467,
    HotbarXHBAlphaDefault = 468,
    HotbarXHBAlphaActiveSet = 469,
    HotbarXHBAlphaInactiveSet = 470,
    HotbarWXHBInputOnce = 471,
    ExHotbarChangeHotbar1IsFashion = 472,
    HotbarCrossUseExDirectionAutoSwitch = 473,
    IdlingCameraSwitchType = 474,
    HotbarXHBEditEnable = 475,
    PlateType = 476,
    PlateDispHPBar = 477,
    PlateDisableMaxHPBar = 478,
    NamePlateHpSizeType = 479,
    NamePlateColorSelf = 480,
    NamePlateEdgeSelf = 481,
    NamePlateDispTypeSelf = 482,
    NamePlateNameTypeSelf = 483,
    NamePlateHpTypeSelf = 484,
    NamePlateColorSelfBuddy = 485,
    NamePlateEdgeSelfBuddy = 486,
    NamePlateDispTypeSelfBuddy = 487,
    NamePlateHpTypeSelfBuddy = 488,
    NamePlateColorSelfPet = 489,
    NamePlateEdgeSelfPet = 490,
    NamePlateDispTypeSelfPet = 491,
    NamePlateHpTypeSelfPet = 492,
    NamePlateColorParty = 493,
    NamePlateEdgeParty = 494,
    NamePlateDispTypeParty = 495,
    NamePlateNameTypeParty = 496,
    NamePlateHpTypeParty = 497,
    NamePlateDispTypePartyPet = 498,
    NamePlateHpTypePartyPet = 499,
    NamePlateDispTypePartyBuddy = 500,
    NamePlateHpTypePartyBuddy = 501,
    NamePlateColorAlliance = 502,
    NamePlateEdgeAlliance = 503,
    NamePlateDispTypeAlliance = 504,
    NamePlateNameTypeAlliance = 505,
    NamePlateHpTypeAlliance = 506,
    NamePlateDispTypeAlliancePet = 507,
    NamePlateHpTypeAlliancePet = 508,
    NamePlateColorOther = 509,
    NamePlateEdgeOther = 510,
    NamePlateDispTypeOther = 511,
    NamePlateNameTypeOther = 512,
    NamePlateHpTypeOther = 513,
    NamePlateDispTypeOtherPet = 514,
    NamePlateHpTypeOtherPet = 515,
    NamePlateDispTypeOtherBuddy = 516,
    NamePlateHpTypeOtherBuddy = 517,
    NamePlateColorUnengagedEnemy = 518,
    NamePlateEdgeUnengagedEnemy = 519,
    NamePlateDispTypeUnengagedEnemy = 520,
    NamePlateHpTypeUnengagedEmemy = 521,
    NamePlateColorEngagedEnemy = 522,
    NamePlateEdgeEngagedEnemy = 523,
    NamePlateDispTypeEngagedEnemy = 524,
    NamePlateHpTypeEngagedEmemy = 525,
    NamePlateColorClaimedEnemy = 526,
    NamePlateEdgeClaimedEnemy = 527,
    NamePlateDispTypeClaimedEnemy = 528,
    NamePlateHpTypeClaimedEmemy = 529,
    NamePlateColorUnclaimedEnemy = 530,
    NamePlateEdgeUnclaimedEnemy = 531,
    NamePlateDispTypeUnclaimedEnemy = 532,
    NamePlateHpTypeUnclaimedEmemy = 533,
    NamePlateColorNpc = 534,
    NamePlateEdgeNpc = 535,
    NamePlateDispTypeNpc = 536,
    NamePlateHpTypeNpc = 537,
    NamePlateColorObject = 538,
    NamePlateEdgeObject = 539,
    NamePlateDispTypeObject = 540,
    NamePlateHpTypeObject = 541,
    NamePlateColorMinion = 542,
    NamePlateEdgeMinion = 543,
    NamePlateDispTypeMinion = 544,
    NamePlateColorOtherBuddy = 545,
    NamePlateEdgeOtherBuddy = 546,
    NamePlateColorOtherPet = 547,
    NamePlateEdgeOtherPet = 548,
    NamePlateNameTitleTypeSelf = 549,
    NamePlateNameTitleTypeParty = 550,
    NamePlateNameTitleTypeAlliance = 551,
    NamePlateNameTitleTypeOther = 552,
    NamePlateNameTitleTypeFriend = 553,
    NamePlateColorFriend = 554,
    NamePlateColorFriendEdge = 555,
    NamePlateDispTypeFriend = 556,
    NamePlateNameTypeFriend = 557,
    NamePlateHpTypeFriend = 558,
    NamePlateDispTypeFriendPet = 559,
    NamePlateHpTypeFriendPet = 560,
    NamePlateDispTypeFriendBuddy = 561,
    NamePlateHpTypeFriendBuddy = 562,
    NamePlateColorLim = 563,
    NamePlateColorLimEdge = 564,
    NamePlateColorGri = 565,
    NamePlateColorGriEdge = 566,
    NamePlateColorUld = 567,
    NamePlateColorUldEdge = 568,
    NamePlateColorHousingFurniture = 569,
    NamePlateColorHousingFurnitureEdge = 570,
    NamePlateDispTypeHousingFurniture = 571,
    NamePlateColorHousingField = 572,
    NamePlateColorHousingFieldEdge = 573,
    NamePlateDispTypeHousingField = 574,
    NamePlateNameTypePvPEnemy = 575,
    NamePlateDispTypeFeast = 576,
    NamePlateNameTypeFeast = 577,
    NamePlateHpTypeFeast = 578,
    NamePlateDispTypeFeastPet = 579,
    NamePlateHpTypeFeastPet = 580,
    NamePlateNameTitleTypeFeast = 581,
    NamePlateDispSize = 582,
    NamePlateDispJobIcon = 583,
    NamePlateDispJobIconType = 584,
    NamePlateSetRoleColor = 585,
    NamePlateColorTank = 586,
    NamePlateEdgeTank = 587,
    NamePlateColorHealer = 588,
    NamePlateEdgeHealer = 589,
    NamePlateColorDps = 590,
    NamePlateEdgeDps = 591,
    NamePlateColorOtherClass = 592,
    NamePlateEdgeOtherClass = 593,
    NamePlateDispWorldTravel = 594,
    NamePlateDispJobIconInPublicParty = 595,
    NamePlateDispJobIconInPublicOther = 596,
    NamePlateDispJobIconInInstanceParty = 597,
    NamePlateDispJobIconInInstanceOther = 598,
    ActiveInfo = 599,
    PartyList = 600,
    PartyListStatus = 601,
    PartyListStatusTimer = 603,
    EnemyList = 604,
    TargetInfo = 605,
    Gil = 606,
    DTR = 607,
    PlayerInfo = 609,
    NaviMap = 610,
    Help = 611,
    CrossMainHelp = 613,
    HousingLocatePreview = 615,
    Log = 616,
    LogTell = 617,
    LogFontSize = 619,
    LogTabName2 = 620,
    LogTabName3 = 621,
    LogTabFilter0 = 622,
    LogTabFilter1 = 623,
    LogTabFilter2 = 624,
    LogTabFilter3 = 625,
    LogChatFilter = 626,
    LogEnableErrMsgLv1 = 627,
    LogNameType = 629,
    LogTimeDisp = 630,
    LogTimeSettingType = 631,
    LogTimeDispType = 632,
    IsLogTell = 633,
    IsLogParty = 634,
    LogParty = 635,
    IsLogAlliance = 636,
    LogAlliance = 637,
    IsLogFc = 638,
    LogFc = 639,
    IsLogPvpTeam = 640,
    LogPvpTeam = 641,
    IsLogLs1 = 642,
    LogLs1 = 643,
    IsLogLs2 = 644,
    LogLs2 = 645,
    IsLogLs3 = 646,
    LogLs3 = 647,
    IsLogLs4 = 648,
    LogLs4 = 649,
    IsLogLs5 = 650,
    LogLs5 = 651,
    IsLogLs6 = 652,
    LogLs6 = 653,
    IsLogLs7 = 654,
    LogLs7 = 655,
    IsLogLs8 = 656,
    LogLs8 = 657,
    IsLogBeginner = 658,
    LogBeginner = 659,
    IsLogCwls = 660,
    IsLogCwls2 = 661,
    IsLogCwls3 = 662,
    IsLogCwls4 = 663,
    IsLogCwls5 = 664,
    IsLogCwls6 = 665,
    IsLogCwls7 = 666,
    IsLogCwls8 = 667,
    LogCwls = 668,
    LogCwls2 = 669,
    LogCwls3 = 670,
    LogCwls4 = 671,
    LogCwls5 = 672,
    LogCwls6 = 673,
    LogCwls7 = 674,
    LogCwls8 = 675,
    LogRecastActionErrDisp = 676,
    LogPermeationRate = 677,
    LogFontSizeForm = 678,
    LogItemLinkEnableType = 679,
    LogFontSizeLog2 = 680,
    LogTimeDispLog2 = 681,
    LogPermeationRateLog2 = 682,
    LogFontSizeLog3 = 683,
    LogTimeDispLog3 = 684,
    LogPermeationRateLog3 = 685,
    LogFontSizeLog4 = 686,
    LogTimeDispLog4 = 687,
    LogPermeationRateLog4 = 688,
    LogFlyingHeightMaxErrDisp = 689,
    LogCrossWorldName = 690,
    LogDragResize = 691,
    LogNameIconType = 692,
    LogDispClassJobName = 693,
    LogSetRoleColor = 694,
    LogColorRoleTank = 695,
    LogColorRoleHealer = 696,
    LogColorRoleDPS = 697,
    LogColorOtherClass = 698,
    ChatType = 699,
    ShopSell = 700,
    ColorSay = 701,
    ColorShout = 702,
    ColorTell = 703,
    ColorParty = 704,
    ColorAlliance = 705,
    ColorLS1 = 706,
    ColorLS2 = 707,
    ColorLS3 = 708,
    ColorLS4 = 709,
    ColorLS5 = 710,
    ColorLS6 = 711,
    ColorLS7 = 712,
    ColorLS8 = 713,
    ColorFCompany = 714,
    ColorPvPGroup = 715,
    ColorPvPGroupAnnounce = 716,
    ColorBeginner = 717,
    ColorEmoteUser = 718,
    ColorEmote = 719,
    ColorYell = 720,
    ColorBeginnerAnnounce = 722,
    ColorCWLS = 723,
    ColorCWLS2 = 724,
    ColorCWLS3 = 725,
    ColorCWLS4 = 726,
    ColorCWLS5 = 727,
    ColorCWLS6 = 728,
    ColorCWLS7 = 729,
    ColorCWLS8 = 730,
    ColorAttackSuccess = 731,
    ColorAttackFailure = 732,
    ColorAction = 733,
    ColorItem = 734,
    ColorCureGive = 735,
    ColorBuffGive = 736,
    ColorDebuffGive = 737,
    ColorEcho = 738,
    ColorSysMsg = 739,
    ColorFCAnnounce = 740,
    ColorSysBattle = 741,
    ColorSysGathering = 742,
    ColorSysErr = 743,
    ColorNpcSay = 744,
    ColorItemNotice = 745,
    ColorGrowup = 746,
    ColorLoot = 747,
    ColorCraft = 748,
    ColorGathering = 749,
    ShopConfirm = 751,
    ShopConfirmMateria = 752,
    ShopConfirmExRare = 753,
    ShopConfirmSpiritBondMax = 754,
    ItemSortItemCategory = 755,
    ItemSortEquipLevel = 756,
    ItemSortItemLevel = 757,
    ItemSortItemStack = 758,
    ItemSortTidyingType = 759,
    ItemNoArmoryMaskOff = 760,
    ItemInventryStoreEnd = 761,
    InfoSettingDispWorldNameType = 774,
    TargetNamePlateNameType = 776,
    FocusTargetNamePlateNameType = 779,
    ItemDetailTemporarilySwitch = 781,
    ItemDetailTemporarilySwitchKey = 782,
    ItemDetailTemporarilyHide = 783,
    ItemDetailTemporarilyHideKey = 784,
    ToolTipDispSize = 794,
    RecommendLoginDisp = 795,
    RecommendAreaChangeDisp = 796,
    PlayGuideLoginDisp = 797,
    PlayGuideAreaChangeDisp = 798,
    MapPadOperationYReverse = 801,
    MapPadOperationXReverse = 802,
    MapDispSize = 804,
    FlyTextDispSize = 805,
    PopUpTextDispSize = 807,
    DetailDispDelayType = 808,
    PartyListSortTypeTank = 809,
    PartyListSortTypeHealer = 810,
    PartyListSortTypeDps = 811,
    PartyListSortTypeOther = 812,
    RatioHpDisp = 813,
    BuffDispType = 814,
    ContentsFinderListSortType = 817,
    ContentsFinderSupplyEnable = 818,
    EnemyListCastbarEnable = 824,
    AchievementAppealLoginDisp = 825,
    ContentsFinderUseLangTypeJA = 826,
    ContentsFinderUseLangTypeEN = 827,
    ContentsFinderUseLangTypeDE = 828,
    ContentsFinderUseLangTypeFR = 829,
    ItemInventryWindowSizeType = 837,
    ItemInventryRetainerWindowSizeType = 838,
    BattleTalkShowFace = 844,
    BannerContentsDispType = 845,
    BannerContentsNotice = 846,
    MipDispType = 847,
    BannerContentsOrderType = 848,
    CCProgressAllyFixLeftSide = 849,
    CCMapAllyFixLeftSide = 850,
    DispCCCountDown = 851,
    EmoteTextType = 852,
    IsEmoteSe = 853,
    EmoteSeType = 854,
    PartyFinderNewArrivalDisp = 855,
    GPoseTargetFilterNPCLookAt = 856,
    GPoseMotionFilterAction = 857,
    LsListSortPriority = 858,
    FriendListSortPriority = 859,
    FriendListFilterType = 860,
    FriendListSortType = 861,
    LetterListFilterType = 862,
    LetterListSortType = 863,
    ContentsReplayEnable = 865,
    MouseWheelOperationUp = 866,
    MouseWheelOperationDown = 867,
    MouseWheelOperationCtrlUp = 868,
    MouseWheelOperationCtrlDown = 869,
    MouseWheelOperationAltUp = 870,
    MouseWheelOperationAltDown = 871,
    MouseWheelOperationShiftUp = 872,
    MouseWheelOperationShiftDown = 873,
    TelepoTicketUseType = 874,
    TelepoTicketGilSetting = 875,
    TelepoCategoryType = 876,
    HidePcAroundQuestProgressNpc = 877,
    HidePcAroundQuestProgressNpcIncludeParty = 878,
    HidePcAroundNpcAccessingQuest = 879,
    HidePcAroundNpcAccessingQuestIncludeParty = 880,
    PvPFrontlinesGCFree = 885,
    #endregion

    #region UiControl
    // <Charcter Settings>
    AutoChangePointOfView = 186,
    KeyboardCameraInterpolationType = 187,
    KeyboardCameraVerticalInterpolation = 188,
    TiltOffset = 189,
    KeyboardSpeed = 190,
    PadSpeed = 191,
    PadFpsXReverse = 193,
    PadFpsYReverse = 194,
    PadTpsXReverse = 195,
    PadTpsYReverse = 196,
    MouseFpsXReverse = 197,
    MouseFpsYReverse = 198,
    MouseTpsXReverse = 199,
    MouseTpsYReverse = 200,
    MouseCharaViewRotYReverse = 201,
    MouseCharaViewRotXReverse = 202,
    MouseCharaViewMoveYReverse = 203,
    MouseCharaViewMoveXReverse = 204,
    PADCharaViewRotYReverse = 205,
    PADCharaViewRotXReverse = 206,
    PADCharaViewMoveYReverse = 207,
    PADCharaViewMoveXReverse = 208,
    FlyingControlType = 222,
    FlyingLegacyAutorun = 223,
    // <Target Settings>
    AutoFaceTargetOnAction = 225,
    SelfClick = 226,
    NoTargetClickCancel = 227,
    AutoTarget = 228,
    TargetTypeSelect = 229,
    AutoLockOn = 230,
    CircleBattleModeAutoChange = 232,
    CircleIsCustom = 233,
    CircleSwordDrawnIsActive = 234,
    CircleSwordDrawnNonPartyPc = 235,
    CircleSwordDrawnParty = 236,
    CircleSwordDrawnEnemy = 237,
    CircleSwordDrawnAggro = 238,
    CircleSwordDrawnNpcOrObject = 239,
    CircleSwordDrawnMinion = 240,
    CircleSwordDrawnDutyEnemy = 241,
    CircleSwordDrawnPet = 242,
    CircleSwordDrawnAlliance = 243,
    CircleSwordDrawnMark = 244,
    CircleSheathedIsActive = 245,
    CircleSheathedNonPartyPc = 246,
    CircleSheathedParty = 247,
    CircleSheathedEnemy = 248,
    CircleSheathedAggro = 249,
    CircleSheathedNpcOrObject = 250,
    CircleSheathedMinion = 251,
    CircleSheathedDutyEnemy = 252,
    CircleSheathedPet = 253,
    CircleSheathedAlliance = 254,
    CircleSheathedMark = 255,
    CircleClickIsActive = 256,
    CircleClickNonPartyPc = 257,
    CircleClickParty = 258,
    CircleClickEnemy = 259,
    CircleClickAggro = 260,
    CircleClickNpcOrObject = 261,
    CircleClickMinion = 262,
    CircleClickDutyEnemy = 263,
    CircleClickPet = 264,
    CircleClickAlliance = 265,
    CircleClickMark = 266,
    CircleXButtonIsActive = 267,
    CircleXButtonNonPartyPc = 268,
    CircleXButtonParty = 269,
    CircleXButtonEnemy = 270,
    CircleXButtonAggro = 271,
    CircleXButtonNpcOrObject = 272,
    CircleXButtonMinion = 273,
    CircleXButtonDutyEnemy = 274,
    CircleXButtonPet = 275,
    CircleXButtonAlliance = 276,
    CircleXButtonMark = 277,
    CircleYButtonIsActive = 278,
    CircleYButtonNonPartyPc = 279,
    CircleYButtonParty = 280,
    CircleYButtonEnemy = 281,
    CircleYButtonAggro = 282,
    CircleYButtonNpcOrObject = 283,
    CircleYButtonMinion = 284,
    CircleYButtonDutyEnemy = 285,
    CircleYButtonPet = 286,
    CircleYButtonAlliance = 287,
    CircleYButtonMark = 288,
    CircleBButtonIsActive = 289,
    CircleBButtonNonPartyPc = 290,
    CircleBButtonParty = 291,
    CircleBButtonEnemy = 292,
    CircleBButtonAggro = 293,
    CircleBButtonNpcOrObject = 294,
    CircleBButtonMinion = 295,
    CircleBButtonDutyEnemy = 296,
    CircleBButtonPet = 297,
    CircleBButtonAlliance = 298,
    CircleBButtonMark = 299,
    CircleAButtonIsActive = 300,
    CircleAButtonNonPartyPc = 301,
    CircleAButtonParty = 302,
    CircleAButtonEnemy = 303,
    CircleAButtonAggro = 304,
    CircleAButtonNpcOrObject = 305,
    CircleAButtonMinion = 306,
    CircleAButtonDutyEnemy = 307,
    CircleAButtonPet = 308,
    CircleAButtonAlliance = 309,
    CircleAButtonMark = 310,
    GroundTargetType = 311,
    GroundTargetCursorSpeed = 312,
    TargetCircleType = 323,
    TargetLineType = 324,
    LinkLineType = 325,
    ObjectBorderingType = 326,
    MoveMode = 337,
    HotbarDisp = 363,
    HotbarEmptyVisible = 365,
    HotbarNoneSlotDisp01 = 369,
    HotbarNoneSlotDisp02 = 370,
    HotbarNoneSlotDisp03 = 371,
    HotbarNoneSlotDisp04 = 372,
    HotbarNoneSlotDisp05 = 373,
    HotbarNoneSlotDisp06 = 374,
    HotbarNoneSlotDisp07 = 375,
    HotbarNoneSlotDisp08 = 376,
    HotbarNoneSlotDisp09 = 377,
    HotbarNoneSlotDisp10 = 378,
    HotbarNoneSlotDispEX = 379,
    ExHotbarSetting = 380,
    HotbarExHotbarUseSetting = 382,
    HotbarCrossUseEx = 405,
    HotbarCrossUseExDirection = 406,
    HotbarCrossDispType = 411,
    PartyListSoloOff = 602,
    HowTo = 612,
    HousingFurnitureBindConfirm = 614,
    DirectChat = 628,
    CharaParamDisp = 762,
    LimitBreakGaugeDisp = 763,
    ScenarioTreeDisp = 764,
    ScenarioTreeCompleteDisp = 765,
    HotbarCrossDispAlways = 766,
    ExpDisp = 767,
    InventryStatusDisp = 768,
    DutyListDisp = 769,
    NaviMapDisp = 770,
    GilStatusDisp = 771,
    InfoSettingDisp = 772,
    InfoSettingDispType = 773,
    TargetInfoDisp = 775,
    EnemyListDisp = 777,
    FocusTargetDisp = 778,
    ItemDetailDisp = 780,
    ActionDetailDisp = 785,
    DetailTrackingType = 786,
    ToolTipDisp = 787,
    MapPermeationRate = 788,
    MapOperationType = 789,
    PartyListDisp = 790,
    PartyListNameType = 791,
    FlyTextDisp = 792,
    MapPermeationMode = 793,
    AllianceList1Disp = 799,
    AllianceList2Disp = 800,
    TargetInfoSelfBuff = 803,
    PopUpTextDisp = 806,
    ContentsInfoDisp = 815,
    DutyListHideWhenCntInfoDisp = 816,
    DutyListNumDisp = 819,
    InInstanceContentDutyListDisp = 820,
    InPublicContentDutyListDisp = 821,
    ContentsInfoJoiningRequestDisp = 822,
    ContentsInfoJoiningRequestSituationDisp = 823,
    HotbarDispSetNum = 830,
    HotbarDispSetChangeType = 831,
    HotbarDispSetDragType = 832,
    MainCommandType = 833,
    MainCommandDisp = 834,
    MainCommandDragShortcut = 835,
    HotbarDispLookNum = 836,
    #endregion
}
