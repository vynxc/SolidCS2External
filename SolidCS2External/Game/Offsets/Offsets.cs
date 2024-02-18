using SolidCS2External.Game.Offsets.Attributes;

[OffsetsWithFilePath("offsets.json")] public static class client_dll { // client.dll
    public static nint dwEntityList;
    public static nint dwForceAttack;
    public static nint dwForceAttack2;
    public static nint dwForceBackward;
    public static nint dwForceCrouch;
    public static nint dwForceForward;
    public static nint dwForceJump;
    public static nint dwForceLeft;
    public static nint dwForceRight;
    public static nint dwGameEntitySystem;
    public static nint dwGameEntitySystem_getHighestEntityIndex;
    public static nint dwGameRules;
    public static nint dwGlobalVars;
    public static nint dwGlowManager;
    public static nint dwInterfaceLinkList;
    public static nint dwLocalPlayerController;
    public static nint dwLocalPlayerPawn;
    public static nint dwPlantedC4;
    public static nint dwPrediction;
    public static nint dwSensitivity;
    public static nint dwSensitivity_sensitivity;
    public static nint dwViewAngles;
    public static nint dwViewMatrix;
    public static nint dwViewRender;
}

[OffsetsWithFilePath("offsets.json")] public static class engine2_dll { // engine2.dll
    public static nint dwBuildNumber;
    public static nint dwNetworkGameClient;
    public static nint dwNetworkGameClient_getLocalPlayer;
    public static nint dwNetworkGameClient_maxClients;
    public static nint dwNetworkGameClient_signOnState;
    public static nint dwWindowHeight;
    public static nint dwWindowWidth;
}

[OffsetsWithFilePath("offsets.json")] public static class game_info { // Some additional information about the game at dump time
    public static nint buildNumber; // Game build number
}

[OffsetsWithFilePath("offsets.json")] public static class inputsystem_dll { // inputsystem.dll
    public static nint dwInputSystem;
}

[OffsetsWithFilePath("offsets.json")] public static class matchmaking_dll { // matchmaking.dll
    public static nint dwGameTypes;
    public static nint dwGameTypes_mapName;
}