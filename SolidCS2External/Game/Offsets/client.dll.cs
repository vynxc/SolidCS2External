/*
 * Created using https://github.com/a2x/cs2-dumper
 * Sat, 17 Feb 2024 01:42:29 +0000
 */

using SolidCS2External.Game.Offsets.Attributes;

[OffsetsWithFilePath("client.dll.json")] public static class ActiveModelConfig_t {
    public static nint m_Handle; // ModelConfigHandle_t
    public static nint m_Name; // CUtlSymbolLarge
    public static nint m_AssociatedEntities; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public static nint m_AssociatedEntityNames; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
}

[OffsetsWithFilePath("client.dll.json")] public static class CAnimGraphNetworkedVariables {
    public static nint m_PredNetBoolVariables; // C_NetworkUtlVectorBase<uint32_t>
    public static nint m_PredNetByteVariables; // C_NetworkUtlVectorBase<uint8_t>
    public static nint m_PredNetUInt16Variables; // C_NetworkUtlVectorBase<uint16_t>
    public static nint m_PredNetIntVariables; // C_NetworkUtlVectorBase<int32_t>
    public static nint m_PredNetUInt32Variables; // C_NetworkUtlVectorBase<uint32_t>
    public static nint m_PredNetUInt64Variables; // C_NetworkUtlVectorBase<uint64_t>
    public static nint m_PredNetFloatVariables; // C_NetworkUtlVectorBase<float>
    public static nint m_PredNetVectorVariables; // C_NetworkUtlVectorBase<Vector>
    public static nint m_PredNetQuaternionVariables; // C_NetworkUtlVectorBase<Quaternion>
    public static nint m_PredNetGlobalSymbolVariables; // C_NetworkUtlVectorBase<CGlobalSymbol>
    public static nint m_OwnerOnlyPredNetBoolVariables; // C_NetworkUtlVectorBase<uint32_t>
    public static nint m_OwnerOnlyPredNetByteVariables; // C_NetworkUtlVectorBase<uint8_t>
    public static nint m_OwnerOnlyPredNetUInt16Variables; // C_NetworkUtlVectorBase<uint16_t>
    public static nint m_OwnerOnlyPredNetIntVariables; // C_NetworkUtlVectorBase<int32_t>
    public static nint m_OwnerOnlyPredNetUInt32Variables; // C_NetworkUtlVectorBase<uint32_t>
    public static nint m_OwnerOnlyPredNetUInt64Variables; // C_NetworkUtlVectorBase<uint64_t>
    public static nint m_OwnerOnlyPredNetFloatVariables; // C_NetworkUtlVectorBase<float>
    public static nint m_OwnerOnlyPredNetVectorVariables; // C_NetworkUtlVectorBase<Vector>
    public static nint m_OwnerOnlyPredNetQuaternionVariables; // C_NetworkUtlVectorBase<Quaternion>
    public static nint m_OwnerOnlyPredNetGlobalSymbolVariables; // C_NetworkUtlVectorBase<CGlobalSymbol>
    public static nint m_nBoolVariablesCount; // int32_t
    public static nint m_nOwnerOnlyBoolVariablesCount; // int32_t
    public static nint m_nRandomSeedOffset; // int32_t
    public static nint m_flLastTeleportTime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CAttributeList {
    public static nint m_Attributes; // C_UtlVectorEmbeddedNetworkVar<CEconItemAttribute>
    public static nint m_pManager; // CAttributeManager*
}

[OffsetsWithFilePath("client.dll.json")] public static class CAttributeManager {
    public static nint m_Providers; // CUtlVector<CHandle<C_BaseEntity>>
    public static nint m_iReapplyProvisionParity; // int32_t
    public static nint m_hOuter; // CHandle<C_BaseEntity>
    public static nint m_bPreventLoopback; // bool
    public static nint m_ProviderType; // attributeprovidertypes_t
    public static nint m_CachedResults; // CUtlVector<CAttributeManager::cached_attribute_float_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CAttributeManager_cached_attribute_float_t {
    public static nint flIn; // float
    public static nint iAttribHook; // CUtlSymbolLarge
    public static nint flOut; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CBaseAnimGraph { // C_BaseModelEntity
    public static nint m_bInitiallyPopulateInterpHistory; // bool
    public static nint m_bSuppressAnimEventSounds; // bool
    public static nint m_bAnimGraphUpdateEnabled; // bool
    public static nint m_flMaxSlopeDistance; // float
    public static nint m_vLastSlopeCheckPos; // Vector
    public static nint m_bAnimationUpdateScheduled; // bool
    public static nint m_vecForce; // Vector
    public static nint m_nForceBone; // int32_t
    public static nint m_pClientsideRagdoll; // CBaseAnimGraph*
    public static nint m_bBuiltRagdoll; // bool
    public static nint m_pRagdollPose; // PhysicsRagdollPose_t*
    public static nint m_bClientRagdoll; // bool
    public static nint m_bHasAnimatedMaterialAttributes; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CBaseAnimGraphController { // CSkeletonAnimationController
    public static nint m_animGraphNetworkedVars; // CAnimGraphNetworkedVariables
    public static nint m_bSequenceFinished; // bool
    public static nint m_flSoundSyncTime; // float
    public static nint m_hSequence; // HSequence
    public static nint m_flSeqStartTime; // GameTime_t
    public static nint m_flSeqFixedCycle; // float
    public static nint m_nAnimLoopMode; // AnimLoopMode_t
    public static nint m_flPlaybackRate; // CNetworkedQuantizedFloat
    public static nint m_nNotifyState; // SequenceFinishNotifyState_t
    public static nint m_bNetworkedAnimationInputsChanged; // bool
    public static nint m_bNetworkedSequenceChanged; // bool
    public static nint m_bLastUpdateSkipped; // bool
    public static nint m_flPrevAnimUpdateTime; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CBasePlayerController { // C_BaseEntity
    public static nint m_nFinalPredictedTick; // int32_t
    public static nint m_CommandContext; // C_CommandContext
    public static nint m_nInButtonsWhichAreToggles; // uint64_t
    public static nint m_nTickBase; // uint32_t
    public static nint m_hPawn; // CHandle<C_BasePlayerPawn>
    public static nint m_hPredictedPawn; // CHandle<C_BasePlayerPawn>
    public static nint m_nSplitScreenSlot; // CSplitScreenSlot
    public static nint m_hSplitOwner; // CHandle<CBasePlayerController>
    public static nint m_hSplitScreenPlayers; // CUtlVector<CHandle<CBasePlayerController>>
    public static nint m_bIsHLTV; // bool
    public static nint m_iConnected; // PlayerConnectedState
    public static nint m_iszPlayerName; // char[128]
    public static nint m_steamID; // uint64_t
    public static nint m_bIsLocalPlayerController; // bool
    public static nint m_iDesiredFOV; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CBasePlayerControllerAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CBasePlayerVData { // CEntitySubclassVDataBase
    public static nint m_sModelName; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_flHeadDamageMultiplier; // CSkillFloat
    public static nint m_flChestDamageMultiplier; // CSkillFloat
    public static nint m_flStomachDamageMultiplier; // CSkillFloat
    public static nint m_flArmDamageMultiplier; // CSkillFloat
    public static nint m_flLegDamageMultiplier; // CSkillFloat
    public static nint m_flHoldBreathTime; // float
    public static nint m_flDrowningDamageInterval; // float
    public static nint m_nDrowningDamageInitial; // int32_t
    public static nint m_nDrowningDamageMax; // int32_t
    public static nint m_nWaterSpeed; // int32_t
    public static nint m_flUseRange; // float
    public static nint m_flUseAngleTolerance; // float
    public static nint m_flCrouchTime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CBasePlayerWeaponVData { // CEntitySubclassVDataBase
    public static nint m_szWorldModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_bBuiltRightHanded; // bool
    public static nint m_bAllowFlipping; // bool
    public static nint m_sMuzzleAttachment; // CUtlString
    public static nint m_szMuzzleFlashParticle; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_iFlags; // ItemFlagTypes_t
    public static nint m_nPrimaryAmmoType; // AmmoIndex_t
    public static nint m_nSecondaryAmmoType; // AmmoIndex_t
    public static nint m_iMaxClip1; // int32_t
    public static nint m_iMaxClip2; // int32_t
    public static nint m_iDefaultClip1; // int32_t
    public static nint m_iDefaultClip2; // int32_t
    public static nint m_iWeight; // int32_t
    public static nint m_bAutoSwitchTo; // bool
    public static nint m_bAutoSwitchFrom; // bool
    public static nint m_iRumbleEffect; // RumbleEffect_t
    public static nint m_bLinkedCooldowns; // bool
    public static nint m_aShootSounds; // CUtlMap<WeaponSound_t,CSoundEventName>
    public static nint m_iSlot; // int32_t
    public static nint m_iPosition; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CBaseProp { // CBaseAnimGraph
    public static nint m_bModelOverrodeBlockLOS; // bool
    public static nint m_iShapeType; // int32_t
    public static nint m_bConformToCollisionBounds; // bool
    public static nint m_mPreferredCatchTransform; // matrix3x4_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CBodyComponent { // CEntityComponent
    public static nint m_pSceneNode; // CGameSceneNode*
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CBodyComponentBaseAnimGraph { // CBodyComponentSkeletonInstance
    public static nint m_animationController; // CBaseAnimGraphController
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CBodyComponentBaseModelEntity { // CBodyComponentSkeletonInstance
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CBodyComponentPoint { // CBodyComponent
    public static nint m_sceneNode; // CGameSceneNode
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CBodyComponentSkeletonInstance { // CBodyComponent
    public static nint m_skeletonInstance; // CSkeletonInstance
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CBombTarget { // C_BaseTrigger
    public static nint m_bBombPlantedHere; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CBreachCharge { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class CBreachChargeProjectile { // C_BaseGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class CBumpMine { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class CBumpMineProjectile { // C_BaseGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class CBuoyancyHelper {
    public static nint m_flFluidDensity; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSArmsRaceScript { // CCSGameModeScript
    public static nint m_pOuter; // CCSGameModeRules_ArmsRace*
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSDeathmatchScript { // CCSGameModeScript
    public static nint m_pOuter; // CCSGameModeRules_Deathmatch*
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGO_WingmanIntroCharacterPosition { // C_CSGO_TeamIntroCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGO_WingmanIntroCounterTerroristPosition { // CCSGO_WingmanIntroCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGO_WingmanIntroTerroristPosition { // CCSGO_WingmanIntroCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGameModeRules {
    public static nint __m_pChainEntity; // CNetworkVarChainer
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGameModeRules_ArmsRace { // CCSGameModeRules
    public static nint m_WeaponSequence; // C_NetworkUtlVectorBase<CUtlString>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGameModeRules_Deathmatch { // CCSGameModeRules
    public static nint m_flDMBonusStartTime; // GameTime_t
    public static nint m_flDMBonusTimeLength; // float
    public static nint m_nDMBonusWeaponLoadoutSlot; // int16_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGameModeRules_Noop { // CCSGameModeRules
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSGameModeScript { // CBasePulseGraphInstance
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSObserver_CameraServices { // CCSPlayerBase_CameraServices
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSObserver_MovementServices { // CPlayer_MovementServices
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSObserver_ObserverServices { // CPlayer_ObserverServices
    public static nint m_hLastObserverTarget; // CEntityHandle
    public static nint m_vecObserverInterpolateOffset; // Vector
    public static nint m_vecObserverInterpStartPos; // Vector
    public static nint m_flObsInterp_PathLength; // float
    public static nint m_qObsInterp_OrientationStart; // Quaternion
    public static nint m_qObsInterp_OrientationTravelDir; // Quaternion
    public static nint m_obsInterpState; // ObserverInterpState_t
    public static nint m_bObserverInterpolationNeedsDeferredSetup; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSObserver_UseServices { // CPlayer_UseServices
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSObserver_ViewModelServices { // CPlayer_ViewModelServices
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerBase_CameraServices { // CPlayer_CameraServices
    public static nint m_iFOV; // uint32_t
    public static nint m_iFOVStart; // uint32_t
    public static nint m_flFOVTime; // GameTime_t
    public static nint m_flFOVRate; // float
    public static nint m_hZoomOwner; // CHandle<C_BaseEntity>
    public static nint m_flLastShotFOV; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerController { // CBasePlayerController
    public static nint m_pInGameMoneyServices; // CCSPlayerController_InGameMoneyServices*
    public static nint m_pInventoryServices; // CCSPlayerController_InventoryServices*
    public static nint m_pActionTrackingServices; // CCSPlayerController_ActionTrackingServices*
    public static nint m_pDamageServices; // CCSPlayerController_DamageServices*
    public static nint m_iPing; // uint32_t
    public static nint m_bHasCommunicationAbuseMute; // bool
    public static nint m_szCrosshairCodes; // CUtlSymbolLarge
    public static nint m_iPendingTeamNum; // uint8_t
    public static nint m_flForceTeamTime; // GameTime_t
    public static nint m_iCompTeammateColor; // int32_t
    public static nint m_bEverPlayedOnTeam; // bool
    public static nint m_flPreviousForceJoinTeamTime; // GameTime_t
    public static nint m_szClan; // CUtlSymbolLarge
    public static nint m_sSanitizedPlayerName; // CUtlString
    public static nint m_iCoachingTeam; // int32_t
    public static nint m_nPlayerDominated; // uint64_t
    public static nint m_nPlayerDominatingMe; // uint64_t
    public static nint m_iCompetitiveRanking; // int32_t
    public static nint m_iCompetitiveWins; // int32_t
    public static nint m_iCompetitiveRankType; // int8_t
    public static nint m_iCompetitiveRankingPredicted_Win; // int32_t
    public static nint m_iCompetitiveRankingPredicted_Loss; // int32_t
    public static nint m_iCompetitiveRankingPredicted_Tie; // int32_t
    public static nint m_nEndMatchNextMapVote; // int32_t
    public static nint m_unActiveQuestId; // uint16_t
    public static nint m_nQuestProgressReason; // QuestProgress::Reason
    public static nint m_unPlayerTvControlFlags; // uint32_t
    public static nint m_iDraftIndex; // int32_t
    public static nint m_msQueuedModeDisconnectionTimestamp; // uint32_t
    public static nint m_uiAbandonRecordedReason; // uint32_t
    public static nint m_bCannotBeKicked; // bool
    public static nint m_bEverFullyConnected; // bool
    public static nint m_bAbandonAllowsSurrender; // bool
    public static nint m_bAbandonOffersInstantSurrender; // bool
    public static nint m_bDisconnection1MinWarningPrinted; // bool
    public static nint m_bScoreReported; // bool
    public static nint m_nDisconnectionTick; // int32_t
    public static nint m_bControllingBot; // bool
    public static nint m_bHasControlledBotThisRound; // bool
    public static nint m_bHasBeenControlledByPlayerThisRound; // bool
    public static nint m_nBotsControlledThisRound; // int32_t
    public static nint m_bCanControlObservedBot; // bool
    public static nint m_hPlayerPawn; // CHandle<C_CSPlayerPawn>
    public static nint m_hObserverPawn; // CHandle<C_CSObserverPawn>
    public static nint m_bPawnIsAlive; // bool
    public static nint m_iPawnHealth; // uint32_t
    public static nint m_iPawnArmor; // int32_t
    public static nint m_bPawnHasDefuser; // bool
    public static nint m_bPawnHasHelmet; // bool
    public static nint m_nPawnCharacterDefIndex; // uint16_t
    public static nint m_iPawnLifetimeStart; // int32_t
    public static nint m_iPawnLifetimeEnd; // int32_t
    public static nint m_iPawnBotDifficulty; // int32_t
    public static nint m_hOriginalControllerOfCurrentPawn; // CHandle<CCSPlayerController>
    public static nint m_iScore; // int32_t
    public static nint m_vecKills; // C_NetworkUtlVectorBase<EKillTypes_t>
    public static nint m_iMVPs; // int32_t
    public static nint m_bIsPlayerNameDirty; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerControllerAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerController_ActionTrackingServices { // CPlayerControllerComponent
    public static nint m_perRoundStats; // C_UtlVectorEmbeddedNetworkVar<CSPerRoundStats_t>
    public static nint m_matchStats; // CSMatchStats_t
    public static nint m_iNumRoundKills; // int32_t
    public static nint m_iNumRoundKillsHeadshots; // int32_t
    public static nint m_unTotalRoundDamageDealt; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerController_DamageServices { // CPlayerControllerComponent
    public static nint m_nSendUpdate; // int32_t
    public static nint m_DamageList; // C_UtlVectorEmbeddedNetworkVar<CDamageRecord>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerController_InGameMoneyServices { // CPlayerControllerComponent
    public static nint m_iAccount; // int32_t
    public static nint m_iStartAccount; // int32_t
    public static nint m_iTotalCashSpent; // int32_t
    public static nint m_iCashSpentThisRound; // int32_t
    public static nint m_nPreviousAccount; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayerController_InventoryServices { // CPlayerControllerComponent
    public static nint m_unMusicID; // uint16_t
    public static nint m_rank; // MedalRank_t[6]
    public static nint m_nPersonaDataPublicLevel; // int32_t
    public static nint m_nPersonaDataPublicCommendsLeader; // int32_t
    public static nint m_nPersonaDataPublicCommendsTeacher; // int32_t
    public static nint m_nPersonaDataPublicCommendsFriendly; // int32_t
    public static nint m_nPersonaDataXpTrailLevel; // int32_t
    public static nint m_vecServerAuthoritativeWeaponSlots; // C_UtlVectorEmbeddedNetworkVar<ServerAuthoritativeWeaponSlot_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_ActionTrackingServices { // CPlayerPawnComponent
    public static nint m_hLastWeaponBeforeC4AutoSwitch; // CHandle<C_BasePlayerWeapon>
    public static nint m_bIsRescuing; // bool
    public static nint m_weaponPurchasesThisMatch; // WeaponPurchaseTracker_t
    public static nint m_weaponPurchasesThisRound; // WeaponPurchaseTracker_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_BulletServices { // CPlayerPawnComponent
    public static nint m_totalHitsOnServer; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_BuyServices { // CPlayerPawnComponent
    public static nint m_vecSellbackPurchaseEntries; // C_UtlVectorEmbeddedNetworkVar<SellbackPurchaseEntry_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_CameraServices { // CCSPlayerBase_CameraServices
    public static nint m_flDeathCamTilt; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_GlowServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_HostageServices { // CPlayerPawnComponent
    public static nint m_hCarriedHostage; // CHandle<C_BaseEntity>
    public static nint m_hCarriedHostageProp; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_ItemServices { // CPlayer_ItemServices
    public static nint m_bHasDefuser; // bool
    public static nint m_bHasHelmet; // bool
    public static nint m_bHasHeavyArmor; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_MovementServices { // CPlayer_MovementServices_Humanoid
    public static nint m_flMaxFallVelocity; // float
    public static nint m_vecLadderNormal; // Vector
    public static nint m_nLadderSurfacePropIndex; // int32_t
    public static nint m_flDuckAmount; // float
    public static nint m_flDuckSpeed; // float
    public static nint m_bDuckOverride; // bool
    public static nint m_bDesiresDuck; // bool
    public static nint m_flDuckOffset; // float
    public static nint m_nDuckTimeMsecs; // uint32_t
    public static nint m_nDuckJumpTimeMsecs; // uint32_t
    public static nint m_nJumpTimeMsecs; // uint32_t
    public static nint m_flLastDuckTime; // float
    public static nint m_vecLastPositionAtFullCrouchSpeed; // Vector2D
    public static nint m_duckUntilOnGround; // bool
    public static nint m_bHasWalkMovedSinceLastJump; // bool
    public static nint m_bInStuckTest; // bool
    public static nint m_flStuckCheckTime; // float[64][2]
    public static nint m_nTraceCount; // int32_t
    public static nint m_StuckLast; // int32_t
    public static nint m_bSpeedCropped; // bool
    public static nint m_nOldWaterLevel; // int32_t
    public static nint m_flWaterEntryTime; // float
    public static nint m_vecForward; // Vector
    public static nint m_vecLeft; // Vector
    public static nint m_vecUp; // Vector
    public static nint m_nGameCodeHasMovedPlayerAfterCommand; // int32_t
    public static nint m_bOldJumpPressed; // bool
    public static nint m_flJumpPressedTime; // float
    public static nint m_flJumpUntil; // float
    public static nint m_flJumpVel; // float
    public static nint m_fStashGrenadeParameterWhen; // GameTime_t
    public static nint m_nButtonDownMaskPrev; // uint64_t
    public static nint m_flOffsetTickCompleteTime; // float
    public static nint m_flOffsetTickStashedSpeed; // float
    public static nint m_flStamina; // float
    public static nint m_flHeightAtJumpStart; // float
    public static nint m_flMaxJumpHeightThisJump; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_PingServices { // CPlayerPawnComponent
    public static nint m_hPlayerPing; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_UseServices { // CPlayer_UseServices
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_ViewModelServices { // CPlayer_ViewModelServices
    public static nint m_hViewModel; // CHandle<C_BaseViewModel>[3]
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_WaterServices { // CPlayer_WaterServices
    public static nint m_flWaterJumpTime; // float
    public static nint m_vecWaterJumpVel; // Vector
    public static nint m_flSwimSoundTime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSPlayer_WeaponServices { // CPlayer_WeaponServices
    public static nint m_flNextAttack; // GameTime_t
    public static nint m_bIsLookingAtWeapon; // bool
    public static nint m_bIsHoldingLookAtWeapon; // bool
    public static nint m_nOldShootPositionHistoryCount; // uint32_t
    public static nint m_nOldInputHistoryCount; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSTakeDamageInfoAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSWeaponBaseAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSWeaponBaseVData { // CBasePlayerWeaponVData
    public static nint m_WeaponType; // CSWeaponType
    public static nint m_WeaponCategory; // CSWeaponCategory
    public static nint m_szViewModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_szPlayerModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_szWorldDroppedModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_szAimsightLensMaskModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_szMagazineModel; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public static nint m_szHeatEffect; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_szEjectBrassEffect; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_szMuzzleFlashParticleAlt; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_szMuzzleFlashThirdPersonParticle; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_szMuzzleFlashThirdPersonParticleAlt; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_szTracerParticle; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_GearSlot; // gear_slot_t
    public static nint m_GearSlotPosition; // int32_t
    public static nint m_DefaultLoadoutSlot; // loadout_slot_t
    public static nint m_sWrongTeamMsg; // CUtlString
    public static nint m_nPrice; // int32_t
    public static nint m_nKillAward; // int32_t
    public static nint m_nPrimaryReserveAmmoMax; // int32_t
    public static nint m_nSecondaryReserveAmmoMax; // int32_t
    public static nint m_bMeleeWeapon; // bool
    public static nint m_bHasBurstMode; // bool
    public static nint m_bIsRevolver; // bool
    public static nint m_bCannotShootUnderwater; // bool
    public static nint m_szName; // CGlobalSymbol
    public static nint m_szAnimExtension; // CUtlString
    public static nint m_eSilencerType; // CSWeaponSilencerType
    public static nint m_nCrosshairMinDistance; // int32_t
    public static nint m_nCrosshairDeltaDistance; // int32_t
    public static nint m_bIsFullAuto; // bool
    public static nint m_nNumBullets; // int32_t
    public static nint m_flCycleTime; // CFiringModeFloat
    public static nint m_flMaxSpeed; // CFiringModeFloat
    public static nint m_flSpread; // CFiringModeFloat
    public static nint m_flInaccuracyCrouch; // CFiringModeFloat
    public static nint m_flInaccuracyStand; // CFiringModeFloat
    public static nint m_flInaccuracyJump; // CFiringModeFloat
    public static nint m_flInaccuracyLand; // CFiringModeFloat
    public static nint m_flInaccuracyLadder; // CFiringModeFloat
    public static nint m_flInaccuracyFire; // CFiringModeFloat
    public static nint m_flInaccuracyMove; // CFiringModeFloat
    public static nint m_flRecoilAngle; // CFiringModeFloat
    public static nint m_flRecoilAngleVariance; // CFiringModeFloat
    public static nint m_flRecoilMagnitude; // CFiringModeFloat
    public static nint m_flRecoilMagnitudeVariance; // CFiringModeFloat
    public static nint m_nTracerFrequency; // CFiringModeInt
    public static nint m_flInaccuracyJumpInitial; // float
    public static nint m_flInaccuracyJumpApex; // float
    public static nint m_flInaccuracyReload; // float
    public static nint m_nRecoilSeed; // int32_t
    public static nint m_nSpreadSeed; // int32_t
    public static nint m_flTimeToIdleAfterFire; // float
    public static nint m_flIdleInterval; // float
    public static nint m_flAttackMovespeedFactor; // float
    public static nint m_flHeatPerShot; // float
    public static nint m_flInaccuracyPitchShift; // float
    public static nint m_flInaccuracyAltSoundThreshold; // float
    public static nint m_flBotAudibleRange; // float
    public static nint m_szUseRadioSubtitle; // CUtlString
    public static nint m_bUnzoomsAfterShot; // bool
    public static nint m_bHideViewModelWhenZoomed; // bool
    public static nint m_nZoomLevels; // int32_t
    public static nint m_nZoomFOV1; // int32_t
    public static nint m_nZoomFOV2; // int32_t
    public static nint m_flZoomTime0; // float
    public static nint m_flZoomTime1; // float
    public static nint m_flZoomTime2; // float
    public static nint m_flIronSightPullUpSpeed; // float
    public static nint m_flIronSightPutDownSpeed; // float
    public static nint m_flIronSightFOV; // float
    public static nint m_flIronSightPivotForward; // float
    public static nint m_flIronSightLooseness; // float
    public static nint m_angPivotAngle; // QAngle
    public static nint m_vecIronSightEyePos; // Vector
    public static nint m_nDamage; // int32_t
    public static nint m_flHeadshotMultiplier; // float
    public static nint m_flArmorRatio; // float
    public static nint m_flPenetration; // float
    public static nint m_flRange; // float
    public static nint m_flRangeModifier; // float
    public static nint m_flFlinchVelocityModifierLarge; // float
    public static nint m_flFlinchVelocityModifierSmall; // float
    public static nint m_flRecoveryTimeCrouch; // float
    public static nint m_flRecoveryTimeStand; // float
    public static nint m_flRecoveryTimeCrouchFinal; // float
    public static nint m_flRecoveryTimeStandFinal; // float
    public static nint m_nRecoveryTransitionStartBullet; // int32_t
    public static nint m_nRecoveryTransitionEndBullet; // int32_t
    public static nint m_flThrowVelocity; // float
    public static nint m_vSmokeColor; // Vector
    public static nint m_szAnimClass; // CGlobalSymbol
}

[OffsetsWithFilePath("client.dll.json")] public static class CCSWeaponBaseVDataAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CClientAlphaProperty { // IClientAlphaProperty
    public static nint m_nRenderFX; // uint8_t
    public static nint m_nRenderMode; // uint8_t
    public static nint m_bAlphaOverride; // bitfield:1
    public static nint m_bShadowAlphaOverride; // bitfield:1
    public static nint m_nReserved; // bitfield:6
    public static nint m_nAlpha; // uint8_t
    public static nint m_nDesyncOffset; // uint16_t
    public static nint m_nReserved2; // uint16_t
    public static nint m_nDistFadeStart; // uint16_t
    public static nint m_nDistFadeEnd; // uint16_t
    public static nint m_flFadeScale; // float
    public static nint m_flRenderFxStartTime; // GameTime_t
    public static nint m_flRenderFxDuration; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CClientPointEntityAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CClientScriptEntity { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CCollisionProperty {
    public static nint m_collisionAttribute; // VPhysicsCollisionAttribute_t
    public static nint m_vecMins; // Vector
    public static nint m_vecMaxs; // Vector
    public static nint m_usSolidFlags; // uint8_t
    public static nint m_nSolidType; // SolidType_t
    public static nint m_triggerBloat; // uint8_t
    public static nint m_nSurroundType; // SurroundingBoundsType_t
    public static nint m_CollisionGroup; // uint8_t
    public static nint m_nEnablePhysics; // uint8_t
    public static nint m_flBoundingRadius; // float
    public static nint m_vecSpecifiedSurroundingMins; // Vector
    public static nint m_vecSpecifiedSurroundingMaxs; // Vector
    public static nint m_vecSurroundingMaxs; // Vector
    public static nint m_vecSurroundingMins; // Vector
    public static nint m_vCapsuleCenter1; // Vector
    public static nint m_vCapsuleCenter2; // Vector
    public static nint m_flCapsuleRadius; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CCompositeMaterialEditorDoc {
    public static nint m_nVersion; // int32_t
    public static nint m_Points; // CUtlVector<CompositeMaterialEditorPoint_t>
    public static nint m_KVthumbnail; // KeyValues3
}

[OffsetsWithFilePath("client.dll.json")] public static class CDamageRecord {
    public static nint m_PlayerDamager; // CHandle<C_CSPlayerPawnBase>
    public static nint m_PlayerRecipient; // CHandle<C_CSPlayerPawnBase>
    public static nint m_hPlayerControllerDamager; // CHandle<CCSPlayerController>
    public static nint m_hPlayerControllerRecipient; // CHandle<CCSPlayerController>
    public static nint m_szPlayerDamagerName; // CUtlString
    public static nint m_szPlayerRecipientName; // CUtlString
    public static nint m_DamagerXuid; // uint64_t
    public static nint m_RecipientXuid; // uint64_t
    public static nint m_iDamage; // int32_t
    public static nint m_iActualHealthRemoved; // int32_t
    public static nint m_iNumHits; // int32_t
    public static nint m_iLastBulletUpdate; // int32_t
    public static nint m_bIsOtherEnemy; // bool
    public static nint m_killType; // EKillTypes_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CDecalInfo {
    public static nint m_flAnimationScale; // float
    public static nint m_flAnimationLifeSpan; // float
    public static nint m_flPlaceTime; // float
    public static nint m_flFadeStartTime; // float
    public static nint m_flFadeDuration; // float
    public static nint m_nVBSlot; // int32_t
    public static nint m_nBoneIndex; // int32_t
    public static nint m_vPosition; // Vector
    public static nint m_flBoundingRadiusSqr; // float
    public static nint m_pNext; // CDecalInfo*
    public static nint m_pPrev; // CDecalInfo*
    public static nint m_nDecalMaterialIndex; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CDynamicPropAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CEconItemAttribute {
    public static nint m_iAttributeDefinitionIndex; // uint16_t
    public static nint m_flValue; // float
    public static nint m_flInitialValue; // float
    public static nint m_nRefundableCurrency; // int32_t
    public static nint m_bSetBonus; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CEffectData {
    public static nint m_vOrigin; // Vector
    public static nint m_vStart; // Vector
    public static nint m_vNormal; // Vector
    public static nint m_vAngles; // QAngle
    public static nint m_hEntity; // CEntityHandle
    public static nint m_hOtherEntity; // CEntityHandle
    public static nint m_flScale; // float
    public static nint m_flMagnitude; // float
    public static nint m_flRadius; // float
    public static nint m_nSurfaceProp; // CUtlStringToken
    public static nint m_nEffectIndex; // CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>
    public static nint m_nDamageType; // uint32_t
    public static nint m_nPenetrate; // uint8_t
    public static nint m_nMaterial; // uint16_t
    public static nint m_nHitBox; // uint16_t
    public static nint m_nColor; // uint8_t
    public static nint m_fFlags; // uint8_t
    public static nint m_nAttachmentIndex; // AttachmentHandle_t
    public static nint m_nAttachmentName; // CUtlStringToken
    public static nint m_iEffectName; // uint16_t
    public static nint m_nExplosionType; // uint8_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CEntityComponent {
}

[OffsetsWithFilePath("client.dll.json")] public static class CEntityIdentity {
    public static nint m_nameStringableIndex; // int32_t
    public static nint m_name; // CUtlSymbolLarge
    public static nint m_designerName; // CUtlSymbolLarge
    public static nint m_flags; // uint32_t
    public static nint m_worldGroupId; // WorldGroupId_t
    public static nint m_fDataObjectTypes; // uint32_t
    public static nint m_PathIndex; // ChangeAccessorFieldPathIndex_t
    public static nint m_pPrev; // CEntityIdentity*
    public static nint m_pNext; // CEntityIdentity*
    public static nint m_pPrevByClass; // CEntityIdentity*
    public static nint m_pNextByClass; // CEntityIdentity*
}

[OffsetsWithFilePath("client.dll.json")] public static class CEntityInstance {
    public static nint m_iszPrivateVScripts; // CUtlSymbolLarge
    public static nint m_pEntity; // CEntityIdentity*
    public static nint m_CScriptComponent; // CScriptComponent*
    public static nint m_bVisibleinPVS; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CFireOverlay { // CGlowOverlay
    public static nint m_pOwner; // C_FireSmoke*
    public static nint m_vBaseColors; // Vector[4]
    public static nint m_flScale; // float
    public static nint m_nGUID; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CFlashlightEffect {
    public static nint m_bIsOn; // bool
    public static nint m_bMuzzleFlashEnabled; // bool
    public static nint m_flMuzzleFlashBrightness; // float
    public static nint m_quatMuzzleFlashOrientation; // Quaternion
    public static nint m_vecMuzzleFlashOrigin; // Vector
    public static nint m_flFov; // float
    public static nint m_flFarZ; // float
    public static nint m_flLinearAtten; // float
    public static nint m_bCastsShadows; // bool
    public static nint m_flCurrentPullBackDist; // float
    public static nint m_FlashlightTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_MuzzleFlashTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_textureName; // char[64]
}

[OffsetsWithFilePath("client.dll.json")] public static class CFuncWater { // C_BaseModelEntity
    public static nint m_BuoyancyHelper; // CBuoyancyHelper
}

[OffsetsWithFilePath("client.dll.json")] public static class CGameSceneNode {
    public static nint m_nodeToWorld; // CTransform
    public static nint m_pOwner; // CEntityInstance*
    public static nint m_pParent; // CGameSceneNode*
    public static nint m_pChild; // CGameSceneNode*
    public static nint m_pNextSibling; // CGameSceneNode*
    public static nint m_hParent; // CGameSceneNodeHandle
    public static nint m_vecOrigin; // CNetworkOriginCellCoordQuantizedVector
    public static nint m_angRotation; // QAngle
    public static nint m_flScale; // float
    public static nint m_vecAbsOrigin; // Vector
    public static nint m_angAbsRotation; // QAngle
    public static nint m_flAbsScale; // float
    public static nint m_nParentAttachmentOrBone; // int16_t
    public static nint m_bDebugAbsOriginChanges; // bool
    public static nint m_bDormant; // bool
    public static nint m_bForceParentToBeNetworked; // bool
    public static nint m_bDirtyHierarchy; // bitfield:1
    public static nint m_bDirtyBoneMergeInfo; // bitfield:1
    public static nint m_bNetworkedPositionChanged; // bitfield:1
    public static nint m_bNetworkedAnglesChanged; // bitfield:1
    public static nint m_bNetworkedScaleChanged; // bitfield:1
    public static nint m_bWillBeCallingPostDataUpdate; // bitfield:1
    public static nint m_bBoneMergeFlex; // bitfield:1
    public static nint m_nLatchAbsOrigin; // bitfield:2
    public static nint m_bDirtyBoneMergeBoneToRoot; // bitfield:1
    public static nint m_nHierarchicalDepth; // uint8_t
    public static nint m_nHierarchyType; // uint8_t
    public static nint m_nDoNotSetAnimTimeInInvalidatePhysicsCount; // uint8_t
    public static nint m_name; // CUtlStringToken
    public static nint m_hierarchyAttachName; // CUtlStringToken
    public static nint m_flZOffset; // float
    public static nint m_vRenderOrigin; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class CGameSceneNodeHandle {
    public static nint m_hOwner; // CEntityHandle
    public static nint m_name; // CUtlStringToken
}

[OffsetsWithFilePath("client.dll.json")] public static class CGlobalLightBase {
    public static nint m_bSpotLight; // bool
    public static nint m_SpotLightOrigin; // Vector
    public static nint m_SpotLightAngles; // QAngle
    public static nint m_ShadowDirection; // Vector
    public static nint m_AmbientDirection; // Vector
    public static nint m_SpecularDirection; // Vector
    public static nint m_InspectorSpecularDirection; // Vector
    public static nint m_flSpecularPower; // float
    public static nint m_flSpecularIndependence; // float
    public static nint m_SpecularColor; // Color
    public static nint m_bStartDisabled; // bool
    public static nint m_bEnabled; // bool
    public static nint m_LightColor; // Color
    public static nint m_AmbientColor1; // Color
    public static nint m_AmbientColor2; // Color
    public static nint m_AmbientColor3; // Color
    public static nint m_flSunDistance; // float
    public static nint m_flFOV; // float
    public static nint m_flNearZ; // float
    public static nint m_flFarZ; // float
    public static nint m_bEnableShadows; // bool
    public static nint m_bOldEnableShadows; // bool
    public static nint m_bBackgroundClearNotRequired; // bool
    public static nint m_flCloudScale; // float
    public static nint m_flCloud1Speed; // float
    public static nint m_flCloud1Direction; // float
    public static nint m_flCloud2Speed; // float
    public static nint m_flCloud2Direction; // float
    public static nint m_flAmbientScale1; // float
    public static nint m_flAmbientScale2; // float
    public static nint m_flGroundScale; // float
    public static nint m_flLightScale; // float
    public static nint m_flFoWDarkness; // float
    public static nint m_bEnableSeparateSkyboxFog; // bool
    public static nint m_vFowColor; // Vector
    public static nint m_ViewOrigin; // Vector
    public static nint m_ViewAngles; // QAngle
    public static nint m_flViewFoV; // float
    public static nint m_WorldPoints; // Vector[8]
    public static nint m_vFogOffsetLayer0; // Vector2D
    public static nint m_vFogOffsetLayer1; // Vector2D
    public static nint m_hEnvWind; // CHandle<C_BaseEntity>
    public static nint m_hEnvSky; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class CGlowOverlay {
    public static nint m_vPos; // Vector
    public static nint m_bDirectional; // bool
    public static nint m_vDirection; // Vector
    public static nint m_bInSky; // bool
    public static nint m_skyObstructionScale; // float
    public static nint m_Sprites; // CGlowSprite[4]
    public static nint m_nSprites; // int32_t
    public static nint m_flProxyRadius; // float
    public static nint m_flHDRColorScale; // float
    public static nint m_flGlowObstructionScale; // float
    public static nint m_bCacheGlowObstruction; // bool
    public static nint m_bCacheSkyObstruction; // bool
    public static nint m_bActivated; // int16_t
    public static nint m_ListIndex; // uint16_t
    public static nint m_queryHandle; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CGlowProperty {
    public static nint m_fGlowColor; // Vector
    public static nint m_iGlowType; // int32_t
    public static nint m_iGlowTeam; // int32_t
    public static nint m_nGlowRange; // int32_t
    public static nint m_nGlowRangeMin; // int32_t
    public static nint m_glowColorOverride; // Color
    public static nint m_bFlashing; // bool
    public static nint m_flGlowTime; // float
    public static nint m_flGlowStartTime; // float
    public static nint m_bEligibleForScreenHighlight; // bool
    public static nint m_bGlowing; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CGlowSprite {
    public static nint m_vColor; // Vector
    public static nint m_flHorzSize; // float
    public static nint m_flVertSize; // float
    public static nint m_hMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
}

[OffsetsWithFilePath("client.dll.json")] public static class CGrenadeTracer { // C_BaseModelEntity
    public static nint m_flTracerDuration; // float
    public static nint m_nType; // GrenadeType_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CHitboxComponent { // CEntityComponent
    public static nint m_bvDisabledHitGroups; // uint32_t[1]
}

[OffsetsWithFilePath("client.dll.json")] public static class CHostageRescueZone { // CHostageRescueZoneShim
}

[OffsetsWithFilePath("client.dll.json")] public static class CHostageRescueZoneShim { // C_BaseTrigger
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoDynamicShadowHint { // C_PointEntity
    public static nint m_bDisabled; // bool
    public static nint m_flRange; // float
    public static nint m_nImportance; // int32_t
    public static nint m_nLightChoice; // int32_t
    public static nint m_hLight; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoDynamicShadowHintBox { // CInfoDynamicShadowHint
    public static nint m_vBoxMins; // Vector
    public static nint m_vBoxMaxs; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoOffscreenPanoramaTexture { // C_PointEntity
    public static nint m_bDisabled; // bool
    public static nint m_nResolutionX; // int32_t
    public static nint m_nResolutionY; // int32_t
    public static nint m_szLayoutFileName; // CUtlSymbolLarge
    public static nint m_RenderAttrName; // CUtlSymbolLarge
    public static nint m_TargetEntities; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public static nint m_nTargetChangeCount; // int32_t
    public static nint m_vecCSSClasses; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
    public static nint m_bCheckCSSClasses; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoParticleTarget { // C_PointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoTarget { // C_PointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CInfoWorldLayer { // C_BaseEntity
    public static nint m_pOutputOnEntitiesSpawned; // CEntityIOOutput
    public static nint m_worldName; // CUtlSymbolLarge
    public static nint m_layerName; // CUtlSymbolLarge
    public static nint m_bWorldLayerVisible; // bool
    public static nint m_bEntitiesSpawned; // bool
    public static nint m_bCreateAsChildSpawnGroup; // bool
    public static nint m_hLayerSpawnGroup; // uint32_t
    public static nint m_bWorldLayerActuallyVisible; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CInterpolatedValue {
    public static nint m_flStartTime; // float
    public static nint m_flEndTime; // float
    public static nint m_flStartValue; // float
    public static nint m_flEndValue; // float
    public static nint m_nInterpType; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CLightComponent { // CEntityComponent
    public static nint __m_pChainEntity; // CNetworkVarChainer
    public static nint m_Color; // Color
    public static nint m_SecondaryColor; // Color
    public static nint m_flBrightness; // float
    public static nint m_flBrightnessScale; // float
    public static nint m_flBrightnessMult; // float
    public static nint m_flRange; // float
    public static nint m_flFalloff; // float
    public static nint m_flAttenuation0; // float
    public static nint m_flAttenuation1; // float
    public static nint m_flAttenuation2; // float
    public static nint m_flTheta; // float
    public static nint m_flPhi; // float
    public static nint m_hLightCookie; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_nCascades; // int32_t
    public static nint m_nCastShadows; // int32_t
    public static nint m_nShadowWidth; // int32_t
    public static nint m_nShadowHeight; // int32_t
    public static nint m_bRenderDiffuse; // bool
    public static nint m_nRenderSpecular; // int32_t
    public static nint m_bRenderTransmissive; // bool
    public static nint m_flOrthoLightWidth; // float
    public static nint m_flOrthoLightHeight; // float
    public static nint m_nStyle; // int32_t
    public static nint m_Pattern; // CUtlString
    public static nint m_nCascadeRenderStaticObjects; // int32_t
    public static nint m_flShadowCascadeCrossFade; // float
    public static nint m_flShadowCascadeDistanceFade; // float
    public static nint m_flShadowCascadeDistance0; // float
    public static nint m_flShadowCascadeDistance1; // float
    public static nint m_flShadowCascadeDistance2; // float
    public static nint m_flShadowCascadeDistance3; // float
    public static nint m_nShadowCascadeResolution0; // int32_t
    public static nint m_nShadowCascadeResolution1; // int32_t
    public static nint m_nShadowCascadeResolution2; // int32_t
    public static nint m_nShadowCascadeResolution3; // int32_t
    public static nint m_bUsesBakedShadowing; // bool
    public static nint m_nShadowPriority; // int32_t
    public static nint m_nBakedShadowIndex; // int32_t
    public static nint m_bRenderToCubemaps; // bool
    public static nint m_nDirectLight; // int32_t
    public static nint m_nIndirectLight; // int32_t
    public static nint m_flFadeMinDist; // float
    public static nint m_flFadeMaxDist; // float
    public static nint m_flShadowFadeMinDist; // float
    public static nint m_flShadowFadeMaxDist; // float
    public static nint m_bEnabled; // bool
    public static nint m_bFlicker; // bool
    public static nint m_bPrecomputedFieldsValid; // bool
    public static nint m_vPrecomputedBoundsMins; // Vector
    public static nint m_vPrecomputedBoundsMaxs; // Vector
    public static nint m_vPrecomputedOBBOrigin; // Vector
    public static nint m_vPrecomputedOBBAngles; // QAngle
    public static nint m_vPrecomputedOBBExtent; // Vector
    public static nint m_flPrecomputedMaxRange; // float
    public static nint m_nFogLightingMode; // int32_t
    public static nint m_flFogContributionStength; // float
    public static nint m_flNearClipPlane; // float
    public static nint m_SkyColor; // Color
    public static nint m_flSkyIntensity; // float
    public static nint m_SkyAmbientBounce; // Color
    public static nint m_bUseSecondaryColor; // bool
    public static nint m_bMixedShadows; // bool
    public static nint m_flLightStyleStartTime; // GameTime_t
    public static nint m_flCapsuleLength; // float
    public static nint m_flMinRoughness; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CLogicRelay { // CLogicalEntity
    public static nint m_OnTrigger; // CEntityIOOutput
    public static nint m_OnSpawn; // CEntityIOOutput
    public static nint m_bDisabled; // bool
    public static nint m_bWaitForRefire; // bool
    public static nint m_bTriggerOnce; // bool
    public static nint m_bFastRetrigger; // bool
    public static nint m_bPassthoughCaller; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CLogicalEntity { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CModelState {
    public static nint m_hModel; // CStrongHandle<InfoForResourceTypeCModel>
    public static nint m_ModelName; // CUtlSymbolLarge
    public static nint m_bClientClothCreationSuppressed; // bool
    public static nint m_MeshGroupMask; // uint64_t
    public static nint m_nIdealMotionType; // int8_t
    public static nint m_nForceLOD; // int8_t
    public static nint m_nClothUpdateFlags; // int8_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CNetworkedSequenceOperation {
    public static nint m_hSequence; // HSequence
    public static nint m_flPrevCycle; // float
    public static nint m_flCycle; // float
    public static nint m_flWeight; // CNetworkedQuantizedFloat
    public static nint m_bSequenceChangeNetworked; // bool
    public static nint m_bDiscontinuity; // bool
    public static nint m_flPrevCycleFromDiscontinuity; // float
    public static nint m_flPrevCycleForAnimEventDetection; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayerSprayDecalRenderHelper {
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_AutoaimServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_CameraServices { // CPlayerPawnComponent
    public static nint m_vecCsViewPunchAngle; // QAngle
    public static nint m_nCsViewPunchAngleTick; // GameTick_t
    public static nint m_flCsViewPunchAngleTickRatio; // float
    public static nint m_PlayerFog; // C_fogplayerparams_t
    public static nint m_hColorCorrectionCtrl; // CHandle<C_ColorCorrection>
    public static nint m_hViewEntity; // CHandle<C_BaseEntity>
    public static nint m_hTonemapController; // CHandle<C_TonemapController2>
    public static nint m_audio; // audioparams_t
    public static nint m_PostProcessingVolumes; // C_NetworkUtlVectorBase<CHandle<C_PostProcessingVolume>>
    public static nint m_flOldPlayerZ; // float
    public static nint m_flOldPlayerViewOffsetZ; // float
    public static nint m_CurrentFog; // fogparams_t
    public static nint m_hOldFogController; // CHandle<C_FogController>
    public static nint m_bOverrideFogColor; // bool[5]
    public static nint m_OverrideFogColor; // Color[5]
    public static nint m_bOverrideFogStartEnd; // bool[5]
    public static nint m_fOverrideFogStart; // float[5]
    public static nint m_fOverrideFogEnd; // float[5]
    public static nint m_hActivePostProcessingVolume; // CHandle<C_PostProcessingVolume>
    public static nint m_angDemoViewAngles; // QAngle
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_FlashlightServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_ItemServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_MovementServices { // CPlayerPawnComponent
    public static nint m_nImpulse; // int32_t
    public static nint m_nButtons; // CInButtonState
    public static nint m_nQueuedButtonDownMask; // uint64_t
    public static nint m_nQueuedButtonChangeMask; // uint64_t
    public static nint m_nButtonDoublePressed; // uint64_t
    public static nint m_pButtonPressedCmdNumber; // uint32_t[64]
    public static nint m_nLastCommandNumberProcessed; // uint32_t
    public static nint m_nToggleButtonDownMask; // uint64_t
    public static nint m_flMaxspeed; // float
    public static nint m_arrForceSubtickMoveWhen; // float[4]
    public static nint m_flForwardMove; // float
    public static nint m_flLeftMove; // float
    public static nint m_flUpMove; // float
    public static nint m_vecLastMovementImpulses; // Vector
    public static nint m_vecOldViewAngles; // QAngle
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_MovementServices_Humanoid { // CPlayer_MovementServices
    public static nint m_flStepSoundTime; // float
    public static nint m_flFallVelocity; // float
    public static nint m_bInCrouch; // bool
    public static nint m_nCrouchState; // uint32_t
    public static nint m_flCrouchTransitionStartTime; // GameTime_t
    public static nint m_bDucked; // bool
    public static nint m_bDucking; // bool
    public static nint m_bInDuckJump; // bool
    public static nint m_groundNormal; // Vector
    public static nint m_flSurfaceFriction; // float
    public static nint m_surfaceProps; // CUtlStringToken
    public static nint m_nStepside; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_ObserverServices { // CPlayerPawnComponent
    public static nint m_iObserverMode; // uint8_t
    public static nint m_hObserverTarget; // CHandle<C_BaseEntity>
    public static nint m_iObserverLastMode; // ObserverMode_t
    public static nint m_bForcedObserverMode; // bool
    public static nint m_flObserverChaseDistance; // float
    public static nint m_flObserverChaseDistanceCalcTime; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_UseServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_ViewModelServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_WaterServices { // CPlayerPawnComponent
}

[OffsetsWithFilePath("client.dll.json")] public static class CPlayer_WeaponServices { // CPlayerPawnComponent
    public static nint m_hMyWeapons; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerWeapon>>
    public static nint m_hActiveWeapon; // CHandle<C_BasePlayerWeapon>
    public static nint m_hLastWeapon; // CHandle<C_BasePlayerWeapon>
    public static nint m_iAmmo; // uint16_t[32]
}

[OffsetsWithFilePath("client.dll.json")] public static class CPointOffScreenIndicatorUi { // C_PointClientUIWorldPanel
    public static nint m_bBeenEnabled; // bool
    public static nint m_bHide; // bool
    public static nint m_flSeenTargetTime; // float
    public static nint m_pTargetPanel; // C_PointClientUIWorldPanel*
}

[OffsetsWithFilePath("client.dll.json")] public static class CPointTemplate { // CLogicalEntity
    public static nint m_iszWorldName; // CUtlSymbolLarge
    public static nint m_iszSource2EntityLumpName; // CUtlSymbolLarge
    public static nint m_iszEntityFilterName; // CUtlSymbolLarge
    public static nint m_flTimeoutInterval; // float
    public static nint m_bAsynchronouslySpawnEntities; // bool
    public static nint m_pOutputOnSpawned; // CEntityIOOutput
    public static nint m_clientOnlyEntityBehavior; // PointTemplateClientOnlyEntityBehavior_t
    public static nint m_ownerSpawnGroupType; // PointTemplateOwnerSpawnGroupType_t
    public static nint m_createdSpawnGroupHandles; // CUtlVector<uint32_t>
    public static nint m_SpawnedEntityHandles; // CUtlVector<CEntityHandle>
    public static nint m_ScriptSpawnCallback; // HSCRIPT
    public static nint m_ScriptCallbackScope; // HSCRIPT
}

[OffsetsWithFilePath("client.dll.json")] public static class CPrecipitationVData { // CEntitySubclassVDataBase
    public static nint m_szParticlePrecipitationEffect; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>
    public static nint m_flInnerDistance; // float
    public static nint m_nAttachType; // ParticleAttachment_t
    public static nint m_bBatchSameVolumeType; // bool
    public static nint m_nRTEnvCP; // int32_t
    public static nint m_nRTEnvCPComponent; // int32_t
    public static nint m_szModifier; // CUtlString
}

[OffsetsWithFilePath("client.dll.json")] public static class CProjectedTextureBase {
    public static nint m_hTargetEntity; // CHandle<C_BaseEntity>
    public static nint m_bState; // bool
    public static nint m_bAlwaysUpdate; // bool
    public static nint m_flLightFOV; // float
    public static nint m_bEnableShadows; // bool
    public static nint m_bSimpleProjection; // bool
    public static nint m_bLightOnlyTarget; // bool
    public static nint m_bLightWorld; // bool
    public static nint m_bCameraSpace; // bool
    public static nint m_flBrightnessScale; // float
    public static nint m_LightColor; // Color
    public static nint m_flIntensity; // float
    public static nint m_flLinearAttenuation; // float
    public static nint m_flQuadraticAttenuation; // float
    public static nint m_bVolumetric; // bool
    public static nint m_flVolumetricIntensity; // float
    public static nint m_flNoiseStrength; // float
    public static nint m_flFlashlightTime; // float
    public static nint m_nNumPlanes; // uint32_t
    public static nint m_flPlaneOffset; // float
    public static nint m_flColorTransitionTime; // float
    public static nint m_flAmbient; // float
    public static nint m_SpotlightTextureName; // char[512]
    public static nint m_nSpotlightTextureFrame; // int32_t
    public static nint m_nShadowQuality; // uint32_t
    public static nint m_flNearZ; // float
    public static nint m_flFarZ; // float
    public static nint m_flProjectionSize; // float
    public static nint m_flRotation; // float
    public static nint m_bFlipHorizontal; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CPulseGraphInstance_ClientEntity { // CBasePulseGraphInstance
    public static nint m_pParent; // CClientScriptEntity*
}

[OffsetsWithFilePath("client.dll.json")] public static class CRenderComponent { // CEntityComponent
    public static nint __m_pChainEntity; // CNetworkVarChainer
    public static nint m_bIsRenderingWithViewModels; // bool
    public static nint m_nSplitscreenFlags; // uint32_t
    public static nint m_bEnableRendering; // bool
    public static nint m_bInterpolationReadyToDraw; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CSMatchStats_t { // CSPerRoundStats_t
    public static nint m_iEnemy5Ks; // int32_t
    public static nint m_iEnemy4Ks; // int32_t
    public static nint m_iEnemy3Ks; // int32_t
    public static nint m_iEnemyKnifeKills; // int32_t
    public static nint m_iEnemyTaserKills; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CSPerRoundStats_t {
    public static nint m_iKills; // int32_t
    public static nint m_iDeaths; // int32_t
    public static nint m_iAssists; // int32_t
    public static nint m_iDamage; // int32_t
    public static nint m_iEquipmentValue; // int32_t
    public static nint m_iMoneySaved; // int32_t
    public static nint m_iKillReward; // int32_t
    public static nint m_iLiveTime; // int32_t
    public static nint m_iHeadShotKills; // int32_t
    public static nint m_iObjective; // int32_t
    public static nint m_iCashEarned; // int32_t
    public static nint m_iUtilityDamage; // int32_t
    public static nint m_iEnemiesFlashed; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CScriptComponent { // CEntityComponent
    public static nint m_scriptClassName; // CUtlSymbolLarge
}

[OffsetsWithFilePath("client.dll.json")] public static class CServerOnlyModelEntity { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CSkeletonInstance { // CGameSceneNode
    public static nint m_modelState; // CModelState
    public static nint m_bIsAnimationEnabled; // bool
    public static nint m_bUseParentRenderBounds; // bool
    public static nint m_bDisableSolidCollisionsForHierarchy; // bool
    public static nint m_bDirtyMotionType; // bitfield:1
    public static nint m_bIsGeneratingLatchedParentSpaceState; // bitfield:1
    public static nint m_materialGroup; // CUtlStringToken
    public static nint m_nHitboxSet; // uint8_t
}

[OffsetsWithFilePath("client.dll.json")] public static class CSkyboxReference { // C_BaseEntity
    public static nint m_worldGroupId; // WorldGroupId_t
    public static nint m_hSkyCamera; // CHandle<C_SkyCamera>
}

[OffsetsWithFilePath("client.dll.json")] public static class CTablet { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class CTakeDamageInfoAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class CTimeline { // IntervalTimer
    public static nint m_flValues; // float[64]
    public static nint m_nValueCounts; // int32_t[64]
    public static nint m_nBucketCount; // int32_t
    public static nint m_flInterval; // float
    public static nint m_flFinalValue; // float
    public static nint m_nCompressionType; // TimelineCompression_t
    public static nint m_bStopped; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CTripWireFire { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class CTripWireFireProjectile { // C_BaseGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class CWaterSplasher { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class CWeaponZoneRepulsor { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_AK47 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_AttributeContainer { // CAttributeManager
    public static nint m_Item; // C_EconItemView
    public static nint m_iExternalItemProviderRegisteredToken; // int32_t
    public static nint m_ullRegisteredAsItemID; // uint64_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BarnLight { // C_BaseModelEntity
    public static nint m_bEnabled; // bool
    public static nint m_nColorMode; // int32_t
    public static nint m_Color; // Color
    public static nint m_flColorTemperature; // float
    public static nint m_flBrightness; // float
    public static nint m_flBrightnessScale; // float
    public static nint m_nDirectLight; // int32_t
    public static nint m_nBakedShadowIndex; // int32_t
    public static nint m_nLuminaireShape; // int32_t
    public static nint m_flLuminaireSize; // float
    public static nint m_flLuminaireAnisotropy; // float
    public static nint m_LightStyleString; // CUtlString
    public static nint m_flLightStyleStartTime; // GameTime_t
    public static nint m_QueuedLightStyleStrings; // C_NetworkUtlVectorBase<CUtlString>
    public static nint m_LightStyleEvents; // C_NetworkUtlVectorBase<CUtlString>
    public static nint m_LightStyleTargets; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public static nint m_StyleEvent; // CEntityIOOutput[4]
    public static nint m_hLightCookie; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_flShape; // float
    public static nint m_flSoftX; // float
    public static nint m_flSoftY; // float
    public static nint m_flSkirt; // float
    public static nint m_flSkirtNear; // float
    public static nint m_vSizeParams; // Vector
    public static nint m_flRange; // float
    public static nint m_vShear; // Vector
    public static nint m_nBakeSpecularToCubemaps; // int32_t
    public static nint m_vBakeSpecularToCubemapsSize; // Vector
    public static nint m_nCastShadows; // int32_t
    public static nint m_nShadowMapSize; // int32_t
    public static nint m_nShadowPriority; // int32_t
    public static nint m_bContactShadow; // bool
    public static nint m_nBounceLight; // int32_t
    public static nint m_flBounceScale; // float
    public static nint m_flMinRoughness; // float
    public static nint m_vAlternateColor; // Vector
    public static nint m_fAlternateColorBrightness; // float
    public static nint m_nFog; // int32_t
    public static nint m_flFogStrength; // float
    public static nint m_nFogShadows; // int32_t
    public static nint m_flFogScale; // float
    public static nint m_flFadeSizeStart; // float
    public static nint m_flFadeSizeEnd; // float
    public static nint m_flShadowFadeSizeStart; // float
    public static nint m_flShadowFadeSizeEnd; // float
    public static nint m_bPrecomputedFieldsValid; // bool
    public static nint m_vPrecomputedBoundsMins; // Vector
    public static nint m_vPrecomputedBoundsMaxs; // Vector
    public static nint m_vPrecomputedOBBOrigin; // Vector
    public static nint m_vPrecomputedOBBAngles; // QAngle
    public static nint m_vPrecomputedOBBExtent; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseButton { // C_BaseToggle
    public static nint m_glowEntity; // CHandle<C_BaseModelEntity>
    public static nint m_usable; // bool
    public static nint m_szDisplayText; // CUtlSymbolLarge
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseCSGrenade { // C_CSWeaponBase
    public static nint m_bClientPredictDelete; // bool
    public static nint m_bRedraw; // bool
    public static nint m_bIsHeldByPlayer; // bool
    public static nint m_bPinPulled; // bool
    public static nint m_bJumpThrow; // bool
    public static nint m_bThrowAnimating; // bool
    public static nint m_fThrowTime; // GameTime_t
    public static nint m_flThrowStrength; // float
    public static nint m_flThrowStrengthApproach; // float
    public static nint m_fDropTime; // GameTime_t
    public static nint m_bJustPulledPin; // bool
    public static nint m_nNextHoldTick; // GameTick_t
    public static nint m_flNextHoldFrac; // float
    public static nint m_hSwitchToWeaponAfterThrow; // CHandle<C_CSWeaponBase>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseCSGrenadeProjectile { // C_BaseGrenade
    public static nint m_vInitialPosition; // Vector
    public static nint m_vInitialVelocity; // Vector
    public static nint m_nBounces; // int32_t
    public static nint m_nExplodeEffectIndex; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public static nint m_nExplodeEffectTickBegin; // int32_t
    public static nint m_vecExplodeEffectOrigin; // Vector
    public static nint m_flSpawnTime; // GameTime_t
    public static nint vecLastTrailLinePos; // Vector
    public static nint flNextTrailLineTime; // GameTime_t
    public static nint m_bExplodeEffectBegan; // bool
    public static nint m_bCanCreateGrenadeTrail; // bool
    public static nint m_nSnapshotTrajectoryEffectIndex; // ParticleIndex_t
    public static nint m_hSnapshotTrajectoryParticleSnapshot; // CStrongHandle<InfoForResourceTypeIParticleSnapshot>
    public static nint m_arrTrajectoryTrailPoints; // CUtlVector<Vector>
    public static nint m_arrTrajectoryTrailPointCreationTimes; // CUtlVector<float>
    public static nint m_flTrajectoryTrailEffectCreationTime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseClientUIEntity { // C_BaseModelEntity
    public static nint m_bEnabled; // bool
    public static nint m_DialogXMLName; // CUtlSymbolLarge
    public static nint m_PanelClassName; // CUtlSymbolLarge
    public static nint m_PanelID; // CUtlSymbolLarge
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseCombatCharacter { // C_BaseFlex
    public static nint m_hMyWearables; // C_NetworkUtlVectorBase<CHandle<C_EconWearable>>
    public static nint m_bloodColor; // int32_t
    public static nint m_leftFootAttachment; // AttachmentHandle_t
    public static nint m_rightFootAttachment; // AttachmentHandle_t
    public static nint m_nWaterWakeMode; // C_BaseCombatCharacter::WaterWakeMode_t
    public static nint m_flWaterWorldZ; // float
    public static nint m_flWaterNextTraceTime; // float
    public static nint m_flFieldOfView; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseDoor { // C_BaseToggle
    public static nint m_bIsUsable; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseEntity { // CEntityInstance
    public static nint m_CBodyComponent; // CBodyComponent*
    public static nint m_NetworkTransmitComponent; // CNetworkTransmitComponent
    public static nint m_nLastThinkTick; // GameTick_t
    public static nint m_pGameSceneNode; // CGameSceneNode*
    public static nint m_pRenderComponent; // CRenderComponent*
    public static nint m_pCollision; // CCollisionProperty*
    public static nint m_iMaxHealth; // int32_t
    public static nint m_iHealth; // int32_t
    public static nint m_lifeState; // uint8_t
    public static nint m_bTakesDamage; // bool
    public static nint m_nTakeDamageFlags; // TakeDamageFlags_t
    public static nint m_bIsPlatform; // bool
    public static nint m_ubInterpolationFrame; // uint8_t
    public static nint m_hSceneObjectController; // CHandle<C_BaseEntity>
    public static nint m_nNoInterpolationTick; // int32_t
    public static nint m_nVisibilityNoInterpolationTick; // int32_t
    public static nint m_flProxyRandomValue; // float
    public static nint m_iEFlags; // int32_t
    public static nint m_nWaterType; // uint8_t
    public static nint m_bInterpolateEvenWithNoModel; // bool
    public static nint m_bPredictionEligible; // bool
    public static nint m_bApplyLayerMatchIDToModel; // bool
    public static nint m_tokLayerMatchID; // CUtlStringToken
    public static nint m_nSubclassID; // CUtlStringToken
    public static nint m_nSimulationTick; // int32_t
    public static nint m_iCurrentThinkContext; // int32_t
    public static nint m_aThinkFunctions; // CUtlVector<thinkfunc_t>
    public static nint m_nDisableContextThinkStartTick; // GameTick_t
    public static nint m_flAnimTime; // float
    public static nint m_flSimulationTime; // float
    public static nint m_nSceneObjectOverrideFlags; // uint8_t
    public static nint m_bHasSuccessfullyInterpolated; // bool
    public static nint m_bHasAddedVarsToInterpolation; // bool
    public static nint m_bRenderEvenWhenNotSuccessfullyInterpolated; // bool
    public static nint m_nInterpolationLatchDirtyFlags; // int32_t[2]
    public static nint m_ListEntry; // uint16_t[11]
    public static nint m_flCreateTime; // GameTime_t
    public static nint m_flSpeed; // float
    public static nint m_EntClientFlags; // uint16_t
    public static nint m_bClientSideRagdoll; // bool
    public static nint m_iTeamNum; // uint8_t
    public static nint m_spawnflags; // uint32_t
    public static nint m_nNextThinkTick; // GameTick_t
    public static nint m_fFlags; // uint32_t
    public static nint m_vecAbsVelocity; // Vector
    public static nint m_vecVelocity; // CNetworkVelocityVector
    public static nint m_vecBaseVelocity; // Vector
    public static nint m_hEffectEntity; // CHandle<C_BaseEntity>
    public static nint m_hOwnerEntity; // CHandle<C_BaseEntity>
    public static nint m_MoveCollide; // MoveCollide_t
    public static nint m_MoveType; // MoveType_t
    public static nint m_nActualMoveType; // MoveType_t
    public static nint m_flWaterLevel; // float
    public static nint m_fEffects; // uint32_t
    public static nint m_hGroundEntity; // CHandle<C_BaseEntity>
    public static nint m_flFriction; // float
    public static nint m_flElasticity; // float
    public static nint m_flGravityScale; // float
    public static nint m_flTimeScale; // float
    public static nint m_bAnimatedEveryTick; // bool
    public static nint m_flNavIgnoreUntilTime; // GameTime_t
    public static nint m_hThink; // uint16_t
    public static nint m_fBBoxVisFlags; // uint8_t
    public static nint m_bPredictable; // bool
    public static nint m_bRenderWithViewModels; // bool
    public static nint m_nSplitUserPlayerPredictionSlot; // CSplitScreenSlot
    public static nint m_nFirstPredictableCommand; // int32_t
    public static nint m_nLastPredictableCommand; // int32_t
    public static nint m_hOldMoveParent; // CHandle<C_BaseEntity>
    public static nint m_Particles; // CParticleProperty
    public static nint m_vecPredictedScriptFloats; // CUtlVector<float>
    public static nint m_vecPredictedScriptFloatIDs; // CUtlVector<int32_t>
    public static nint m_nNextScriptVarRecordID; // int32_t
    public static nint m_vecAngVelocity; // QAngle
    public static nint m_DataChangeEventRef; // int32_t
    public static nint m_dependencies; // CUtlVector<CEntityHandle>
    public static nint m_nCreationTick; // int32_t
    public static nint m_bAnimTimeChanged; // bool
    public static nint m_bSimulationTimeChanged; // bool
    public static nint m_sUniqueHammerID; // CUtlString
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseEntityAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseFire { // C_BaseEntity
    public static nint m_flScale; // float
    public static nint m_flStartScale; // float
    public static nint m_flScaleTime; // float
    public static nint m_nFlags; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseFlex { // CBaseAnimGraph
    public static nint m_flexWeight; // C_NetworkUtlVectorBase<float>
    public static nint m_vLookTargetPosition; // Vector
    public static nint m_blinktoggle; // bool
    public static nint m_nLastFlexUpdateFrameCount; // int32_t
    public static nint m_CachedViewTarget; // Vector
    public static nint m_nNextSceneEventId; // uint32_t
    public static nint m_iBlink; // int32_t
    public static nint m_blinktime; // float
    public static nint m_prevblinktoggle; // bool
    public static nint m_iJawOpen; // int32_t
    public static nint m_flJawOpenAmount; // float
    public static nint m_flBlinkAmount; // float
    public static nint m_iMouthAttachment; // AttachmentHandle_t
    public static nint m_iEyeAttachment; // AttachmentHandle_t
    public static nint m_bResetFlexWeightsOnModelChange; // bool
    public static nint m_nEyeOcclusionRendererBone; // int32_t
    public static nint m_mEyeOcclusionRendererCameraToBoneTransform; // matrix3x4_t
    public static nint m_vEyeOcclusionRendererHalfExtent; // Vector
    public static nint m_PhonemeClasses; // C_BaseFlex::Emphasized_Phoneme[3]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseFlex_Emphasized_Phoneme {
    public static nint m_sClassName; // CUtlString
    public static nint m_flAmount; // float
    public static nint m_bRequired; // bool
    public static nint m_bBasechecked; // bool
    public static nint m_bValid; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseGrenade { // C_BaseFlex
    public static nint m_bHasWarnedAI; // bool
    public static nint m_bIsSmokeGrenade; // bool
    public static nint m_bIsLive; // bool
    public static nint m_DmgRadius; // float
    public static nint m_flDetonateTime; // GameTime_t
    public static nint m_flWarnAITime; // float
    public static nint m_flDamage; // float
    public static nint m_iszBounceSound; // CUtlSymbolLarge
    public static nint m_ExplosionSound; // CUtlString
    public static nint m_hThrower; // CHandle<C_CSPlayerPawn>
    public static nint m_flNextAttack; // GameTime_t
    public static nint m_hOriginalThrower; // CHandle<C_CSPlayerPawn>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseModelEntity { // C_BaseEntity
    public static nint m_CRenderComponent; // CRenderComponent*
    public static nint m_CHitboxComponent; // CHitboxComponent
    public static nint m_bInitModelEffects; // bool
    public static nint m_bIsStaticProp; // bool
    public static nint m_nLastAddDecal; // int32_t
    public static nint m_nDecalsAdded; // int32_t
    public static nint m_iOldHealth; // int32_t
    public static nint m_nRenderMode; // RenderMode_t
    public static nint m_nRenderFX; // RenderFx_t
    public static nint m_bAllowFadeInView; // bool
    public static nint m_clrRender; // Color
    public static nint m_vecRenderAttributes; // C_UtlVectorEmbeddedNetworkVar<EntityRenderAttribute_t>
    public static nint m_bRenderToCubemaps; // bool
    public static nint m_Collision; // CCollisionProperty
    public static nint m_Glow; // CGlowProperty
    public static nint m_flGlowBackfaceMult; // float
    public static nint m_fadeMinDist; // float
    public static nint m_fadeMaxDist; // float
    public static nint m_flFadeScale; // float
    public static nint m_flShadowStrength; // float
    public static nint m_nObjectCulling; // uint8_t
    public static nint m_nAddDecal; // int32_t
    public static nint m_vDecalPosition; // Vector
    public static nint m_vDecalForwardAxis; // Vector
    public static nint m_flDecalHealBloodRate; // float
    public static nint m_flDecalHealHeightRate; // float
    public static nint m_ConfigEntitiesToPropagateMaterialDecalsTo; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public static nint m_vecViewOffset; // CNetworkViewOffsetVector
    public static nint m_pClientAlphaProperty; // CClientAlphaProperty*
    public static nint m_ClientOverrideTint; // Color
    public static nint m_bUseClientOverrideTint; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BasePlayerPawn { // C_BaseCombatCharacter
    public static nint m_pWeaponServices; // CPlayer_WeaponServices*
    public static nint m_pItemServices; // CPlayer_ItemServices*
    public static nint m_pAutoaimServices; // CPlayer_AutoaimServices*
    public static nint m_pObserverServices; // CPlayer_ObserverServices*
    public static nint m_pWaterServices; // CPlayer_WaterServices*
    public static nint m_pUseServices; // CPlayer_UseServices*
    public static nint m_pFlashlightServices; // CPlayer_FlashlightServices*
    public static nint m_pCameraServices; // CPlayer_CameraServices*
    public static nint m_pMovementServices; // CPlayer_MovementServices*
    public static nint m_ServerViewAngleChanges; // C_UtlVectorEmbeddedNetworkVar<ViewAngleServerChange_t>
    public static nint m_nHighestConsumedServerViewAngleChangeIndex; // uint32_t
    public static nint v_angle; // QAngle
    public static nint v_anglePrevious; // QAngle
    public static nint m_iHideHUD; // uint32_t
    public static nint m_skybox3d; // sky3dparams_t
    public static nint m_flDeathTime; // GameTime_t
    public static nint m_vecPredictionError; // Vector
    public static nint m_flPredictionErrorTime; // GameTime_t
    public static nint m_vecLastCameraSetupLocalOrigin; // Vector
    public static nint m_flLastCameraSetupTime; // GameTime_t
    public static nint m_flFOVSensitivityAdjust; // float
    public static nint m_flMouseSensitivity; // float
    public static nint m_vOldOrigin; // Vector
    public static nint m_flOldSimulationTime; // float
    public static nint m_nLastExecutedCommandNumber; // int32_t
    public static nint m_nLastExecutedCommandTick; // int32_t
    public static nint m_hController; // CHandle<CBasePlayerController>
    public static nint m_bIsSwappingToPredictableController; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BasePlayerWeapon { // C_EconEntity
    public static nint m_nNextPrimaryAttackTick; // GameTick_t
    public static nint m_flNextPrimaryAttackTickRatio; // float
    public static nint m_nNextSecondaryAttackTick; // GameTick_t
    public static nint m_flNextSecondaryAttackTickRatio; // float
    public static nint m_iClip1; // int32_t
    public static nint m_iClip2; // int32_t
    public static nint m_pReserveAmmo; // int32_t[2]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BasePropDoor { // C_DynamicProp
    public static nint m_eDoorState; // DoorState_t
    public static nint m_modelChanged; // bool
    public static nint m_bLocked; // bool
    public static nint m_closedPosition; // Vector
    public static nint m_closedAngles; // QAngle
    public static nint m_hMaster; // CHandle<C_BasePropDoor>
    public static nint m_vWhereToSetLightingOrigin; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseToggle { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseTrigger { // C_BaseToggle
    public static nint m_bDisabled; // bool
    public static nint m_bClientSidePredicted; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BaseViewModel { // CBaseAnimGraph
    public static nint m_vecLastFacing; // Vector
    public static nint m_nViewModelIndex; // uint32_t
    public static nint m_nAnimationParity; // uint32_t
    public static nint m_flAnimationStartTime; // float
    public static nint m_hWeapon; // CHandle<C_BasePlayerWeapon>
    public static nint m_sVMName; // CUtlSymbolLarge
    public static nint m_sAnimationPrefix; // CUtlSymbolLarge
    public static nint m_hWeaponModel; // CHandle<C_ViewmodelWeapon>
    public static nint m_iCameraAttachment; // AttachmentHandle_t
    public static nint m_vecLastCameraAngles; // QAngle
    public static nint m_previousElapsedDuration; // float
    public static nint m_previousCycle; // float
    public static nint m_nOldAnimationParity; // int32_t
    public static nint m_hOldLayerSequence; // HSequence
    public static nint m_oldLayer; // int32_t
    public static nint m_oldLayerStartTime; // float
    public static nint m_hControlPanel; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Beam { // C_BaseModelEntity
    public static nint m_flFrameRate; // float
    public static nint m_flHDRColorScale; // float
    public static nint m_flFireTime; // GameTime_t
    public static nint m_flDamage; // float
    public static nint m_nNumBeamEnts; // uint8_t
    public static nint m_queryHandleHalo; // int32_t
    public static nint m_hBaseMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_nHaloIndex; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_nBeamType; // BeamType_t
    public static nint m_nBeamFlags; // uint32_t
    public static nint m_hAttachEntity; // CHandle<C_BaseEntity>[10]
    public static nint m_nAttachIndex; // AttachmentHandle_t[10]
    public static nint m_fWidth; // float
    public static nint m_fEndWidth; // float
    public static nint m_fFadeLength; // float
    public static nint m_fHaloScale; // float
    public static nint m_fAmplitude; // float
    public static nint m_fStartFrame; // float
    public static nint m_fSpeed; // float
    public static nint m_flFrame; // float
    public static nint m_nClipStyle; // BeamClipStyle_t
    public static nint m_bTurnedOff; // bool
    public static nint m_vecEndPos; // Vector
    public static nint m_hEndEntity; // CHandle<C_BaseEntity>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Breakable { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BreakableProp { // CBaseProp
    public static nint m_OnBreak; // CEntityIOOutput
    public static nint m_OnHealthChanged; // CEntityOutputTemplate<float>
    public static nint m_OnTakeDamage; // CEntityIOOutput
    public static nint m_impactEnergyScale; // float
    public static nint m_iMinHealthDmg; // int32_t
    public static nint m_flPressureDelay; // float
    public static nint m_hBreaker; // CHandle<C_BaseEntity>
    public static nint m_PerformanceMode; // PerformanceMode_t
    public static nint m_flDmgModBullet; // float
    public static nint m_flDmgModClub; // float
    public static nint m_flDmgModExplosive; // float
    public static nint m_flDmgModFire; // float
    public static nint m_iszPhysicsDamageTableName; // CUtlSymbolLarge
    public static nint m_iszBasePropData; // CUtlSymbolLarge
    public static nint m_iInteractions; // int32_t
    public static nint m_flPreventDamageBeforeTime; // GameTime_t
    public static nint m_bHasBreakPiecesOrCommands; // bool
    public static nint m_explodeDamage; // float
    public static nint m_explodeRadius; // float
    public static nint m_explosionDelay; // float
    public static nint m_explosionBuildupSound; // CUtlSymbolLarge
    public static nint m_explosionCustomEffect; // CUtlSymbolLarge
    public static nint m_explosionCustomSound; // CUtlSymbolLarge
    public static nint m_explosionModifier; // CUtlSymbolLarge
    public static nint m_hPhysicsAttacker; // CHandle<C_BasePlayerPawn>
    public static nint m_flLastPhysicsInfluenceTime; // GameTime_t
    public static nint m_flDefaultFadeScale; // float
    public static nint m_hLastAttacker; // CHandle<C_BaseEntity>
    public static nint m_hFlareEnt; // CHandle<C_BaseEntity>
    public static nint m_noGhostCollision; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_BulletHitModel { // CBaseAnimGraph
    public static nint m_matLocal; // matrix3x4_t
    public static nint m_iBoneIndex; // int32_t
    public static nint m_hPlayerParent; // CHandle<C_BaseEntity>
    public static nint m_bIsHit; // bool
    public static nint m_flTimeCreated; // float
    public static nint m_vecStartPos; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_C4 { // C_CSWeaponBase
    public static nint m_szScreenText; // char[32]
    public static nint m_activeLightParticleIndex; // ParticleIndex_t
    public static nint m_eActiveLightEffect; // C4LightEffect_t
    public static nint m_bStartedArming; // bool
    public static nint m_fArmedTime; // GameTime_t
    public static nint m_bBombPlacedAnimation; // bool
    public static nint m_bIsPlantingViaUse; // bool
    public static nint m_entitySpottedState; // EntitySpottedState_t
    public static nint m_nSpotRules; // int32_t
    public static nint m_bPlayedArmingBeeps; // bool[7]
    public static nint m_bBombPlanted; // bool
    public static nint m_bDroppedFromDeath; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGOViewModel { // C_PredictedViewModel
    public static nint m_bShouldIgnoreOffsetAndAccuracy; // bool
    public static nint m_nWeaponParity; // uint32_t
    public static nint m_nOldWeaponParity; // uint32_t
    public static nint m_nLastKnownAssociatedWeaponEntIndex; // CEntityIndex
    public static nint m_bNeedToQueueHighResComposite; // bool
    public static nint m_vLoweredWeaponOffset; // QAngle
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_CounterTerroristTeamIntroCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_CounterTerroristWingmanIntroCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_EndOfMatchCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_EndOfMatchCharacterPosition { // C_CSGO_TeamPreviewCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_EndOfMatchLineupEnd { // C_CSGO_EndOfMatchLineupEndpoint
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_EndOfMatchLineupEndpoint { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_EndOfMatchLineupStart { // C_CSGO_EndOfMatchLineupEndpoint
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_MapPreviewCameraPath { // C_BaseEntity
    public static nint m_flZFar; // float
    public static nint m_flZNear; // float
    public static nint m_bLoop; // bool
    public static nint m_bVerticalFOV; // bool
    public static nint m_bConstantSpeed; // bool
    public static nint m_flDuration; // float
    public static nint m_flPathLength; // float
    public static nint m_flPathDuration; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_MapPreviewCameraPathNode { // C_BaseEntity
    public static nint m_szParentPathUniqueID; // CUtlSymbolLarge
    public static nint m_nPathIndex; // int32_t
    public static nint m_vInTangentLocal; // Vector
    public static nint m_vOutTangentLocal; // Vector
    public static nint m_flFOV; // float
    public static nint m_flSpeed; // float
    public static nint m_flEaseIn; // float
    public static nint m_flEaseOut; // float
    public static nint m_vInTangentWorld; // Vector
    public static nint m_vOutTangentWorld; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewModel { // C_BaseFlex
    public static nint m_animgraph; // CUtlString
    public static nint m_animgraphCharacterModeString; // CGlobalSymbol
    public static nint m_defaultAnim; // CUtlString
    public static nint m_nDefaultAnimLoopMode; // AnimLoopMode_t
    public static nint m_flInitialModelScale; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewModelAlias_csgo_item_previewmodel { // C_CSGO_PreviewModel
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewModel_GraphController { // CAnimGraphControllerBase
    public static nint m_pszCharacterMode; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszWeaponState; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszWeaponType; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszEndOfMatchCelebration; // CAnimGraphParamOptionalRef<char*>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewPlayer { // C_CSPlayerPawn
    public static nint m_animgraph; // CUtlString
    public static nint m_animgraphCharacterModeString; // CGlobalSymbol
    public static nint m_flInitialModelScale; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel { // C_CSGO_PreviewPlayer
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_PreviewPlayer_GraphController { // CAnimGraphControllerBase
    public static nint m_pszCharacterMode; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszTeamPreviewVariant; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszTeamPreviewPosition; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszEndOfMatchCelebration; // CAnimGraphParamOptionalRef<char*>
    public static nint m_nTeamPreviewRandom; // CAnimGraphParamOptionalRef<int32_t>
    public static nint m_pszWeaponState; // CAnimGraphParamOptionalRef<char*>
    public static nint m_pszWeaponType; // CAnimGraphParamOptionalRef<char*>
    public static nint m_bCT; // CAnimGraphParamOptionalRef<bool>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamIntroCharacterPosition { // C_CSGO_TeamPreviewCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamIntroCounterTerroristPosition { // C_CSGO_TeamIntroCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamIntroTerroristPosition { // C_CSGO_TeamIntroCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamPreviewCamera { // C_CSGO_MapPreviewCameraPath
    public static nint m_nVariant; // int32_t
    public static nint m_bDofEnabled; // bool
    public static nint m_flDofNearBlurry; // float
    public static nint m_flDofNearCrisp; // float
    public static nint m_flDofFarCrisp; // float
    public static nint m_flDofFarBlurry; // float
    public static nint m_flDofTiltToGround; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamPreviewCharacterPosition { // C_BaseEntity
    public static nint m_nVariant; // int32_t
    public static nint m_nRandom; // int32_t
    public static nint m_nOrdinal; // int32_t
    public static nint m_sWeaponName; // CUtlString
    public static nint m_xuid; // uint64_t
    public static nint m_agentItem; // C_EconItemView
    public static nint m_glovesItem; // C_EconItemView
    public static nint m_weaponItem; // C_EconItemView
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamPreviewModel { // C_CSGO_PreviewPlayer
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamSelectCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamSelectCharacterPosition { // C_CSGO_TeamPreviewCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamSelectCounterTerroristPosition { // C_CSGO_TeamSelectCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TeamSelectTerroristPosition { // C_CSGO_TeamSelectCharacterPosition
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TerroristTeamIntroCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGO_TerroristWingmanIntroCamera { // C_CSGO_TeamPreviewCamera
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGameRules { // C_TeamplayRules
    public static nint __m_pChainEntity; // CNetworkVarChainer
    public static nint m_bFreezePeriod; // bool
    public static nint m_bWarmupPeriod; // bool
    public static nint m_fWarmupPeriodEnd; // GameTime_t
    public static nint m_fWarmupPeriodStart; // GameTime_t
    public static nint m_nTotalPausedTicks; // int32_t
    public static nint m_nPauseStartTick; // int32_t
    public static nint m_bServerPaused; // bool
    public static nint m_bGamePaused; // bool
    public static nint m_bTerroristTimeOutActive; // bool
    public static nint m_bCTTimeOutActive; // bool
    public static nint m_flTerroristTimeOutRemaining; // float
    public static nint m_flCTTimeOutRemaining; // float
    public static nint m_nTerroristTimeOuts; // int32_t
    public static nint m_nCTTimeOuts; // int32_t
    public static nint m_bTechnicalTimeOut; // bool
    public static nint m_bMatchWaitingForResume; // bool
    public static nint m_iRoundTime; // int32_t
    public static nint m_fMatchStartTime; // float
    public static nint m_fRoundStartTime; // GameTime_t
    public static nint m_flRestartRoundTime; // GameTime_t
    public static nint m_bGameRestart; // bool
    public static nint m_flGameStartTime; // float
    public static nint m_timeUntilNextPhaseStarts; // float
    public static nint m_gamePhase; // int32_t
    public static nint m_totalRoundsPlayed; // int32_t
    public static nint m_nRoundsPlayedThisPhase; // int32_t
    public static nint m_nOvertimePlaying; // int32_t
    public static nint m_iHostagesRemaining; // int32_t
    public static nint m_bAnyHostageReached; // bool
    public static nint m_bMapHasBombTarget; // bool
    public static nint m_bMapHasRescueZone; // bool
    public static nint m_bMapHasBuyZone; // bool
    public static nint m_bIsQueuedMatchmaking; // bool
    public static nint m_nQueuedMatchmakingMode; // int32_t
    public static nint m_bIsValveDS; // bool
    public static nint m_bLogoMap; // bool
    public static nint m_bPlayAllStepSoundsOnServer; // bool
    public static nint m_iSpectatorSlotCount; // int32_t
    public static nint m_MatchDevice; // int32_t
    public static nint m_bHasMatchStarted; // bool
    public static nint m_nNextMapInMapgroup; // int32_t
    public static nint m_szTournamentEventName; // char[512]
    public static nint m_szTournamentEventStage; // char[512]
    public static nint m_szMatchStatTxt; // char[512]
    public static nint m_szTournamentPredictionsTxt; // char[512]
    public static nint m_nTournamentPredictionsPct; // int32_t
    public static nint m_flCMMItemDropRevealStartTime; // GameTime_t
    public static nint m_flCMMItemDropRevealEndTime; // GameTime_t
    public static nint m_bIsDroppingItems; // bool
    public static nint m_bIsQuestEligible; // bool
    public static nint m_bIsHltvActive; // bool
    public static nint m_nGuardianModeWaveNumber; // int32_t
    public static nint m_nGuardianModeSpecialKillsRemaining; // int32_t
    public static nint m_nGuardianModeSpecialWeaponNeeded; // int32_t
    public static nint m_nGuardianGrenadesToGiveBots; // int32_t
    public static nint m_nNumHeaviesToSpawn; // int32_t
    public static nint m_numGlobalGiftsGiven; // uint32_t
    public static nint m_numGlobalGifters; // uint32_t
    public static nint m_numGlobalGiftsPeriodSeconds; // uint32_t
    public static nint m_arrFeaturedGiftersAccounts; // uint32_t[4]
    public static nint m_arrFeaturedGiftersGifts; // uint32_t[4]
    public static nint m_arrProhibitedItemIndices; // uint16_t[100]
    public static nint m_arrTournamentActiveCasterAccounts; // uint32_t[4]
    public static nint m_numBestOfMaps; // int32_t
    public static nint m_nHalloweenMaskListSeed; // int32_t
    public static nint m_bBombDropped; // bool
    public static nint m_bBombPlanted; // bool
    public static nint m_iRoundWinStatus; // int32_t
    public static nint m_eRoundWinReason; // int32_t
    public static nint m_bTCantBuy; // bool
    public static nint m_bCTCantBuy; // bool
    public static nint m_flGuardianBuyUntilTime; // GameTime_t
    public static nint m_iMatchStats_RoundResults; // int32_t[30]
    public static nint m_iMatchStats_PlayersAlive_CT; // int32_t[30]
    public static nint m_iMatchStats_PlayersAlive_T; // int32_t[30]
    public static nint m_TeamRespawnWaveTimes; // float[32]
    public static nint m_flNextRespawnWave; // GameTime_t[32]
    public static nint m_nServerQuestID; // int32_t
    public static nint m_vMinimapMins; // Vector
    public static nint m_vMinimapMaxs; // Vector
    public static nint m_MinimapVerticalSectionHeights; // float[8]
    public static nint m_bDontIncrementCoopWave; // bool
    public static nint m_bSpawnedTerrorHuntHeavy; // bool
    public static nint m_nEndMatchMapGroupVoteTypes; // int32_t[10]
    public static nint m_nEndMatchMapGroupVoteOptions; // int32_t[10]
    public static nint m_nEndMatchMapVoteWinner; // int32_t
    public static nint m_iNumConsecutiveCTLoses; // int32_t
    public static nint m_iNumConsecutiveTerroristLoses; // int32_t
    public static nint m_bMarkClientStopRecordAtRoundEnd; // bool
    public static nint m_nMatchAbortedEarlyReason; // int32_t
    public static nint m_bHasTriggeredRoundStartMusic; // bool
    public static nint m_bHasTriggeredCoopSpawnReset; // bool
    public static nint m_bSwitchingTeamsAtRoundReset; // bool
    public static nint m_pGameModeRules; // CCSGameModeRules*
    public static nint m_RetakeRules; // C_RetakeGameRules
    public static nint m_nMatchEndCount; // uint8_t
    public static nint m_nTTeamIntroVariant; // int32_t
    public static nint m_nCTTeamIntroVariant; // int32_t
    public static nint m_bTeamIntroPeriod; // bool
    public static nint m_iRoundEndWinnerTeam; // int32_t
    public static nint m_eRoundEndReason; // int32_t
    public static nint m_bRoundEndShowTimerDefend; // bool
    public static nint m_iRoundEndTimerTime; // int32_t
    public static nint m_sRoundEndFunFactToken; // CUtlString
    public static nint m_iRoundEndFunFactPlayerSlot; // CPlayerSlot
    public static nint m_iRoundEndFunFactData1; // int32_t
    public static nint m_iRoundEndFunFactData2; // int32_t
    public static nint m_iRoundEndFunFactData3; // int32_t
    public static nint m_sRoundEndMessage; // CUtlString
    public static nint m_iRoundEndPlayerCount; // int32_t
    public static nint m_bRoundEndNoMusic; // bool
    public static nint m_iRoundEndLegacy; // int32_t
    public static nint m_nRoundEndCount; // uint8_t
    public static nint m_iRoundStartRoundNumber; // int32_t
    public static nint m_nRoundStartCount; // uint8_t
    public static nint m_flLastPerfSampleTime; // double
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSGameRulesProxy { // C_GameRulesProxy
    public static nint m_pGameRules; // C_CSGameRules*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSMinimapBoundary { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSObserverPawn { // C_CSPlayerPawnBase
    public static nint m_hDetectParentChange; // CEntityHandle
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSObserverPawnAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSPlayerPawn { // C_CSPlayerPawnBase
    public static nint m_pBulletServices; // CCSPlayer_BulletServices*
    public static nint m_pHostageServices; // CCSPlayer_HostageServices*
    public static nint m_pBuyServices; // CCSPlayer_BuyServices*
    public static nint m_pGlowServices; // CCSPlayer_GlowServices*
    public static nint m_pActionTrackingServices; // CCSPlayer_ActionTrackingServices*
    public static nint m_flHealthShotBoostExpirationTime; // GameTime_t
    public static nint m_flLastFiredWeaponTime; // GameTime_t
    public static nint m_bHasFemaleVoice; // bool
    public static nint m_flLandseconds; // float
    public static nint m_flOldFallVelocity; // float
    public static nint m_szLastPlaceName; // char[18]
    public static nint m_bPrevDefuser; // bool
    public static nint m_bPrevHelmet; // bool
    public static nint m_nPrevArmorVal; // int32_t
    public static nint m_nPrevGrenadeAmmoCount; // int32_t
    public static nint m_unPreviousWeaponHash; // uint32_t
    public static nint m_unWeaponHash; // uint32_t
    public static nint m_bInBuyZone; // bool
    public static nint m_bPreviouslyInBuyZone; // bool
    public static nint m_aimPunchAngle; // QAngle
    public static nint m_aimPunchAngleVel; // QAngle
    public static nint m_aimPunchTickBase; // int32_t
    public static nint m_aimPunchTickFraction; // float
    public static nint m_aimPunchCache; // CUtlVector<QAngle>
    public static nint m_bInLanding; // bool
    public static nint m_flLandingTime; // float
    public static nint m_bInHostageRescueZone; // bool
    public static nint m_bInBombZone; // bool
    public static nint m_bIsBuyMenuOpen; // bool
    public static nint m_flTimeOfLastInjury; // GameTime_t
    public static nint m_flNextSprayDecalTime; // GameTime_t
    public static nint m_iRetakesOffering; // int32_t
    public static nint m_iRetakesOfferingCard; // int32_t
    public static nint m_bRetakesHasDefuseKit; // bool
    public static nint m_bRetakesMVPLastRound; // bool
    public static nint m_iRetakesMVPBoostItem; // int32_t
    public static nint m_RetakesMVPBoostExtraUtility; // loadout_slot_t
    public static nint m_bNeedToReApplyGloves; // bool
    public static nint m_EconGloves; // C_EconItemView
    public static nint m_nEconGlovesChanged; // uint8_t
    public static nint m_bMustSyncRagdollState; // bool
    public static nint m_nRagdollDamageBone; // int32_t
    public static nint m_vRagdollDamageForce; // Vector
    public static nint m_vRagdollDamagePosition; // Vector
    public static nint m_szRagdollDamageWeaponName; // char[64]
    public static nint m_bRagdollDamageHeadshot; // bool
    public static nint m_vRagdollServerOrigin; // Vector
    public static nint m_bLastHeadBoneTransformIsValid; // bool
    public static nint m_lastLandTime; // GameTime_t
    public static nint m_bOnGroundLastTick; // bool
    public static nint m_qDeathEyeAngles; // QAngle
    public static nint m_bSkipOneHeadConstraintUpdate; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSPlayerPawnAPI {
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSPlayerPawnBase { // C_BasePlayerPawn
    public static nint m_pPingServices; // CCSPlayer_PingServices*
    public static nint m_pViewModelServices; // CPlayer_ViewModelServices*
    public static nint m_fRenderingClipPlane; // float[4]
    public static nint m_nLastClipPlaneSetupFrame; // int32_t
    public static nint m_vecLastClipCameraPos; // Vector
    public static nint m_vecLastClipCameraForward; // Vector
    public static nint m_bClipHitStaticWorld; // bool
    public static nint m_bCachedPlaneIsValid; // bool
    public static nint m_pClippingWeapon; // C_CSWeaponBase*
    public static nint m_previousPlayerState; // CSPlayerState
    public static nint m_flLastCollisionCeiling; // float
    public static nint m_flLastCollisionCeilingChangeTime; // float
    public static nint m_grenadeParameterStashTime; // GameTime_t
    public static nint m_bGrenadeParametersStashed; // bool
    public static nint m_angStashedShootAngles; // QAngle
    public static nint m_vecStashedGrenadeThrowPosition; // Vector
    public static nint m_vecStashedVelocity; // Vector
    public static nint m_angShootAngleHistory; // QAngle[2]
    public static nint m_vecThrowPositionHistory; // Vector[2]
    public static nint m_vecVelocityHistory; // Vector[2]
    public static nint m_thirdPersonHeading; // QAngle
    public static nint m_flSlopeDropOffset; // float
    public static nint m_flSlopeDropHeight; // float
    public static nint m_vHeadConstraintOffset; // Vector
    public static nint m_bIsScoped; // bool
    public static nint m_bIsWalking; // bool
    public static nint m_bResumeZoom; // bool
    public static nint m_iPlayerState; // CSPlayerState
    public static nint m_bIsDefusing; // bool
    public static nint m_bIsGrabbingHostage; // bool
    public static nint m_iBlockingUseActionInProgress; // CSPlayerBlockingUseAction_t
    public static nint m_bIsRescuing; // bool
    public static nint m_fImmuneToGunGameDamageTime; // GameTime_t
    public static nint m_fImmuneToGunGameDamageTimeLast; // GameTime_t
    public static nint m_bGunGameImmunity; // bool
    public static nint m_GunGameImmunityColor; // Color
    public static nint m_bHasMovedSinceSpawn; // bool
    public static nint m_fMolotovUseTime; // float
    public static nint m_fMolotovDamageTime; // float
    public static nint m_nWhichBombZone; // int32_t
    public static nint m_bInNoDefuseArea; // bool
    public static nint m_iThrowGrenadeCounter; // int32_t
    public static nint m_bWaitForNoAttack; // bool
    public static nint m_flGuardianTooFarDistFrac; // float
    public static nint m_flDetectedByEnemySensorTime; // GameTime_t
    public static nint m_flNextGuardianTooFarWarning; // float
    public static nint m_bSuppressGuardianTooFarWarningAudio; // bool
    public static nint m_bKilledByTaser; // bool
    public static nint m_iMoveState; // int32_t
    public static nint m_bCanMoveDuringFreezePeriod; // bool
    public static nint m_flLowerBodyYawTarget; // float
    public static nint m_bStrafing; // bool
    public static nint m_flLastSpawnTimeIndex; // GameTime_t
    public static nint m_flEmitSoundTime; // GameTime_t
    public static nint m_iAddonBits; // int32_t
    public static nint m_iPrimaryAddon; // int32_t
    public static nint m_iSecondaryAddon; // int32_t
    public static nint m_iProgressBarDuration; // int32_t
    public static nint m_flProgressBarStartTime; // float
    public static nint m_iDirection; // int32_t
    public static nint m_iShotsFired; // int32_t
    public static nint m_bNightVisionOn; // bool
    public static nint m_bHasNightVision; // bool
    public static nint m_flVelocityModifier; // float
    public static nint m_flHitHeading; // float
    public static nint m_nHitBodyPart; // int32_t
    public static nint m_iStartAccount; // int32_t
    public static nint m_vecIntroStartEyePosition; // Vector
    public static nint m_vecIntroStartPlayerForward; // Vector
    public static nint m_flClientDeathTime; // GameTime_t
    public static nint m_flNightVisionAlpha; // float
    public static nint m_bScreenTearFrameCaptured; // bool
    public static nint m_flFlashBangTime; // float
    public static nint m_flFlashScreenshotAlpha; // float
    public static nint m_flFlashOverlayAlpha; // float
    public static nint m_bFlashBuildUp; // bool
    public static nint m_bFlashDspHasBeenCleared; // bool
    public static nint m_bFlashScreenshotHasBeenGrabbed; // bool
    public static nint m_flFlashMaxAlpha; // float
    public static nint m_flFlashDuration; // float
    public static nint m_lastStandingPos; // Vector
    public static nint m_vecLastMuzzleFlashPos; // Vector
    public static nint m_angLastMuzzleFlashAngle; // QAngle
    public static nint m_hMuzzleFlashShape; // CHandle<C_BaseEntity>
    public static nint m_iHealthBarRenderMaskIndex; // int32_t
    public static nint m_flHealthFadeValue; // float
    public static nint m_flHealthFadeAlpha; // float
    public static nint m_nMyCollisionGroup; // int32_t
    public static nint m_ignoreLadderJumpTime; // float
    public static nint m_ladderSurpressionTimer; // CountdownTimer
    public static nint m_lastLadderNormal; // Vector
    public static nint m_lastLadderPos; // Vector
    public static nint m_flDeathCCWeight; // float
    public static nint m_bOldIsScoped; // bool
    public static nint m_flPrevRoundEndTime; // float
    public static nint m_flPrevMatchEndTime; // float
    public static nint m_unCurrentEquipmentValue; // uint16_t
    public static nint m_unRoundStartEquipmentValue; // uint16_t
    public static nint m_unFreezetimeEndEquipmentValue; // uint16_t
    public static nint m_vecThirdPersonViewPositionOverride; // Vector
    public static nint m_nHeavyAssaultSuitCooldownRemaining; // int32_t
    public static nint m_ArmorValue; // int32_t
    public static nint m_angEyeAngles; // QAngle
    public static nint m_fNextThinkPushAway; // float
    public static nint m_bShouldAutobuyDMWeapons; // bool
    public static nint m_bShouldAutobuyNow; // bool
    public static nint m_bHud_MiniScoreHidden; // bool
    public static nint m_bHud_RadarHidden; // bool
    public static nint m_nLastKillerIndex; // CEntityIndex
    public static nint m_nLastConcurrentKilled; // int32_t
    public static nint m_nDeathCamMusic; // int32_t
    public static nint m_iIDEntIndex; // CEntityIndex
    public static nint m_delayTargetIDTimer; // CountdownTimer
    public static nint m_iTargetedWeaponEntIndex; // CEntityIndex
    public static nint m_iOldIDEntIndex; // CEntityIndex
    public static nint m_holdTargetIDTimer; // CountdownTimer
    public static nint m_flCurrentMusicStartTime; // float
    public static nint m_flMusicRoundStartTime; // float
    public static nint m_bDeferStartMusicOnWarmup; // bool
    public static nint m_cycleLatch; // int32_t
    public static nint m_serverIntendedCycle; // float
    public static nint m_vecPlayerPatchEconIndices; // uint32_t[5]
    public static nint m_bHideTargetID; // bool
    public static nint m_flLastSmokeOverlayAlpha; // float
    public static nint m_vLastSmokeOverlayColor; // Vector
    public static nint m_nPlayerSmokedFx; // ParticleIndex_t
    public static nint m_nPlayerInfernoBodyFx; // ParticleIndex_t
    public static nint m_nPlayerInfernoFootFx; // ParticleIndex_t
    public static nint m_flNextMagDropTime; // float
    public static nint m_nLastMagDropAttachmentIndex; // int32_t
    public static nint m_vecBulletHitModels; // CUtlVector<C_BulletHitModel*>
    public static nint m_vecPickupModelSlerpers; // CUtlVector<C_PickUpModelSlerper*>
    public static nint m_vecLastAliveLocalVelocity; // Vector
    public static nint m_entitySpottedState; // EntitySpottedState_t
    public static nint m_nSurvivalTeamNumber; // int32_t
    public static nint m_bGuardianShouldSprayCustomXMark; // bool
    public static nint m_bHasDeathInfo; // bool
    public static nint m_flDeathInfoTime; // float
    public static nint m_vecDeathInfoOrigin; // Vector
    public static nint m_bKilledByHeadshot; // bool
    public static nint m_hOriginalController; // CHandle<CCSPlayerController>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSPlayerResource { // C_BaseEntity
    public static nint m_bHostageAlive; // bool[12]
    public static nint m_isHostageFollowingSomeone; // bool[12]
    public static nint m_iHostageEntityIDs; // CEntityIndex[12]
    public static nint m_bombsiteCenterA; // Vector
    public static nint m_bombsiteCenterB; // Vector
    public static nint m_hostageRescueX; // int32_t[4]
    public static nint m_hostageRescueY; // int32_t[4]
    public static nint m_hostageRescueZ; // int32_t[4]
    public static nint m_bEndMatchNextMapAllVoted; // bool
    public static nint m_foundGoalPositions; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSTeam { // C_Team
    public static nint m_szTeamMatchStat; // char[512]
    public static nint m_numMapVictories; // int32_t
    public static nint m_bSurrendered; // bool
    public static nint m_scoreFirstHalf; // int32_t
    public static nint m_scoreSecondHalf; // int32_t
    public static nint m_scoreOvertime; // int32_t
    public static nint m_szClanTeamname; // char[129]
    public static nint m_iClanID; // uint32_t
    public static nint m_szTeamFlagImage; // char[8]
    public static nint m_szTeamLogoImage; // char[8]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSWeaponBase { // C_BasePlayerWeapon
    public static nint m_flFireSequenceStartTime; // float
    public static nint m_nFireSequenceStartTimeChange; // int32_t
    public static nint m_nFireSequenceStartTimeAck; // int32_t
    public static nint m_ePlayerFireEvent; // PlayerAnimEvent_t
    public static nint m_ePlayerFireEventAttackType; // WeaponAttackType_t
    public static nint m_seqIdle; // HSequence
    public static nint m_seqFirePrimary; // HSequence
    public static nint m_seqFireSecondary; // HSequence
    public static nint m_thirdPersonFireSequences; // CUtlVector<HSequence>
    public static nint m_hCurrentThirdPersonSequence; // HSequence
    public static nint m_nSilencerBoneIndex; // int32_t
    public static nint m_thirdPersonSequences; // HSequence[7]
    public static nint m_ClientPreviousWeaponState; // CSWeaponState_t
    public static nint m_iState; // CSWeaponState_t
    public static nint m_flCrosshairDistance; // float
    public static nint m_iAmmoLastCheck; // int32_t
    public static nint m_iAlpha; // int32_t
    public static nint m_iScopeTextureID; // int32_t
    public static nint m_iCrosshairTextureID; // int32_t
    public static nint m_flGunAccuracyPositionDeprecated; // float
    public static nint m_nLastEmptySoundCmdNum; // int32_t
    public static nint m_nViewModelIndex; // uint32_t
    public static nint m_bReloadsWithClips; // bool
    public static nint m_flTimeWeaponIdle; // GameTime_t
    public static nint m_bFireOnEmpty; // bool
    public static nint m_OnPlayerPickup; // CEntityIOOutput
    public static nint m_weaponMode; // CSWeaponMode
    public static nint m_flTurningInaccuracyDelta; // float
    public static nint m_vecTurningInaccuracyEyeDirLast; // Vector
    public static nint m_flTurningInaccuracy; // float
    public static nint m_fAccuracyPenalty; // float
    public static nint m_flLastAccuracyUpdateTime; // GameTime_t
    public static nint m_fAccuracySmoothedForZoom; // float
    public static nint m_fScopeZoomEndTime; // GameTime_t
    public static nint m_iRecoilIndex; // int32_t
    public static nint m_flRecoilIndex; // float
    public static nint m_bBurstMode; // bool
    public static nint m_nPostponeFireReadyTicks; // GameTick_t
    public static nint m_flPostponeFireReadyFrac; // float
    public static nint m_bInReload; // bool
    public static nint m_bReloadVisuallyComplete; // bool
    public static nint m_flDroppedAtTime; // GameTime_t
    public static nint m_bIsHauledBack; // bool
    public static nint m_bSilencerOn; // bool
    public static nint m_flTimeSilencerSwitchComplete; // GameTime_t
    public static nint m_iOriginalTeamNumber; // int32_t
    public static nint m_flNextAttackRenderTimeOffset; // float
    public static nint m_bVisualsDataSet; // bool
    public static nint m_bOldFirstPersonSpectatedState; // bool
    public static nint m_hOurPing; // CHandle<C_BaseEntity>
    public static nint m_nOurPingIndex; // CEntityIndex
    public static nint m_vecOurPingPos; // Vector
    public static nint m_bGlowForPing; // bool
    public static nint m_bUIWeapon; // bool
    public static nint m_hPrevOwner; // CHandle<C_CSPlayerPawn>
    public static nint m_nDropTick; // GameTick_t
    public static nint m_donated; // bool
    public static nint m_fLastShotTime; // GameTime_t
    public static nint m_bWasOwnedByCT; // bool
    public static nint m_bWasOwnedByTerrorist; // bool
    public static nint m_gunHeat; // float
    public static nint m_smokeAttachments; // uint32_t
    public static nint m_lastSmokeTime; // GameTime_t
    public static nint m_flNextClientFireBulletTime; // float
    public static nint m_flNextClientFireBulletTime_Repredict; // float
    public static nint m_IronSightController; // C_IronSightController
    public static nint m_iIronSightMode; // int32_t
    public static nint m_flLastLOSTraceFailureTime; // GameTime_t
    public static nint m_iNumEmptyAttacks; // int32_t
    public static nint m_flLastMagDropRequestTime; // GameTime_t
    public static nint m_flWatTickOffset; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CSWeaponBaseGun { // C_CSWeaponBase
    public static nint m_zoomLevel; // int32_t
    public static nint m_iBurstShotsRemaining; // int32_t
    public static nint m_iSilencerBodygroup; // int32_t
    public static nint m_silencedModelIndex; // int32_t
    public static nint m_inPrecache; // bool
    public static nint m_bNeedsBoltAction; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Chicken { // C_DynamicProp
    public static nint m_hHolidayHatAddon; // CHandle<CBaseAnimGraph>
    public static nint m_jumpedThisFrame; // bool
    public static nint m_leader; // CHandle<C_CSPlayerPawn>
    public static nint m_AttributeManager; // C_AttributeContainer
    public static nint m_OriginalOwnerXuidLow; // uint32_t
    public static nint m_OriginalOwnerXuidHigh; // uint32_t
    public static nint m_bAttributesInitialized; // bool
    public static nint m_hWaterWakeParticles; // ParticleIndex_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ClientRagdoll { // CBaseAnimGraph
    public static nint m_bFadeOut; // bool
    public static nint m_bImportant; // bool
    public static nint m_flEffectTime; // GameTime_t
    public static nint m_gibDespawnTime; // GameTime_t
    public static nint m_iCurrentFriction; // int32_t
    public static nint m_iMinFriction; // int32_t
    public static nint m_iMaxFriction; // int32_t
    public static nint m_iFrictionAnimState; // int32_t
    public static nint m_bReleaseRagdoll; // bool
    public static nint m_iEyeAttachment; // AttachmentHandle_t
    public static nint m_bFadingOut; // bool
    public static nint m_flScaleEnd; // float[10]
    public static nint m_flScaleTimeStart; // GameTime_t[10]
    public static nint m_flScaleTimeEnd; // GameTime_t[10]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ColorCorrection { // C_BaseEntity
    public static nint m_vecOrigin; // Vector
    public static nint m_MinFalloff; // float
    public static nint m_MaxFalloff; // float
    public static nint m_flFadeInDuration; // float
    public static nint m_flFadeOutDuration; // float
    public static nint m_flMaxWeight; // float
    public static nint m_flCurWeight; // float
    public static nint m_netlookupFilename; // char[512]
    public static nint m_bEnabled; // bool
    public static nint m_bMaster; // bool
    public static nint m_bClientSide; // bool
    public static nint m_bExclusive; // bool
    public static nint m_bEnabledOnClient; // bool[1]
    public static nint m_flCurWeightOnClient; // float[1]
    public static nint m_bFadingIn; // bool[1]
    public static nint m_flFadeStartWeight; // float[1]
    public static nint m_flFadeStartTime; // float[1]
    public static nint m_flFadeDuration; // float[1]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ColorCorrectionVolume { // C_BaseTrigger
    public static nint m_LastEnterWeight; // float
    public static nint m_LastEnterTime; // float
    public static nint m_LastExitWeight; // float
    public static nint m_LastExitTime; // float
    public static nint m_bEnabled; // bool
    public static nint m_MaxWeight; // float
    public static nint m_FadeDuration; // float
    public static nint m_Weight; // float
    public static nint m_lookupFilename; // char[512]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CommandContext {
    public static nint needsprocessing; // bool
    public static nint command_number; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_CsmFovOverride { // C_BaseEntity
    public static nint m_cameraName; // CUtlString
    public static nint m_flCsmFovOverrideValue; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DEagle { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DecoyGrenade { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DecoyProjectile { // C_BaseCSGrenadeProjectile
    public static nint m_nDecoyShotTick; // int32_t
    public static nint m_nClientLastKnownDecoyShotTick; // int32_t
    public static nint m_flTimeParticleEffectSpawn; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DynamicLight { // C_BaseModelEntity
    public static nint m_Flags; // uint8_t
    public static nint m_LightStyle; // uint8_t
    public static nint m_Radius; // float
    public static nint m_Exponent; // int32_t
    public static nint m_InnerAngle; // float
    public static nint m_OuterAngle; // float
    public static nint m_SpotRadius; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DynamicProp { // C_BreakableProp
    public static nint m_bUseHitboxesForRenderBox; // bool
    public static nint m_bUseAnimGraph; // bool
    public static nint m_pOutputAnimBegun; // CEntityIOOutput
    public static nint m_pOutputAnimOver; // CEntityIOOutput
    public static nint m_pOutputAnimLoopCycleOver; // CEntityIOOutput
    public static nint m_OnAnimReachedStart; // CEntityIOOutput
    public static nint m_OnAnimReachedEnd; // CEntityIOOutput
    public static nint m_iszIdleAnim; // CUtlSymbolLarge
    public static nint m_nIdleAnimLoopMode; // AnimLoopMode_t
    public static nint m_bRandomizeCycle; // bool
    public static nint m_bStartDisabled; // bool
    public static nint m_bFiredStartEndOutput; // bool
    public static nint m_bForceNpcExclude; // bool
    public static nint m_bCreateNonSolid; // bool
    public static nint m_bIsOverrideProp; // bool
    public static nint m_iInitialGlowState; // int32_t
    public static nint m_nGlowRange; // int32_t
    public static nint m_nGlowRangeMin; // int32_t
    public static nint m_glowColor; // Color
    public static nint m_nGlowTeam; // int32_t
    public static nint m_iCachedFrameCount; // int32_t
    public static nint m_vecCachedRenderMins; // Vector
    public static nint m_vecCachedRenderMaxs; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DynamicPropAlias_cable_dynamic { // C_DynamicProp
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DynamicPropAlias_dynamic_prop { // C_DynamicProp
}

[OffsetsWithFilePath("client.dll.json")] public static class C_DynamicPropAlias_prop_dynamic_override { // C_DynamicProp
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EconEntity { // C_BaseFlex
    public static nint m_flFlexDelayTime; // float
    public static nint m_flFlexDelayedWeight; // float*
    public static nint m_bAttributesInitialized; // bool
    public static nint m_AttributeManager; // C_AttributeContainer
    public static nint m_OriginalOwnerXuidLow; // uint32_t
    public static nint m_OriginalOwnerXuidHigh; // uint32_t
    public static nint m_nFallbackPaintKit; // int32_t
    public static nint m_nFallbackSeed; // int32_t
    public static nint m_flFallbackWear; // float
    public static nint m_nFallbackStatTrak; // int32_t
    public static nint m_bClientside; // bool
    public static nint m_bParticleSystemsCreated; // bool
    public static nint m_vecAttachedParticles; // CUtlVector<int32_t>
    public static nint m_hViewmodelAttachment; // CHandle<CBaseAnimGraph>
    public static nint m_iOldTeam; // int32_t
    public static nint m_bAttachmentDirty; // bool
    public static nint m_nUnloadedModelIndex; // int32_t
    public static nint m_iNumOwnerValidationRetries; // int32_t
    public static nint m_hOldProvidee; // CHandle<C_BaseEntity>
    public static nint m_vecAttachedModels; // CUtlVector<C_EconEntity::AttachedModelData_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EconEntity_AttachedModelData_t {
    public static nint m_iModelDisplayFlags; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EconItemView { // IEconItemInterface
    public static nint m_bInventoryImageRgbaRequested; // bool
    public static nint m_bInventoryImageTriedCache; // bool
    public static nint m_nInventoryImageRgbaWidth; // int32_t
    public static nint m_nInventoryImageRgbaHeight; // int32_t
    public static nint m_szCurrentLoadCachedFileName; // char[260]
    public static nint m_bRestoreCustomMaterialAfterPrecache; // bool
    public static nint m_iItemDefinitionIndex; // uint16_t
    public static nint m_iEntityQuality; // int32_t
    public static nint m_iEntityLevel; // uint32_t
    public static nint m_iItemID; // uint64_t
    public static nint m_iItemIDHigh; // uint32_t
    public static nint m_iItemIDLow; // uint32_t
    public static nint m_iAccountID; // uint32_t
    public static nint m_iInventoryPosition; // uint32_t
    public static nint m_bInitialized; // bool
    public static nint m_bDisallowSOC; // bool
    public static nint m_bIsStoreItem; // bool
    public static nint m_bIsTradeItem; // bool
    public static nint m_iEntityQuantity; // int32_t
    public static nint m_iRarityOverride; // int32_t
    public static nint m_iQualityOverride; // int32_t
    public static nint m_unClientFlags; // uint8_t
    public static nint m_unOverrideStyle; // uint8_t
    public static nint m_AttributeList; // CAttributeList
    public static nint m_NetworkedDynamicAttributes; // CAttributeList
    public static nint m_szCustomName; // char[161]
    public static nint m_szCustomNameOverride; // char[161]
    public static nint m_bInitializedTags; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EconWearable { // C_EconEntity
    public static nint m_nForceSkin; // int32_t
    public static nint m_bAlwaysAllow; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EntityDissolve { // C_BaseModelEntity
    public static nint m_flStartTime; // GameTime_t
    public static nint m_flFadeInStart; // float
    public static nint m_flFadeInLength; // float
    public static nint m_flFadeOutModelStart; // float
    public static nint m_flFadeOutModelLength; // float
    public static nint m_flFadeOutStart; // float
    public static nint m_flFadeOutLength; // float
    public static nint m_flNextSparkTime; // GameTime_t
    public static nint m_nDissolveType; // EntityDisolveType_t
    public static nint m_vDissolverOrigin; // Vector
    public static nint m_nMagnitude; // uint32_t
    public static nint m_bCoreExplode; // bool
    public static nint m_bLinkedToServerEnt; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EntityFlame { // C_BaseEntity
    public static nint m_hEntAttached; // CHandle<C_BaseEntity>
    public static nint m_hOldAttached; // CHandle<C_BaseEntity>
    public static nint m_bCheapEffect; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvCombinedLightProbeVolume { // C_BaseEntity
    public static nint m_Color; // Color
    public static nint m_flBrightness; // float
    public static nint m_hCubemapTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_bCustomCubemapTexture; // bool
    public static nint m_hLightProbeTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightIndicesTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightScalarsTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightShadowsTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_vBoxMins; // Vector
    public static nint m_vBoxMaxs; // Vector
    public static nint m_bMoveable; // bool
    public static nint m_nHandshake; // int32_t
    public static nint m_nEnvCubeMapArrayIndex; // int32_t
    public static nint m_nPriority; // int32_t
    public static nint m_bStartDisabled; // bool
    public static nint m_flEdgeFadeDist; // float
    public static nint m_vEdgeFadeDists; // Vector
    public static nint m_nLightProbeSizeX; // int32_t
    public static nint m_nLightProbeSizeY; // int32_t
    public static nint m_nLightProbeSizeZ; // int32_t
    public static nint m_nLightProbeAtlasX; // int32_t
    public static nint m_nLightProbeAtlasY; // int32_t
    public static nint m_nLightProbeAtlasZ; // int32_t
    public static nint m_bEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvCubemap { // C_BaseEntity
    public static nint m_hCubemapTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_bCustomCubemapTexture; // bool
    public static nint m_flInfluenceRadius; // float
    public static nint m_vBoxProjectMins; // Vector
    public static nint m_vBoxProjectMaxs; // Vector
    public static nint m_bMoveable; // bool
    public static nint m_nHandshake; // int32_t
    public static nint m_nEnvCubeMapArrayIndex; // int32_t
    public static nint m_nPriority; // int32_t
    public static nint m_flEdgeFadeDist; // float
    public static nint m_vEdgeFadeDists; // Vector
    public static nint m_flDiffuseScale; // float
    public static nint m_bStartDisabled; // bool
    public static nint m_bDefaultEnvMap; // bool
    public static nint m_bDefaultSpecEnvMap; // bool
    public static nint m_bIndoorCubeMap; // bool
    public static nint m_bCopyDiffuseFromDefaultCubemap; // bool
    public static nint m_bEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvCubemapBox { // C_EnvCubemap
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvCubemapFog { // C_BaseEntity
    public static nint m_flEndDistance; // float
    public static nint m_flStartDistance; // float
    public static nint m_flFogFalloffExponent; // float
    public static nint m_bHeightFogEnabled; // bool
    public static nint m_flFogHeightWidth; // float
    public static nint m_flFogHeightEnd; // float
    public static nint m_flFogHeightStart; // float
    public static nint m_flFogHeightExponent; // float
    public static nint m_flLODBias; // float
    public static nint m_bActive; // bool
    public static nint m_bStartDisabled; // bool
    public static nint m_flFogMaxOpacity; // float
    public static nint m_nCubemapSourceType; // int32_t
    public static nint m_hSkyMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_iszSkyEntity; // CUtlSymbolLarge
    public static nint m_hFogCubemapTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_bHasHeightFogEnd; // bool
    public static nint m_bFirstTime; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvDecal { // C_BaseModelEntity
    public static nint m_hDecalMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_flWidth; // float
    public static nint m_flHeight; // float
    public static nint m_flDepth; // float
    public static nint m_nRenderOrder; // uint32_t
    public static nint m_bProjectOnWorld; // bool
    public static nint m_bProjectOnCharacters; // bool
    public static nint m_bProjectOnWater; // bool
    public static nint m_flDepthSortBias; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvDetailController { // C_BaseEntity
    public static nint m_flFadeStartDist; // float
    public static nint m_flFadeEndDist; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvLightProbeVolume { // C_BaseEntity
    public static nint m_hLightProbeTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightIndicesTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightScalarsTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hLightProbeDirectLightShadowsTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_vBoxMins; // Vector
    public static nint m_vBoxMaxs; // Vector
    public static nint m_bMoveable; // bool
    public static nint m_nHandshake; // int32_t
    public static nint m_nPriority; // int32_t
    public static nint m_bStartDisabled; // bool
    public static nint m_nLightProbeSizeX; // int32_t
    public static nint m_nLightProbeSizeY; // int32_t
    public static nint m_nLightProbeSizeZ; // int32_t
    public static nint m_nLightProbeAtlasX; // int32_t
    public static nint m_nLightProbeAtlasY; // int32_t
    public static nint m_nLightProbeAtlasZ; // int32_t
    public static nint m_bEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvParticleGlow { // C_ParticleSystem
    public static nint m_flAlphaScale; // float
    public static nint m_flRadiusScale; // float
    public static nint m_flSelfIllumScale; // float
    public static nint m_ColorTint; // Color
    public static nint m_hTextureOverride; // CStrongHandle<InfoForResourceTypeCTextureBase>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvProjectedTexture { // C_ModelPointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvScreenOverlay { // C_PointEntity
    public static nint m_iszOverlayNames; // CUtlSymbolLarge[10]
    public static nint m_flOverlayTimes; // float[10]
    public static nint m_flStartTime; // GameTime_t
    public static nint m_iDesiredOverlay; // int32_t
    public static nint m_bIsActive; // bool
    public static nint m_bWasActive; // bool
    public static nint m_iCachedDesiredOverlay; // int32_t
    public static nint m_iCurrentOverlay; // int32_t
    public static nint m_flCurrentOverlayTime; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvSky { // C_BaseModelEntity
    public static nint m_hSkyMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_hSkyMaterialLightingOnly; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_bStartDisabled; // bool
    public static nint m_vTintColor; // Color
    public static nint m_vTintColorLightingOnly; // Color
    public static nint m_flBrightnessScale; // float
    public static nint m_nFogType; // int32_t
    public static nint m_flFogMinStart; // float
    public static nint m_flFogMinEnd; // float
    public static nint m_flFogMaxStart; // float
    public static nint m_flFogMaxEnd; // float
    public static nint m_bEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvVolumetricFogController { // C_BaseEntity
    public static nint m_flScattering; // float
    public static nint m_flAnisotropy; // float
    public static nint m_flFadeSpeed; // float
    public static nint m_flDrawDistance; // float
    public static nint m_flFadeInStart; // float
    public static nint m_flFadeInEnd; // float
    public static nint m_flIndirectStrength; // float
    public static nint m_nIndirectTextureDimX; // int32_t
    public static nint m_nIndirectTextureDimY; // int32_t
    public static nint m_nIndirectTextureDimZ; // int32_t
    public static nint m_vBoxMins; // Vector
    public static nint m_vBoxMaxs; // Vector
    public static nint m_bActive; // bool
    public static nint m_flStartAnisoTime; // GameTime_t
    public static nint m_flStartScatterTime; // GameTime_t
    public static nint m_flStartDrawDistanceTime; // GameTime_t
    public static nint m_flStartAnisotropy; // float
    public static nint m_flStartScattering; // float
    public static nint m_flStartDrawDistance; // float
    public static nint m_flDefaultAnisotropy; // float
    public static nint m_flDefaultScattering; // float
    public static nint m_flDefaultDrawDistance; // float
    public static nint m_bStartDisabled; // bool
    public static nint m_bEnableIndirect; // bool
    public static nint m_bIsMaster; // bool
    public static nint m_hFogIndirectTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_nForceRefreshCount; // int32_t
    public static nint m_bFirstTime; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvVolumetricFogVolume { // C_BaseEntity
    public static nint m_bActive; // bool
    public static nint m_vBoxMins; // Vector
    public static nint m_vBoxMaxs; // Vector
    public static nint m_bStartDisabled; // bool
    public static nint m_flStrength; // float
    public static nint m_nFalloffShape; // int32_t
    public static nint m_flFalloffExponent; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvWind { // C_BaseEntity
    public static nint m_EnvWindShared; // C_EnvWindShared
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvWindClientside { // C_BaseEntity
    public static nint m_EnvWindShared; // C_EnvWindShared
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvWindShared {
    public static nint m_flStartTime; // GameTime_t
    public static nint m_iWindSeed; // uint32_t
    public static nint m_iMinWind; // uint16_t
    public static nint m_iMaxWind; // uint16_t
    public static nint m_windRadius; // int32_t
    public static nint m_iMinGust; // uint16_t
    public static nint m_iMaxGust; // uint16_t
    public static nint m_flMinGustDelay; // float
    public static nint m_flMaxGustDelay; // float
    public static nint m_flGustDuration; // float
    public static nint m_iGustDirChange; // uint16_t
    public static nint m_location; // Vector
    public static nint m_iszGustSound; // int32_t
    public static nint m_iWindDir; // int32_t
    public static nint m_flWindSpeed; // float
    public static nint m_currentWindVector; // Vector
    public static nint m_CurrentSwayVector; // Vector
    public static nint m_PrevSwayVector; // Vector
    public static nint m_iInitialWindDir; // uint16_t
    public static nint m_flInitialWindSpeed; // float
    public static nint m_flVariationTime; // GameTime_t
    public static nint m_flSwayTime; // GameTime_t
    public static nint m_flSimTime; // GameTime_t
    public static nint m_flSwitchTime; // GameTime_t
    public static nint m_flAveWindSpeed; // float
    public static nint m_bGusting; // bool
    public static nint m_flWindAngleVariation; // float
    public static nint m_flWindSpeedVariation; // float
    public static nint m_iEntIndex; // CEntityIndex
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvWindShared_WindAveEvent_t {
    public static nint m_flStartWindSpeed; // float
    public static nint m_flAveWindSpeed; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_EnvWindShared_WindVariationEvent_t {
    public static nint m_flWindAngleVariation; // float
    public static nint m_flWindSpeedVariation; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FireCrackerBlast { // C_Inferno
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FireFromAboveSprite { // C_Sprite
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FireSmoke { // C_BaseFire
    public static nint m_nFlameModelIndex; // int32_t
    public static nint m_nFlameFromAboveModelIndex; // int32_t
    public static nint m_flScaleRegister; // float
    public static nint m_flScaleStart; // float
    public static nint m_flScaleEnd; // float
    public static nint m_flScaleTimeStart; // GameTime_t
    public static nint m_flScaleTimeEnd; // GameTime_t
    public static nint m_flChildFlameSpread; // float
    public static nint m_flClipPerc; // float
    public static nint m_bClipTested; // bool
    public static nint m_bFadingOut; // bool
    public static nint m_tParticleSpawn; // TimedEvent
    public static nint m_pFireOverlay; // CFireOverlay*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FireSprite { // C_Sprite
    public static nint m_vecMoveDir; // Vector
    public static nint m_bFadeFromAbove; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Fish { // CBaseAnimGraph
    public static nint m_pos; // Vector
    public static nint m_vel; // Vector
    public static nint m_angles; // QAngle
    public static nint m_localLifeState; // int32_t
    public static nint m_deathDepth; // float
    public static nint m_deathAngle; // float
    public static nint m_buoyancy; // float
    public static nint m_wiggleTimer; // CountdownTimer
    public static nint m_wigglePhase; // float
    public static nint m_wiggleRate; // float
    public static nint m_actualPos; // Vector
    public static nint m_actualAngles; // QAngle
    public static nint m_poolOrigin; // Vector
    public static nint m_waterLevel; // float
    public static nint m_gotUpdate; // bool
    public static nint m_x; // float
    public static nint m_y; // float
    public static nint m_z; // float
    public static nint m_angle; // float
    public static nint m_errorHistory; // float[20]
    public static nint m_errorHistoryIndex; // int32_t
    public static nint m_errorHistoryCount; // int32_t
    public static nint m_averageError; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Fists { // C_CSWeaponBase
    public static nint m_bPlayingUninterruptableAct; // bool
    public static nint m_nUninterruptableActivity; // PlayerAnimEvent_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Flashbang { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FlashbangProjectile { // C_BaseCSGrenadeProjectile
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FogController { // C_BaseEntity
    public static nint m_fog; // fogparams_t
    public static nint m_bUseAngles; // bool
    public static nint m_iChangedVariables; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FootstepControl { // C_BaseTrigger
    public static nint m_source; // CUtlSymbolLarge
    public static nint m_destination; // CUtlSymbolLarge
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncBrush { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncConveyor { // C_BaseModelEntity
    public static nint m_vecMoveDirEntitySpace; // Vector
    public static nint m_flTargetSpeed; // float
    public static nint m_nTransitionStartTick; // GameTick_t
    public static nint m_nTransitionDurationTicks; // int32_t
    public static nint m_flTransitionStartSpeed; // float
    public static nint m_hConveyorModels; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
    public static nint m_flCurrentConveyorOffset; // float
    public static nint m_flCurrentConveyorSpeed; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncElectrifiedVolume { // C_FuncBrush
    public static nint m_nAmbientEffect; // ParticleIndex_t
    public static nint m_EffectName; // CUtlSymbolLarge
    public static nint m_bState; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncLadder { // C_BaseModelEntity
    public static nint m_vecLadderDir; // Vector
    public static nint m_Dismounts; // CUtlVector<CHandle<C_InfoLadderDismount>>
    public static nint m_vecLocalTop; // Vector
    public static nint m_vecPlayerMountPositionTop; // Vector
    public static nint m_vecPlayerMountPositionBottom; // Vector
    public static nint m_flAutoRideSpeed; // float
    public static nint m_bDisabled; // bool
    public static nint m_bFakeLadder; // bool
    public static nint m_bHasSlack; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncMonitor { // C_FuncBrush
    public static nint m_targetCamera; // CUtlString
    public static nint m_nResolutionEnum; // int32_t
    public static nint m_bRenderShadows; // bool
    public static nint m_bUseUniqueColorTarget; // bool
    public static nint m_brushModelName; // CUtlString
    public static nint m_hTargetCamera; // CHandle<C_BaseEntity>
    public static nint m_bEnabled; // bool
    public static nint m_bDraw3DSkybox; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncMoveLinear { // C_BaseToggle
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncRotating { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_FuncTrackTrain { // C_BaseModelEntity
    public static nint m_nLongAxis; // int32_t
    public static nint m_flRadius; // float
    public static nint m_flLineLength; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_GameRules {
}

[OffsetsWithFilePath("client.dll.json")] public static class C_GameRulesProxy { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_GlobalLight { // C_BaseEntity
    public static nint m_WindClothForceHandle; // uint16_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_GradientFog { // C_BaseEntity
    public static nint m_hGradientFogTexture; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_flFogStartDistance; // float
    public static nint m_flFogEndDistance; // float
    public static nint m_bHeightFogEnabled; // bool
    public static nint m_flFogStartHeight; // float
    public static nint m_flFogEndHeight; // float
    public static nint m_flFarZ; // float
    public static nint m_flFogMaxOpacity; // float
    public static nint m_flFogFalloffExponent; // float
    public static nint m_flFogVerticalExponent; // float
    public static nint m_fogColor; // Color
    public static nint m_flFogStrength; // float
    public static nint m_flFadeTime; // float
    public static nint m_bStartDisabled; // bool
    public static nint m_bIsEnabled; // bool
    public static nint m_bGradientFogNeedsTextures; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_HEGrenade { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_HEGrenadeProjectile { // C_BaseCSGrenadeProjectile
}

[OffsetsWithFilePath("client.dll.json")] public static class C_HandleTest { // C_BaseEntity
    public static nint m_Handle; // CHandle<C_BaseEntity>
    public static nint m_bSendHandle; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Hostage { // C_BaseCombatCharacter
    public static nint m_entitySpottedState; // EntitySpottedState_t
    public static nint m_leader; // CHandle<C_BaseEntity>
    public static nint m_reuseTimer; // CountdownTimer
    public static nint m_vel; // Vector
    public static nint m_isRescued; // bool
    public static nint m_jumpedThisFrame; // bool
    public static nint m_nHostageState; // int32_t
    public static nint m_bHandsHaveBeenCut; // bool
    public static nint m_hHostageGrabber; // CHandle<C_CSPlayerPawn>
    public static nint m_fLastGrabTime; // GameTime_t
    public static nint m_vecGrabbedPos; // Vector
    public static nint m_flRescueStartTime; // GameTime_t
    public static nint m_flGrabSuccessTime; // GameTime_t
    public static nint m_flDropStartTime; // GameTime_t
    public static nint m_flDeadOrRescuedTime; // GameTime_t
    public static nint m_blinkTimer; // CountdownTimer
    public static nint m_lookAt; // Vector
    public static nint m_lookAroundTimer; // CountdownTimer
    public static nint m_isInit; // bool
    public static nint m_eyeAttachment; // AttachmentHandle_t
    public static nint m_chestAttachment; // AttachmentHandle_t
    public static nint m_pPredictionOwner; // CBasePlayerController*
    public static nint m_fNewestAlphaThinkTime; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_HostageCarriableProp { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_IncendiaryGrenade { // C_MolotovGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Inferno { // C_BaseModelEntity
    public static nint m_nfxFireDamageEffect; // ParticleIndex_t
    public static nint m_firePositions; // Vector[64]
    public static nint m_fireParentPositions; // Vector[64]
    public static nint m_bFireIsBurning; // bool[64]
    public static nint m_BurnNormal; // Vector[64]
    public static nint m_fireCount; // int32_t
    public static nint m_nInfernoType; // int32_t
    public static nint m_nFireLifetime; // float
    public static nint m_bInPostEffectTime; // bool
    public static nint m_lastFireCount; // int32_t
    public static nint m_nFireEffectTickBegin; // int32_t
    public static nint m_drawableCount; // int32_t
    public static nint m_blosCheck; // bool
    public static nint m_nlosperiod; // int32_t
    public static nint m_maxFireHalfWidth; // float
    public static nint m_maxFireHeight; // float
    public static nint m_minBounds; // Vector
    public static nint m_maxBounds; // Vector
    public static nint m_flLastGrassBurnThink; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_InfoInstructorHintHostageRescueZone { // C_PointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_InfoLadderDismount { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_InfoVisibilityBox { // C_BaseEntity
    public static nint m_nMode; // int32_t
    public static nint m_vBoxSize; // Vector
    public static nint m_bEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_IronSightController {
    public static nint m_bIronSightAvailable; // bool
    public static nint m_flIronSightAmount; // float
    public static nint m_flIronSightAmountGained; // float
    public static nint m_flIronSightAmountBiased; // float
    public static nint m_flIronSightAmount_Interpolated; // float
    public static nint m_flIronSightAmountGained_Interpolated; // float
    public static nint m_flIronSightAmountBiased_Interpolated; // float
    public static nint m_flInterpolationLastUpdated; // float
    public static nint m_angDeltaAverage; // QAngle[8]
    public static nint m_angViewLast; // QAngle
    public static nint m_vecDotCoords; // Vector2D
    public static nint m_flDotBlur; // float
    public static nint m_flSpeedRatio; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Item { // C_EconEntity
    public static nint m_bShouldGlow; // bool
    public static nint m_pReticleHintTextName; // char[256]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ItemDogtags { // C_Item
    public static nint m_OwningPlayer; // CHandle<C_CSPlayerPawn>
    public static nint m_KillingPlayer; // CHandle<C_CSPlayerPawn>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Item_Healthshot { // C_WeaponBaseItem
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Knife { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightDirectionalEntity { // C_LightEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightEntity { // C_BaseModelEntity
    public static nint m_CLightComponent; // CLightComponent*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightEnvironmentEntity { // C_LightDirectionalEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightGlow { // C_BaseModelEntity
    public static nint m_nHorizontalSize; // uint32_t
    public static nint m_nVerticalSize; // uint32_t
    public static nint m_nMinDist; // uint32_t
    public static nint m_nMaxDist; // uint32_t
    public static nint m_nOuterMaxDist; // uint32_t
    public static nint m_flGlowProxySize; // float
    public static nint m_flHDRColorScale; // float
    public static nint m_Glow; // C_LightGlowOverlay
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightGlowOverlay { // CGlowOverlay
    public static nint m_vecOrigin; // Vector
    public static nint m_vecDirection; // Vector
    public static nint m_nMinDist; // int32_t
    public static nint m_nMaxDist; // int32_t
    public static nint m_nOuterMaxDist; // int32_t
    public static nint m_bOneSided; // bool
    public static nint m_bModulateByDot; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightOrthoEntity { // C_LightEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LightSpotEntity { // C_LightEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_LocalTempEntity { // CBaseAnimGraph
    public static nint flags; // int32_t
    public static nint die; // GameTime_t
    public static nint m_flFrameMax; // float
    public static nint x; // float
    public static nint y; // float
    public static nint fadeSpeed; // float
    public static nint bounceFactor; // float
    public static nint hitSound; // int32_t
    public static nint priority; // int32_t
    public static nint tentOffset; // Vector
    public static nint m_vecTempEntAngVelocity; // QAngle
    public static nint tempent_renderamt; // int32_t
    public static nint m_vecNormal; // Vector
    public static nint m_flSpriteScale; // float
    public static nint m_nFlickerFrame; // int32_t
    public static nint m_flFrameRate; // float
    public static nint m_flFrame; // float
    public static nint m_pszImpactEffect; // char*
    public static nint m_pszParticleEffect; // char*
    public static nint m_bParticleCollision; // bool
    public static nint m_iLastCollisionFrame; // int32_t
    public static nint m_vLastCollisionOrigin; // Vector
    public static nint m_vecTempEntVelocity; // Vector
    public static nint m_vecPrevAbsOrigin; // Vector
    public static nint m_vecTempEntAcceleration; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_MapPreviewParticleSystem { // C_ParticleSystem
}

[OffsetsWithFilePath("client.dll.json")] public static class C_MapVetoPickController { // C_BaseEntity
    public static nint m_nDraftType; // int32_t
    public static nint m_nTeamWinningCoinToss; // int32_t
    public static nint m_nTeamWithFirstChoice; // int32_t[64]
    public static nint m_nVoteMapIdsList; // int32_t[7]
    public static nint m_nAccountIDs; // int32_t[64]
    public static nint m_nMapId0; // int32_t[64]
    public static nint m_nMapId1; // int32_t[64]
    public static nint m_nMapId2; // int32_t[64]
    public static nint m_nMapId3; // int32_t[64]
    public static nint m_nMapId4; // int32_t[64]
    public static nint m_nMapId5; // int32_t[64]
    public static nint m_nStartingSide0; // int32_t[64]
    public static nint m_nCurrentPhase; // int32_t
    public static nint m_nPhaseStartTick; // int32_t
    public static nint m_nPhaseDurationTicks; // int32_t
    public static nint m_nPostDataUpdateTick; // int32_t
    public static nint m_bDisabledHud; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Melee { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ModelPointEntity { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_MolotovGrenade { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_MolotovProjectile { // C_BaseCSGrenadeProjectile
    public static nint m_bIsIncGrenade; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Multimeter { // CBaseAnimGraph
    public static nint m_hTargetC4; // CHandle<C_PlantedC4>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_MultiplayRules { // C_GameRules
}

[OffsetsWithFilePath("client.dll.json")] public static class C_NetTestBaseCombatCharacter { // C_BaseCombatCharacter
}

[OffsetsWithFilePath("client.dll.json")] public static class C_OmniLight { // C_BarnLight
    public static nint m_flInnerAngle; // float
    public static nint m_flOuterAngle; // float
    public static nint m_bShowLight; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ParticleSystem { // C_BaseModelEntity
    public static nint m_szSnapshotFileName; // char[512]
    public static nint m_bActive; // bool
    public static nint m_bFrozen; // bool
    public static nint m_flFreezeTransitionDuration; // float
    public static nint m_nStopType; // int32_t
    public static nint m_bAnimateDuringGameplayPause; // bool
    public static nint m_iEffectIndex; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public static nint m_flStartTime; // GameTime_t
    public static nint m_flPreSimTime; // float
    public static nint m_vServerControlPoints; // Vector[4]
    public static nint m_iServerControlPointAssignments; // uint8_t[4]
    public static nint m_hControlPointEnts; // CHandle<C_BaseEntity>[64]
    public static nint m_bNoSave; // bool
    public static nint m_bNoFreeze; // bool
    public static nint m_bNoRamp; // bool
    public static nint m_bStartActive; // bool
    public static nint m_iszEffectName; // CUtlSymbolLarge
    public static nint m_iszControlPointNames; // CUtlSymbolLarge[64]
    public static nint m_nDataCP; // int32_t
    public static nint m_vecDataCPValue; // Vector
    public static nint m_nTintCP; // int32_t
    public static nint m_clrTint; // Color
    public static nint m_bOldActive; // bool
    public static nint m_bOldFrozen; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PathParticleRope { // C_BaseEntity
    public static nint m_bStartActive; // bool
    public static nint m_flMaxSimulationTime; // float
    public static nint m_iszEffectName; // CUtlSymbolLarge
    public static nint m_PathNodes_Name; // CUtlVector<CUtlSymbolLarge>
    public static nint m_flParticleSpacing; // float
    public static nint m_flSlack; // float
    public static nint m_flRadius; // float
    public static nint m_ColorTint; // Color
    public static nint m_nEffectState; // int32_t
    public static nint m_iEffectIndex; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public static nint m_PathNodes_Position; // C_NetworkUtlVectorBase<Vector>
    public static nint m_PathNodes_TangentIn; // C_NetworkUtlVectorBase<Vector>
    public static nint m_PathNodes_TangentOut; // C_NetworkUtlVectorBase<Vector>
    public static nint m_PathNodes_Color; // C_NetworkUtlVectorBase<Vector>
    public static nint m_PathNodes_PinEnabled; // C_NetworkUtlVectorBase<bool>
    public static nint m_PathNodes_RadiusScale; // C_NetworkUtlVectorBase<float>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PathParticleRopeAlias_path_particle_rope_clientside { // C_PathParticleRope
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PhysBox { // C_Breakable
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PhysMagnet { // CBaseAnimGraph
    public static nint m_aAttachedObjectsFromServer; // CUtlVector<int32_t>
    public static nint m_aAttachedObjects; // CUtlVector<CHandle<C_BaseEntity>>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PhysPropClientside { // C_BreakableProp
    public static nint m_flTouchDelta; // GameTime_t
    public static nint m_fDeathTime; // GameTime_t
    public static nint m_impactEnergyScale; // float
    public static nint m_inertiaScale; // float
    public static nint m_flDmgModBullet; // float
    public static nint m_flDmgModClub; // float
    public static nint m_flDmgModExplosive; // float
    public static nint m_flDmgModFire; // float
    public static nint m_iszPhysicsDamageTableName; // CUtlSymbolLarge
    public static nint m_iszBasePropData; // CUtlSymbolLarge
    public static nint m_iInteractions; // int32_t
    public static nint m_bHasBreakPiecesOrCommands; // bool
    public static nint m_vecDamagePosition; // Vector
    public static nint m_vecDamageDirection; // Vector
    public static nint m_nDamageType; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PhysicsProp { // C_BreakableProp
    public static nint m_bAwake; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PhysicsPropMultiplayer { // C_PhysicsProp
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PickUpModelSlerper { // CBaseAnimGraph
    public static nint m_hPlayerParent; // CHandle<C_BaseEntity>
    public static nint m_hItem; // CHandle<C_BaseEntity>
    public static nint m_flTimePickedUp; // float
    public static nint m_angOriginal; // QAngle
    public static nint m_vecPosOriginal; // Vector
    public static nint m_angRandom; // QAngle
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PlantedC4 { // CBaseAnimGraph
    public static nint m_bBombTicking; // bool
    public static nint m_nBombSite; // int32_t
    public static nint m_nSourceSoundscapeHash; // int32_t
    public static nint m_entitySpottedState; // EntitySpottedState_t
    public static nint m_flNextGlow; // GameTime_t
    public static nint m_flNextBeep; // GameTime_t
    public static nint m_flC4Blow; // GameTime_t
    public static nint m_bCannotBeDefused; // bool
    public static nint m_bHasExploded; // bool
    public static nint m_flTimerLength; // float
    public static nint m_bBeingDefused; // bool
    public static nint m_bTriggerWarning; // float
    public static nint m_bExplodeWarning; // float
    public static nint m_bC4Activated; // bool
    public static nint m_bTenSecWarning; // bool
    public static nint m_flDefuseLength; // float
    public static nint m_flDefuseCountDown; // GameTime_t
    public static nint m_bBombDefused; // bool
    public static nint m_hBombDefuser; // CHandle<C_CSPlayerPawn>
    public static nint m_hControlPanel; // CHandle<C_BaseEntity>
    public static nint m_hDefuserMultimeter; // CHandle<C_Multimeter>
    public static nint m_flNextRadarFlashTime; // GameTime_t
    public static nint m_bRadarFlash; // bool
    public static nint m_pBombDefuser; // CHandle<C_CSPlayerPawn>
    public static nint m_fLastDefuseTime; // GameTime_t
    public static nint m_pPredictionOwner; // CBasePlayerController*
    public static nint m_vecC4ExplodeSpectatePos; // Vector
    public static nint m_vecC4ExplodeSpectateAng; // QAngle
    public static nint m_flC4ExplodeSpectateDuration; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PlayerPing { // C_BaseEntity
    public static nint m_hPlayer; // CHandle<C_CSPlayerPawn>
    public static nint m_hPingedEntity; // CHandle<C_BaseEntity>
    public static nint m_iType; // int32_t
    public static nint m_bUrgent; // bool
    public static nint m_szPlaceName; // char[18]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PlayerSprayDecal { // C_ModelPointEntity
    public static nint m_nUniqueID; // int32_t
    public static nint m_unAccountID; // uint32_t
    public static nint m_unTraceID; // uint32_t
    public static nint m_rtGcTime; // uint32_t
    public static nint m_vecEndPos; // Vector
    public static nint m_vecStart; // Vector
    public static nint m_vecLeft; // Vector
    public static nint m_vecNormal; // Vector
    public static nint m_nPlayer; // int32_t
    public static nint m_nEntity; // int32_t
    public static nint m_nHitbox; // int32_t
    public static nint m_flCreationTime; // float
    public static nint m_nTintID; // int32_t
    public static nint m_nVersion; // uint8_t
    public static nint m_ubSignature; // uint8_t[128]
    public static nint m_SprayRenderHelper; // CPlayerSprayDecalRenderHelper
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PlayerVisibility { // C_BaseEntity
    public static nint m_flVisibilityStrength; // float
    public static nint m_flFogDistanceMultiplier; // float
    public static nint m_flFogMaxDensityMultiplier; // float
    public static nint m_flFadeTime; // float
    public static nint m_bStartDisabled; // bool
    public static nint m_bIsEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointCamera { // C_BaseEntity
    public static nint m_FOV; // float
    public static nint m_Resolution; // float
    public static nint m_bFogEnable; // bool
    public static nint m_FogColor; // Color
    public static nint m_flFogStart; // float
    public static nint m_flFogEnd; // float
    public static nint m_flFogMaxDensity; // float
    public static nint m_bActive; // bool
    public static nint m_bUseScreenAspectRatio; // bool
    public static nint m_flAspectRatio; // float
    public static nint m_bNoSky; // bool
    public static nint m_fBrightness; // float
    public static nint m_flZFar; // float
    public static nint m_flZNear; // float
    public static nint m_bCanHLTVUse; // bool
    public static nint m_bDofEnabled; // bool
    public static nint m_flDofNearBlurry; // float
    public static nint m_flDofNearCrisp; // float
    public static nint m_flDofFarCrisp; // float
    public static nint m_flDofFarBlurry; // float
    public static nint m_flDofTiltToGround; // float
    public static nint m_TargetFOV; // float
    public static nint m_DegreesPerSecond; // float
    public static nint m_bIsOn; // bool
    public static nint m_pNext; // C_PointCamera*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointCameraVFOV { // C_PointCamera
    public static nint m_flVerticalFOV; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointClientUIDialog { // C_BaseClientUIEntity
    public static nint m_hActivator; // CHandle<C_BaseEntity>
    public static nint m_bStartEnabled; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointClientUIHUD { // C_BaseClientUIEntity
    public static nint m_bCheckCSSClasses; // bool
    public static nint m_bIgnoreInput; // bool
    public static nint m_flWidth; // float
    public static nint m_flHeight; // float
    public static nint m_flDPI; // float
    public static nint m_flInteractDistance; // float
    public static nint m_flDepthOffset; // float
    public static nint m_unOwnerContext; // uint32_t
    public static nint m_unHorizontalAlign; // uint32_t
    public static nint m_unVerticalAlign; // uint32_t
    public static nint m_unOrientation; // uint32_t
    public static nint m_bAllowInteractionFromAllSceneWorlds; // bool
    public static nint m_vecCSSClasses; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointClientUIWorldPanel { // C_BaseClientUIEntity
    public static nint m_bForceRecreateNextUpdate; // bool
    public static nint m_bMoveViewToPlayerNextThink; // bool
    public static nint m_bCheckCSSClasses; // bool
    public static nint m_anchorDeltaTransform; // CTransform
    public static nint m_pOffScreenIndicator; // CPointOffScreenIndicatorUi*
    public static nint m_bIgnoreInput; // bool
    public static nint m_bLit; // bool
    public static nint m_bFollowPlayerAcrossTeleport; // bool
    public static nint m_flWidth; // float
    public static nint m_flHeight; // float
    public static nint m_flDPI; // float
    public static nint m_flInteractDistance; // float
    public static nint m_flDepthOffset; // float
    public static nint m_unOwnerContext; // uint32_t
    public static nint m_unHorizontalAlign; // uint32_t
    public static nint m_unVerticalAlign; // uint32_t
    public static nint m_unOrientation; // uint32_t
    public static nint m_bAllowInteractionFromAllSceneWorlds; // bool
    public static nint m_vecCSSClasses; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
    public static nint m_bOpaque; // bool
    public static nint m_bNoDepth; // bool
    public static nint m_bRenderBackface; // bool
    public static nint m_bUseOffScreenIndicator; // bool
    public static nint m_bExcludeFromSaveGames; // bool
    public static nint m_bGrabbable; // bool
    public static nint m_bOnlyRenderToTexture; // bool
    public static nint m_bDisableMipGen; // bool
    public static nint m_nExplicitImageLayout; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointClientUIWorldTextPanel { // C_PointClientUIWorldPanel
    public static nint m_messageText; // char[512]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointCommentaryNode { // CBaseAnimGraph
    public static nint m_bActive; // bool
    public static nint m_bWasActive; // bool
    public static nint m_flEndTime; // GameTime_t
    public static nint m_flStartTime; // GameTime_t
    public static nint m_flStartTimeInCommentary; // float
    public static nint m_iszCommentaryFile; // CUtlSymbolLarge
    public static nint m_iszTitle; // CUtlSymbolLarge
    public static nint m_iszSpeakers; // CUtlSymbolLarge
    public static nint m_iNodeNumber; // int32_t
    public static nint m_iNodeNumberMax; // int32_t
    public static nint m_bListenedTo; // bool
    public static nint m_hViewPosition; // CHandle<C_BaseEntity>
    public static nint m_bRestartAfterRestore; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointEntity { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointValueRemapper { // C_BaseEntity
    public static nint m_bDisabled; // bool
    public static nint m_bDisabledOld; // bool
    public static nint m_bUpdateOnClient; // bool
    public static nint m_nInputType; // ValueRemapperInputType_t
    public static nint m_hRemapLineStart; // CHandle<C_BaseEntity>
    public static nint m_hRemapLineEnd; // CHandle<C_BaseEntity>
    public static nint m_flMaximumChangePerSecond; // float
    public static nint m_flDisengageDistance; // float
    public static nint m_flEngageDistance; // float
    public static nint m_bRequiresUseKey; // bool
    public static nint m_nOutputType; // ValueRemapperOutputType_t
    public static nint m_hOutputEntities; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
    public static nint m_nHapticsType; // ValueRemapperHapticsType_t
    public static nint m_nMomentumType; // ValueRemapperMomentumType_t
    public static nint m_flMomentumModifier; // float
    public static nint m_flSnapValue; // float
    public static nint m_flCurrentMomentum; // float
    public static nint m_nRatchetType; // ValueRemapperRatchetType_t
    public static nint m_flRatchetOffset; // float
    public static nint m_flInputOffset; // float
    public static nint m_bEngaged; // bool
    public static nint m_bFirstUpdate; // bool
    public static nint m_flPreviousValue; // float
    public static nint m_flPreviousUpdateTickTime; // GameTime_t
    public static nint m_vecPreviousTestPoint; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PointWorldText { // C_ModelPointEntity
    public static nint m_bForceRecreateNextUpdate; // bool
    public static nint m_messageText; // char[512]
    public static nint m_FontName; // char[64]
    public static nint m_bEnabled; // bool
    public static nint m_bFullbright; // bool
    public static nint m_flWorldUnitsPerPx; // float
    public static nint m_flFontSize; // float
    public static nint m_flDepthOffset; // float
    public static nint m_Color; // Color
    public static nint m_nJustifyHorizontal; // PointWorldTextJustifyHorizontal_t
    public static nint m_nJustifyVertical; // PointWorldTextJustifyVertical_t
    public static nint m_nReorientMode; // PointWorldTextReorientMode_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PostProcessingVolume { // C_BaseTrigger
    public static nint m_hPostSettings; // CStrongHandle<InfoForResourceTypeCPostProcessingResource>
    public static nint m_flFadeDuration; // float
    public static nint m_flMinLogExposure; // float
    public static nint m_flMaxLogExposure; // float
    public static nint m_flMinExposure; // float
    public static nint m_flMaxExposure; // float
    public static nint m_flExposureCompensation; // float
    public static nint m_flExposureFadeSpeedUp; // float
    public static nint m_flExposureFadeSpeedDown; // float
    public static nint m_flTonemapEVSmoothingRange; // float
    public static nint m_bMaster; // bool
    public static nint m_bExposureControl; // bool
    public static nint m_flRate; // float
    public static nint m_flTonemapPercentTarget; // float
    public static nint m_flTonemapPercentBrightPixels; // float
    public static nint m_flTonemapMinAvgLum; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Precipitation { // C_BaseTrigger
    public static nint m_flDensity; // float
    public static nint m_flParticleInnerDist; // float
    public static nint m_pParticleDef; // char*
    public static nint m_tParticlePrecipTraceTimer; // TimedEvent[1]
    public static nint m_bActiveParticlePrecipEmitter; // bool[1]
    public static nint m_bParticlePrecipInitialized; // bool
    public static nint m_bHasSimulatedSinceLastSceneObjectUpdate; // bool
    public static nint m_nAvailableSheetSequencesMaxIndex; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PrecipitationBlocker { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PredictedViewModel { // C_BaseViewModel
    public static nint m_vPredictedLagOffset; // Vector
    public static nint m_targetSpeed; // QAngle
    public static nint m_currentSpeed; // QAngle
}

[OffsetsWithFilePath("client.dll.json")] public static class C_PropDoorRotating { // C_BasePropDoor
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RagdollManager { // C_BaseEntity
    public static nint m_iCurrentMaxRagdollCount; // int8_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RagdollProp { // CBaseAnimGraph
    public static nint m_ragPos; // C_NetworkUtlVectorBase<Vector>
    public static nint m_ragAngles; // C_NetworkUtlVectorBase<QAngle>
    public static nint m_flBlendWeight; // float
    public static nint m_hRagdollSource; // CHandle<C_BaseEntity>
    public static nint m_iEyeAttachment; // AttachmentHandle_t
    public static nint m_flBlendWeightCurrent; // float
    public static nint m_parentPhysicsBoneIndices; // CUtlVector<int32_t>
    public static nint m_worldSpaceBoneComputationOrder; // CUtlVector<int32_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RagdollPropAttached { // C_RagdollProp
    public static nint m_boneIndexAttached; // uint32_t
    public static nint m_ragdollAttachedObjectIndex; // uint32_t
    public static nint m_attachmentPointBoneSpace; // Vector
    public static nint m_attachmentPointRagdollSpace; // Vector
    public static nint m_vecOffset; // Vector
    public static nint m_parentTime; // float
    public static nint m_bHasParent; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RectLight { // C_BarnLight
    public static nint m_bShowLight; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RetakeGameRules {
    public static nint m_nMatchSeed; // int32_t
    public static nint m_bBlockersPresent; // bool
    public static nint m_bRoundInProgress; // bool
    public static nint m_iFirstSecondHalfRound; // int32_t
    public static nint m_iBombSite; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RopeKeyframe { // C_BaseModelEntity
    public static nint m_LinksTouchingSomething; // CBitVec<10>
    public static nint m_nLinksTouchingSomething; // int32_t
    public static nint m_bApplyWind; // bool
    public static nint m_fPrevLockedPoints; // int32_t
    public static nint m_iForcePointMoveCounter; // int32_t
    public static nint m_bPrevEndPointPos; // bool[2]
    public static nint m_vPrevEndPointPos; // Vector[2]
    public static nint m_flCurScroll; // float
    public static nint m_flScrollSpeed; // float
    public static nint m_RopeFlags; // uint16_t
    public static nint m_iRopeMaterialModelIndex; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_LightValues; // Vector[10]
    public static nint m_nSegments; // uint8_t
    public static nint m_hStartPoint; // CHandle<C_BaseEntity>
    public static nint m_hEndPoint; // CHandle<C_BaseEntity>
    public static nint m_iStartAttachment; // AttachmentHandle_t
    public static nint m_iEndAttachment; // AttachmentHandle_t
    public static nint m_Subdiv; // uint8_t
    public static nint m_RopeLength; // int16_t
    public static nint m_Slack; // int16_t
    public static nint m_TextureScale; // float
    public static nint m_fLockedPoints; // uint8_t
    public static nint m_nChangeCount; // uint8_t
    public static nint m_Width; // float
    public static nint m_PhysicsDelegate; // C_RopeKeyframe::CPhysicsDelegate
    public static nint m_hMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_TextureHeight; // int32_t
    public static nint m_vecImpulse; // Vector
    public static nint m_vecPreviousImpulse; // Vector
    public static nint m_flCurrentGustTimer; // float
    public static nint m_flCurrentGustLifetime; // float
    public static nint m_flTimeToNextGust; // float
    public static nint m_vWindDir; // Vector
    public static nint m_vColorMod; // Vector
    public static nint m_vCachedEndPointAttachmentPos; // Vector[2]
    public static nint m_vCachedEndPointAttachmentAngle; // QAngle[2]
    public static nint m_bConstrainBetweenEndpoints; // bool
    public static nint m_bEndPointAttachmentPositionsDirty; // bitfield:1
    public static nint m_bEndPointAttachmentAnglesDirty; // bitfield:1
    public static nint m_bNewDataThisFrame; // bitfield:1
    public static nint m_bPhysicsInitted; // bitfield:1
}

[OffsetsWithFilePath("client.dll.json")] public static class C_RopeKeyframe_CPhysicsDelegate {
    public static nint m_pKeyframe; // C_RopeKeyframe*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SceneEntity { // C_PointEntity
    public static nint m_bIsPlayingBack; // bool
    public static nint m_bPaused; // bool
    public static nint m_bMultiplayer; // bool
    public static nint m_bAutogenerated; // bool
    public static nint m_flForceClientTime; // float
    public static nint m_nSceneStringIndex; // uint16_t
    public static nint m_bClientOnly; // bool
    public static nint m_hOwner; // CHandle<C_BaseFlex>
    public static nint m_hActorList; // C_NetworkUtlVectorBase<CHandle<C_BaseFlex>>
    public static nint m_bWasPlaying; // bool
    public static nint m_QueuedEvents; // CUtlVector<C_SceneEntity::QueuedEvents_t>
    public static nint m_flCurrentTime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SceneEntity_QueuedEvents_t {
    public static nint starttime; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SensorGrenade { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SensorGrenadeProjectile { // C_BaseCSGrenadeProjectile
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ShatterGlassShardPhysics { // C_PhysicsProp
    public static nint m_ShardDesc; // shard_model_desc_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SingleplayRules { // C_GameRules
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SkyCamera { // C_BaseEntity
    public static nint m_skyboxData; // sky3dparams_t
    public static nint m_skyboxSlotToken; // CUtlStringToken
    public static nint m_bUseAngles; // bool
    public static nint m_pNext; // C_SkyCamera*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SmokeGrenade { // C_BaseCSGrenade
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SmokeGrenadeProjectile { // C_BaseCSGrenadeProjectile
    public static nint m_nSmokeEffectTickBegin; // int32_t
    public static nint m_bDidSmokeEffect; // bool
    public static nint m_nRandomSeed; // int32_t
    public static nint m_vSmokeColor; // Vector
    public static nint m_vSmokeDetonationPos; // Vector
    public static nint m_VoxelFrameData; // CUtlVector<uint8_t>
    public static nint m_bSmokeVolumeDataReceived; // bool
    public static nint m_bSmokeEffectSpawned; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundAreaEntityBase { // C_BaseEntity
    public static nint m_bDisabled; // bool
    public static nint m_bWasEnabled; // bool
    public static nint m_iszSoundAreaType; // CUtlSymbolLarge
    public static nint m_vPos; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundAreaEntityOrientedBox { // C_SoundAreaEntityBase
    public static nint m_vMin; // Vector
    public static nint m_vMax; // Vector
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundAreaEntitySphere { // C_SoundAreaEntityBase
    public static nint m_flRadius; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetAABBEntity { // C_SoundOpvarSetPointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetAutoRoomEntity { // C_SoundOpvarSetPointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetOBBEntity { // C_SoundOpvarSetAABBEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetOBBWindEntity { // C_SoundOpvarSetPointBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetPathCornerEntity { // C_SoundOpvarSetPointEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetPointBase { // C_BaseEntity
    public static nint m_iszStackName; // CUtlSymbolLarge
    public static nint m_iszOperatorName; // CUtlSymbolLarge
    public static nint m_iszOpvarName; // CUtlSymbolLarge
    public static nint m_iOpvarIndex; // int32_t
    public static nint m_bUseAutoCompare; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SoundOpvarSetPointEntity { // C_SoundOpvarSetPointBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SpotlightEnd { // C_BaseModelEntity
    public static nint m_flLightScale; // float
    public static nint m_Radius; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Sprite { // C_BaseModelEntity
    public static nint m_hSpriteMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_hAttachedToEntity; // CHandle<C_BaseEntity>
    public static nint m_nAttachment; // AttachmentHandle_t
    public static nint m_flSpriteFramerate; // float
    public static nint m_flFrame; // float
    public static nint m_flDieTime; // GameTime_t
    public static nint m_nBrightness; // uint32_t
    public static nint m_flBrightnessDuration; // float
    public static nint m_flSpriteScale; // float
    public static nint m_flScaleDuration; // float
    public static nint m_bWorldSpaceScale; // bool
    public static nint m_flGlowProxySize; // float
    public static nint m_flHDRColorScale; // float
    public static nint m_flLastTime; // GameTime_t
    public static nint m_flMaxFrame; // float
    public static nint m_flStartScale; // float
    public static nint m_flDestScale; // float
    public static nint m_flScaleTimeStart; // GameTime_t
    public static nint m_nStartBrightness; // int32_t
    public static nint m_nDestBrightness; // int32_t
    public static nint m_flBrightnessTimeStart; // GameTime_t
    public static nint m_hOldSpriteMaterial; // CWeakHandle<InfoForResourceTypeIMaterial2>
    public static nint m_nSpriteWidth; // int32_t
    public static nint m_nSpriteHeight; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SpriteOriented { // C_Sprite
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Sun { // C_BaseModelEntity
    public static nint m_fxSSSunFlareEffectIndex; // ParticleIndex_t
    public static nint m_fxSunFlareEffectIndex; // ParticleIndex_t
    public static nint m_fdistNormalize; // float
    public static nint m_vSunPos; // Vector
    public static nint m_vDirection; // Vector
    public static nint m_iszEffectName; // CUtlSymbolLarge
    public static nint m_iszSSEffectName; // CUtlSymbolLarge
    public static nint m_clrOverlay; // Color
    public static nint m_bOn; // bool
    public static nint m_bmaxColor; // bool
    public static nint m_flSize; // float
    public static nint m_flHazeScale; // float
    public static nint m_flRotation; // float
    public static nint m_flHDRColorScale; // float
    public static nint m_flAlphaHaze; // float
    public static nint m_flAlphaScale; // float
    public static nint m_flAlphaHdr; // float
    public static nint m_flFarZScale; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_SunGlowOverlay { // CGlowOverlay
    public static nint m_bModulateByDot; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_Team { // C_BaseEntity
    public static nint m_aPlayerControllers; // C_NetworkUtlVectorBase<CHandle<CBasePlayerController>>
    public static nint m_aPlayers; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerPawn>>
    public static nint m_iScore; // int32_t
    public static nint m_szTeamname; // char[129]
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TeamRoundTimer { // C_BaseEntity
    public static nint m_bTimerPaused; // bool
    public static nint m_flTimeRemaining; // float
    public static nint m_flTimerEndTime; // GameTime_t
    public static nint m_bIsDisabled; // bool
    public static nint m_bShowInHUD; // bool
    public static nint m_nTimerLength; // int32_t
    public static nint m_nTimerInitialLength; // int32_t
    public static nint m_nTimerMaxLength; // int32_t
    public static nint m_bAutoCountdown; // bool
    public static nint m_nSetupTimeLength; // int32_t
    public static nint m_nState; // int32_t
    public static nint m_bStartPaused; // bool
    public static nint m_bInCaptureWatchState; // bool
    public static nint m_flTotalTime; // float
    public static nint m_bStopWatchTimer; // bool
    public static nint m_bFireFinished; // bool
    public static nint m_bFire5MinRemain; // bool
    public static nint m_bFire4MinRemain; // bool
    public static nint m_bFire3MinRemain; // bool
    public static nint m_bFire2MinRemain; // bool
    public static nint m_bFire1MinRemain; // bool
    public static nint m_bFire30SecRemain; // bool
    public static nint m_bFire10SecRemain; // bool
    public static nint m_bFire5SecRemain; // bool
    public static nint m_bFire4SecRemain; // bool
    public static nint m_bFire3SecRemain; // bool
    public static nint m_bFire2SecRemain; // bool
    public static nint m_bFire1SecRemain; // bool
    public static nint m_nOldTimerLength; // int32_t
    public static nint m_nOldTimerState; // int32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TeamplayRules { // C_MultiplayRules
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TextureBasedAnimatable { // C_BaseModelEntity
    public static nint m_bLoop; // bool
    public static nint m_flFPS; // float
    public static nint m_hPositionKeys; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_hRotationKeys; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public static nint m_vAnimationBoundsMin; // Vector
    public static nint m_vAnimationBoundsMax; // Vector
    public static nint m_flStartTime; // float
    public static nint m_flStartFrame; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TintController { // C_BaseEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TonemapController2 { // C_BaseEntity
    public static nint m_flAutoExposureMin; // float
    public static nint m_flAutoExposureMax; // float
    public static nint m_flTonemapPercentTarget; // float
    public static nint m_flTonemapPercentBrightPixels; // float
    public static nint m_flTonemapMinAvgLum; // float
    public static nint m_flExposureAdaptationSpeedUp; // float
    public static nint m_flExposureAdaptationSpeedDown; // float
    public static nint m_flTonemapEVSmoothingRange; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TonemapController2Alias_env_tonemap_controller2 { // C_TonemapController2
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TriggerBuoyancy { // C_BaseTrigger
    public static nint m_BuoyancyHelper; // CBuoyancyHelper
    public static nint m_flFluidDensity; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TriggerLerpObject { // C_BaseTrigger
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TriggerMultiple { // C_BaseTrigger
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TriggerPhysics { // C_BaseTrigger
    public static nint m_gravityScale; // float
    public static nint m_linearLimit; // float
    public static nint m_linearDamping; // float
    public static nint m_angularLimit; // float
    public static nint m_angularDamping; // float
    public static nint m_linearForce; // float
    public static nint m_flFrequency; // float
    public static nint m_flDampingRatio; // float
    public static nint m_vecLinearForcePointAt; // Vector
    public static nint m_bCollapseToForcePoint; // bool
    public static nint m_vecLinearForcePointAtWorld; // Vector
    public static nint m_vecLinearForceDirection; // Vector
    public static nint m_bConvertToDebrisWhenPossible; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_TriggerVolume { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ViewmodelAttachmentModel { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_ViewmodelWeapon { // CBaseAnimGraph
    public static nint m_worldModel; // char*
}

[OffsetsWithFilePath("client.dll.json")] public static class C_VoteController { // C_BaseEntity
    public static nint m_iActiveIssueIndex; // int32_t
    public static nint m_iOnlyTeamToVote; // int32_t
    public static nint m_nVoteOptionCount; // int32_t[5]
    public static nint m_nPotentialVotes; // int32_t
    public static nint m_bVotesDirty; // bool
    public static nint m_bTypeDirty; // bool
    public static nint m_bIsYesNoVote; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WaterBullet { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponAWP { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponAug { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponBaseItem { // C_CSWeaponBase
    public static nint m_SequenceCompleteTimer; // CountdownTimer
    public static nint m_bRedraw; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponBizon { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponCZ75a { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponElite { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponFamas { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponFiveSeven { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponG3SG1 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponGalilAR { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponGlock { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponHKP2000 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponM249 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponM4A1 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponM4A1Silencer { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponMAC10 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponMP5SD { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponMP7 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponMP9 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponMag7 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponNOVA { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponNegev { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponP250 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponP90 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponRevolver { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponSCAR20 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponSG556 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponSSG08 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponSawedoff { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponShield { // C_CSWeaponBaseGun
    public static nint m_flDisplayHealth; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponTaser { // C_CSWeaponBaseGun
    public static nint m_fFireTime; // GameTime_t
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponTec9 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponUMP45 { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponUSPSilencer { // C_CSWeaponBaseGun
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WeaponXM1014 { // C_CSWeaponBase
}

[OffsetsWithFilePath("client.dll.json")] public static class C_World { // C_BaseModelEntity
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WorldModelGloves { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WorldModelNametag { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_WorldModelStattrak { // CBaseAnimGraph
}

[OffsetsWithFilePath("client.dll.json")] public static class C_fogplayerparams_t {
    public static nint m_hCtrl; // CHandle<C_FogController>
    public static nint m_flTransitionTime; // float
    public static nint m_OldColor; // Color
    public static nint m_flOldStart; // float
    public static nint m_flOldEnd; // float
    public static nint m_flOldMaxDensity; // float
    public static nint m_flOldHDRColorScale; // float
    public static nint m_flOldFarZ; // float
    public static nint m_NewColor; // Color
    public static nint m_flNewStart; // float
    public static nint m_flNewEnd; // float
    public static nint m_flNewMaxDensity; // float
    public static nint m_flNewHDRColorScale; // float
    public static nint m_flNewFarZ; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class CompMatMutatorCondition_t {
    public static nint m_nMutatorCondition; // CompMatPropertyMutatorConditionType_t
    public static nint m_strMutatorConditionContainerName; // CUtlString
    public static nint m_strMutatorConditionContainerVarName; // CUtlString
    public static nint m_strMutatorConditionContainerVarValue; // CUtlString
    public static nint m_bPassWhenTrue; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CompMatPropertyMutator_t {
    public static nint m_bEnabled; // bool
    public static nint m_nMutatorCommandType; // CompMatPropertyMutatorType_t
    public static nint m_strInitWith_Container; // CUtlString
    public static nint m_strCopyProperty_InputContainerSrc; // CUtlString
    public static nint m_strCopyProperty_InputContainerProperty; // CUtlString
    public static nint m_strCopyProperty_TargetProperty; // CUtlString
    public static nint m_strRandomRollInputVars_SeedInputVar; // CUtlString
    public static nint m_vecRandomRollInputVars_InputVarsToRoll; // CUtlVector<CUtlString>
    public static nint m_strCopyMatchingKeys_InputContainerSrc; // CUtlString
    public static nint m_strCopyKeysWithSuffix_InputContainerSrc; // CUtlString
    public static nint m_strCopyKeysWithSuffix_FindSuffix; // CUtlString
    public static nint m_strCopyKeysWithSuffix_ReplaceSuffix; // CUtlString
    public static nint m_nSetValue_Value; // CompositeMaterialInputLooseVariable_t
    public static nint m_strGenerateTexture_TargetParam; // CUtlString
    public static nint m_strGenerateTexture_InitialContainer; // CUtlString
    public static nint m_nResolution; // int32_t
    public static nint m_bIsScratchTarget; // bool
    public static nint m_bSplatDebugInfo; // bool
    public static nint m_bCaptureInRenderDoc; // bool
    public static nint m_vecTexGenInstructions; // CUtlVector<CompMatPropertyMutator_t>
    public static nint m_vecConditionalMutators; // CUtlVector<CompMatPropertyMutator_t>
    public static nint m_strPopInputQueue_Container; // CUtlString
    public static nint m_strDrawText_InputContainerSrc; // CUtlString
    public static nint m_strDrawText_InputContainerProperty; // CUtlString
    public static nint m_vecDrawText_Position; // Vector2D
    public static nint m_colDrawText_Color; // Color
    public static nint m_strDrawText_Font; // CUtlString
    public static nint m_vecConditions; // CUtlVector<CompMatMutatorCondition_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterialAssemblyProcedure_t {
    public static nint m_vecCompMatIncludes; // CUtlVector<CResourceName>
    public static nint m_vecMatchFilters; // CUtlVector<CompositeMaterialMatchFilter_t>
    public static nint m_vecCompositeInputContainers; // CUtlVector<CompositeMaterialInputContainer_t>
    public static nint m_vecPropertyMutators; // CUtlVector<CompMatPropertyMutator_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterialEditorPoint_t {
    public static nint m_ModelName; // CResourceName
    public static nint m_nSequenceIndex; // int32_t
    public static nint m_flCycle; // float
    public static nint m_KVModelStateChoices; // KeyValues3
    public static nint m_bEnableChildModel; // bool
    public static nint m_ChildModelName; // CResourceName
    public static nint m_vecCompositeMaterialAssemblyProcedures; // CUtlVector<CompositeMaterialAssemblyProcedure_t>
    public static nint m_vecCompositeMaterials; // CUtlVector<CompositeMaterial_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterialInputContainer_t {
    public static nint m_bEnabled; // bool
    public static nint m_nCompositeMaterialInputContainerSourceType; // CompositeMaterialInputContainerSourceType_t
    public static nint m_strSpecificContainerMaterial; // CResourceName
    public static nint m_strAttrName; // CUtlString
    public static nint m_strAlias; // CUtlString
    public static nint m_vecLooseVariables; // CUtlVector<CompositeMaterialInputLooseVariable_t>
    public static nint m_strAttrNameForVar; // CUtlString
    public static nint m_bExposeExternally; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterialInputLooseVariable_t {
    public static nint m_strName; // CUtlString
    public static nint m_bExposeExternally; // bool
    public static nint m_strExposedFriendlyName; // CUtlString
    public static nint m_strExposedFriendlyGroupName; // CUtlString
    public static nint m_bExposedVariableIsFixedRange; // bool
    public static nint m_strExposedVisibleWhenTrue; // CUtlString
    public static nint m_strExposedHiddenWhenTrue; // CUtlString
    public static nint m_nVariableType; // CompositeMaterialInputLooseVariableType_t
    public static nint m_bValueBoolean; // bool
    public static nint m_nValueIntX; // int32_t
    public static nint m_nValueIntY; // int32_t
    public static nint m_nValueIntZ; // int32_t
    public static nint m_nValueIntW; // int32_t
    public static nint m_bHasFloatBounds; // bool
    public static nint m_flValueFloatX; // float
    public static nint m_flValueFloatX_Min; // float
    public static nint m_flValueFloatX_Max; // float
    public static nint m_flValueFloatY; // float
    public static nint m_flValueFloatY_Min; // float
    public static nint m_flValueFloatY_Max; // float
    public static nint m_flValueFloatZ; // float
    public static nint m_flValueFloatZ_Min; // float
    public static nint m_flValueFloatZ_Max; // float
    public static nint m_flValueFloatW; // float
    public static nint m_flValueFloatW_Min; // float
    public static nint m_flValueFloatW_Max; // float
    public static nint m_cValueColor4; // Color
    public static nint m_nValueSystemVar; // CompositeMaterialVarSystemVar_t
    public static nint m_strResourceMaterial; // CResourceName
    public static nint m_strTextureContentAssetPath; // CUtlString
    public static nint m_strTextureRuntimeResourcePath; // CResourceName
    public static nint m_strTextureCompilationVtexTemplate; // CUtlString
    public static nint m_nTextureType; // CompositeMaterialInputTextureType_t
    public static nint m_strString; // CUtlString
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterialMatchFilter_t {
    public static nint m_nCompositeMaterialMatchFilterType; // CompositeMaterialMatchFilterType_t
    public static nint m_strMatchFilter; // CUtlString
    public static nint m_strMatchValue; // CUtlString
    public static nint m_bPassWhenTrue; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class CompositeMaterial_t {
    public static nint m_TargetKVs; // KeyValues3
    public static nint m_PreGenerationKVs; // KeyValues3
    public static nint m_FinalKVs; // KeyValues3
    public static nint m_vecGeneratedTextures; // CUtlVector<GeneratedTextureHandle_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class CountdownTimer {
    public static nint m_duration; // float
    public static nint m_timestamp; // GameTime_t
    public static nint m_timescale; // float
    public static nint m_nWorldGroupId; // WorldGroupId_t
}

[OffsetsWithFilePath("client.dll.json")] public static class EngineCountdownTimer {
    public static nint m_duration; // float
    public static nint m_timestamp; // float
    public static nint m_timescale; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class EntityRenderAttribute_t {
    public static nint m_ID; // CUtlStringToken
    public static nint m_Values; // Vector4D
}

[OffsetsWithFilePath("client.dll.json")] public static class EntitySpottedState_t {
    public static nint m_bSpotted; // bool
    public static nint m_bSpottedByMask; // uint32_t[2]
}

[OffsetsWithFilePath("client.dll.json")] public static class GeneratedTextureHandle_t {
    public static nint m_strBitmapName; // CUtlString
}

[OffsetsWithFilePath("client.dll.json")] public static class IClientAlphaProperty {
}

[OffsetsWithFilePath("client.dll.json")] public static class IntervalTimer {
    public static nint m_timestamp; // GameTime_t
    public static nint m_nWorldGroupId; // WorldGroupId_t
}

[OffsetsWithFilePath("client.dll.json")] public static class PhysicsRagdollPose_t {
    public static nint __m_pChainEntity; // CNetworkVarChainer
    public static nint m_Transforms; // C_NetworkUtlVectorBase<CTransform>
    public static nint m_hOwner; // CHandle<C_BaseEntity>
    public static nint m_bDirty; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class SellbackPurchaseEntry_t {
    public static nint m_unDefIdx; // uint16_t
    public static nint m_nCost; // int32_t
    public static nint m_nPrevArmor; // int32_t
    public static nint m_bPrevHelmet; // bool
    public static nint m_hItem; // CEntityHandle
}

[OffsetsWithFilePath("client.dll.json")] public static class SequenceHistory_t {
    public static nint m_hSequence; // HSequence
    public static nint m_flSeqStartTime; // GameTime_t
    public static nint m_flSeqFixedCycle; // float
    public static nint m_nSeqLoopMode; // AnimLoopMode_t
    public static nint m_flPlaybackRate; // float
    public static nint m_flCyclesPerSecond; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class ServerAuthoritativeWeaponSlot_t {
    public static nint unClass; // uint16_t
    public static nint unSlot; // uint16_t
    public static nint unItemDefIdx; // uint16_t
}

[OffsetsWithFilePath("client.dll.json")] public static class TimedEvent {
    public static nint m_TimeBetweenEvents; // float
    public static nint m_fNextEvent; // float
}

[OffsetsWithFilePath("client.dll.json")] public static class VPhysicsCollisionAttribute_t {
    public static nint m_nInteractsAs; // uint64_t
    public static nint m_nInteractsWith; // uint64_t
    public static nint m_nInteractsExclude; // uint64_t
    public static nint m_nEntityId; // uint32_t
    public static nint m_nOwnerId; // uint32_t
    public static nint m_nHierarchyId; // uint16_t
    public static nint m_nCollisionGroup; // uint8_t
    public static nint m_nCollisionFunctionMask; // uint8_t
}

[OffsetsWithFilePath("client.dll.json")] public static class ViewAngleServerChange_t {
    public static nint nType; // FixAngleSet_t
    public static nint qAngle; // QAngle
    public static nint nIndex; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class WeaponPurchaseCount_t {
    public static nint m_nItemDefIndex; // uint16_t
    public static nint m_nCount; // uint16_t
}

[OffsetsWithFilePath("client.dll.json")] public static class WeaponPurchaseTracker_t {
    public static nint m_weaponPurchases; // C_UtlVectorEmbeddedNetworkVar<WeaponPurchaseCount_t>
}

[OffsetsWithFilePath("client.dll.json")] public static class audioparams_t {
    public static nint localSound; // Vector[8]
    public static nint soundscapeIndex; // int32_t
    public static nint localBits; // uint8_t
    public static nint soundscapeEntityListIndex; // int32_t
    public static nint soundEventHash; // uint32_t
}

[OffsetsWithFilePath("client.dll.json")] public static class fogparams_t {
    public static nint dirPrimary; // Vector
    public static nint colorPrimary; // Color
    public static nint colorSecondary; // Color
    public static nint colorPrimaryLerpTo; // Color
    public static nint colorSecondaryLerpTo; // Color
    public static nint start; // float
    public static nint end; // float
    public static nint farz; // float
    public static nint maxdensity; // float
    public static nint exponent; // float
    public static nint HDRColorScale; // float
    public static nint skyboxFogFactor; // float
    public static nint skyboxFogFactorLerpTo; // float
    public static nint startLerpTo; // float
    public static nint endLerpTo; // float
    public static nint maxdensityLerpTo; // float
    public static nint lerptime; // GameTime_t
    public static nint duration; // float
    public static nint blendtobackground; // float
    public static nint scattering; // float
    public static nint locallightscale; // float
    public static nint enable; // bool
    public static nint blend; // bool
    public static nint m_bNoReflectionFog; // bool
    public static nint m_bPadding; // bool
}

[OffsetsWithFilePath("client.dll.json")] public static class shard_model_desc_t {
    public static nint m_nModelID; // int32_t
    public static nint m_hMaterial; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public static nint m_solid; // ShardSolid_t
    public static nint m_ShatterPanelMode; // ShatterPanelMode
    public static nint m_vecPanelSize; // Vector2D
    public static nint m_vecStressPositionA; // Vector2D
    public static nint m_vecStressPositionB; // Vector2D
    public static nint m_vecPanelVertices; // C_NetworkUtlVectorBase<Vector2D>
    public static nint m_flGlassHalfThickness; // float
    public static nint m_bHasParent; // bool
    public static nint m_bParentFrozen; // bool
    public static nint m_SurfacePropStringToken; // CUtlStringToken
}

[OffsetsWithFilePath("client.dll.json")] public static class sky3dparams_t {
    public static nint scale; // int16_t
    public static nint origin; // Vector
    public static nint bClip3DSkyBoxNearToWorldFar; // bool
    public static nint flClip3DSkyBoxNearToWorldFarOffset; // float
    public static nint fog; // fogparams_t
    public static nint m_nWorldGroupID; // WorldGroupId_t
}