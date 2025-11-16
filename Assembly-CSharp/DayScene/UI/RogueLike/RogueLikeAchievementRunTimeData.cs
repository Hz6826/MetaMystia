using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GamePlatform.Systems;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000130 RID: 304
	public class RogueLikeAchievementRunTimeData : Object
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x00114B24 File Offset: 0x00112D24
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeAchievementRunTimeData()
		{
			Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeAchievementRunTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr);
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "s_Instance");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "m_RogueLikeAchievementDic");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "m_RogueLikeAchievementTriggerDic");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_ActiveAchievementFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "m_ActiveAchievementFunc");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_intBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "intBuffer");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_floatBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "floatBuffer");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_booleanBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "booleanBuffer");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_cardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "cardBuffer");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CurrentActiveAchievementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "m_CurrentActiveAchievementTypes");
			RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CoreMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "m_CoreMaps");
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_CurrentActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669585);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_CheckAchievementFinished_Public_Boolean_RogueLikeAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669586);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Boolean_RogueLikeAchievementType_byref_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669587);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_AllRogueLikeAchievementTypes_Public_get_IEnumerable_1_RogueLikeAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669588);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_Instance_Public_Static_get_RogueLikeAchievementRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669589);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__ctor_Private_Void_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669590);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_EnsureInstanceIsNull_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669591);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_InitializeRoguelikeAchievementRunTimeData_Public_Static_RogueLikeAchievementRunTimeData_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669592);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_DisposeRoguelikeAchievementRunTimeData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669593);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_WriteRoguelikeAchievementFile_Public_Static_UniTask_FileSystemHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669594);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_GetAchievementWaitForClaim_Public_get_IEnumerable_1_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669595);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Private_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669596);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669597);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669598);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669599);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_IEnumerable_1_KeyValuePair_2_CardType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669600);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_LimitPass_Public_Void_RogueLikeAchievementTriggerType_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669601);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_InstantHit_Public_Void_RogueLikeAchievementTriggerType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669602);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_ForceTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669603);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_NotifyAchievement_Private_Void_RogueLikeAchievementTriggerType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669604);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_0_Private_Boolean_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669605);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__NotifyAchievement_b__34_1_Private_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669606);
			RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__NotifyAchievement_b__34_2_Private_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, 100669607);
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00114DE8 File Offset: 0x00112FE8
		public unsafe HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> CurrentActiveAchievementTypes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_CurrentActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00114E28 File Offset: 0x00113028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84016, RefRangeEnd = 84018, XrefRangeStart = 84012, XrefRangeEnd = 84016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAchievementFinished(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_CheckAchievementFinished_Public_Boolean_RogueLikeAchievementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00114E74 File Offset: 0x00113074
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84022, RefRangeEnd = 84026, XrefRangeStart = 84018, XrefRangeEnd = 84022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetRogueLikeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, out DLC5_RogueLikeDataProfile.RogueLikeAchievement achievement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Boolean_RogueLikeAchievementType_byref_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			achievement = ((intPtr4 == 0) ? null : new DLC5_RogueLikeDataProfile.RogueLikeAchievement(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x00114EE0 File Offset: 0x001130E0
		public unsafe IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> AllRogueLikeAchievementTypes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84030, RefRangeEnd = 84032, XrefRangeStart = 84026, XrefRangeEnd = 84030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_AllRogueLikeAchievementTypes_Public_get_IEnumerable_1_RogueLikeAchievementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00114F20 File Offset: 0x00113120
		public unsafe static RogueLikeAchievementRunTimeData Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84032, XrefRangeEnd = 84034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_Instance_Public_Static_get_RogueLikeAchievementRunTimeData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00114F54 File Offset: 0x00113154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84126, RefRangeEnd = 84127, XrefRangeStart = 84034, XrefRangeEnd = 84126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeAchievementRunTimeData(HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> currentActiveAchievementTypes, IRogueLikeData rogueLikeData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentActiveAchievementTypes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rogueLikeData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__ctor_Private_Void_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00114FB8 File Offset: 0x001131B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84127, XrefRangeEnd = 84129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureInstanceIsNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_EnsureInstanceIsNull_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00114FE0 File Offset: 0x001131E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84138, RefRangeEnd = 84139, XrefRangeStart = 84129, XrefRangeEnd = 84138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RogueLikeAchievementRunTimeData InitializeRoguelikeAchievementRunTimeData(HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> currentActiveAchievementTypes, IRogueLikeData rogueLikeData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentActiveAchievementTypes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rogueLikeData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_InitializeRoguelikeAchievementRunTimeData_Public_Static_RogueLikeAchievementRunTimeData_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData>(intPtr3) : null;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0011503C File Offset: 0x0011323C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84139, XrefRangeEnd = 84143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeRoguelikeAchievementRunTimeData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_DisposeRoguelikeAchievementRunTimeData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00115064 File Offset: 0x00113264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84149, RefRangeEnd = 84152, XrefRangeStart = 84143, XrefRangeEnd = 84149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask WriteRoguelikeAchievementFile(FileSystemHandle fileSystemHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fileSystemHandle));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_WriteRoguelikeAchievementFile_Public_Static_UniTask_FileSystemHandle_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x001150A8 File Offset: 0x001132A8
		public unsafe IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievement> GetAchievementWaitForClaim
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84180, RefRangeEnd = 84181, XrefRangeStart = 84152, XrefRangeEnd = 84180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_GetAchievementWaitForClaim_Public_get_IEnumerable_1_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x001150E8 File Offset: 0x001132E8
		public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 84183, RefRangeEnd = 84190, XrefRangeStart = 84181, XrefRangeEnd = 84183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Private_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00115128 File Offset: 0x00113328
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 84191, RefRangeEnd = 84199, XrefRangeStart = 84190, XrefRangeEnd = 84191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00115168 File Offset: 0x00113368
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 84202, RefRangeEnd = 84212, XrefRangeStart = 84199, XrefRangeEnd = 84202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, int intValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x001151B4 File Offset: 0x001133B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84215, RefRangeEnd = 84217, XrefRangeStart = 84212, XrefRangeEnd = 84215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, float floatValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00115200 File Offset: 0x00113400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84222, RefRangeEnd = 84223, XrefRangeStart = 84217, XrefRangeEnd = 84222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>> cardValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_IEnumerable_1_KeyValuePair_2_CardType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00115250 File Offset: 0x00113450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84227, RefRangeEnd = 84228, XrefRangeStart = 84223, XrefRangeEnd = 84227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement_LimitPass(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool booleanValue, float floatValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref booleanValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_LimitPass_Public_Void_RogueLikeAchievementTriggerType_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x001152AC File Offset: 0x001134AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84232, RefRangeEnd = 84233, XrefRangeStart = 84228, XrefRangeEnd = 84232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryTriggerTargetTypeAchievement_InstantHit(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool booleanValue, int intValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref booleanValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_InstantHit_Public_Void_RogueLikeAchievementTriggerType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00115308 File Offset: 0x00113508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84234, RefRangeEnd = 84235, XrefRangeStart = 84233, XrefRangeEnd = 84234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceTriggerTargetTypeAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_ForceTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00115348 File Offset: 0x00113548
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 84379, RefRangeEnd = 84391, XrefRangeStart = 84235, XrefRangeEnd = 84379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAchievement(DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType triggerType, bool forceTrigger = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref triggerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTrigger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr_NotifyAchievement_Private_Void_RogueLikeAchievementTriggerType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00115394 File Offset: 0x00113594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84391, XrefRangeEnd = 84396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_GetAchievementWaitForClaim_b__23_0(KeyValuePair<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_0_Private_Boolean_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x001153E8 File Offset: 0x001135E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84396, XrefRangeEnd = 84400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _NotifyAchievement_b__34_1(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__NotifyAchievement_b__34_1_Private_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0011543C File Offset: 0x0011363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84400, XrefRangeEnd = 84411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _NotifyAchievement_b__34_2(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.NativeMethodInfoPtr__NotifyAchievement_b__34_2_Private_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000154F9 File Offset: 0x000136F9
		public RogueLikeAchievementRunTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00115490 File Offset: 0x00113690
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00015502 File Offset: 0x00013702
		public unsafe static RogueLikeAchievementRunTimeData s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x001154B8 File Offset: 0x001136B8
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00015514 File Offset: 0x00013714
		public unsafe Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> m_RogueLikeAchievementDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x001154E8 File Offset: 0x001136E8
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x00015533 File Offset: 0x00013733
		public unsafe Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>> m_RogueLikeAchievementTriggerDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x00115518 File Offset: 0x00113718
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x00015552 File Offset: 0x00013752
		public unsafe Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>> m_ActiveAchievementFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_ActiveAchievementFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_ActiveAchievementFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x00115548 File Offset: 0x00113748
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x00015571 File Offset: 0x00013771
		public unsafe static int intBuffer
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_intBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_intBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x00115564 File Offset: 0x00113764
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x0001557F File Offset: 0x0001377F
		public unsafe static float floatBuffer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_floatBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_floatBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x00115580 File Offset: 0x00113780
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0001558D File Offset: 0x0001378D
		public unsafe static bool booleanBuffer
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_booleanBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_booleanBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0011559C File Offset: 0x0011379C
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0001559B File Offset: 0x0001379B
		public unsafe static IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>> cardBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_cardBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_cardBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x001155C4 File Offset: 0x001137C4
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x000155AD File Offset: 0x000137AD
		public unsafe HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_CurrentActiveAchievementTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CurrentActiveAchievementTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CurrentActiveAchievementTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x001155F4 File Offset: 0x001137F4
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x000155CC File Offset: 0x000137CC
		public unsafe Il2CppStringArray m_CoreMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CoreMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData.NativeFieldInfoPtr_m_CoreMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeAchievementDic;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeAchievementTriggerDic;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveAchievementFunc;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_intBuffer;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_floatBuffer;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_booleanBuffer;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_cardBuffer;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentActiveAchievementTypes;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_m_CoreMaps;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_CheckAchievementFinished_Public_Boolean_RogueLikeAchievementType_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Boolean_RogueLikeAchievementType_byref_RogueLikeAchievement_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_get_AllRogueLikeAchievementTypes_Public_get_IEnumerable_1_RogueLikeAchievementType_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_RogueLikeAchievementRunTimeData_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInstanceIsNull_Private_Static_Void_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRoguelikeAchievementRunTimeData_Public_Static_RogueLikeAchievementRunTimeData_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_DisposeRoguelikeAchievementRunTimeData_Public_Static_Void_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_WriteRoguelikeAchievementFile_Public_Static_UniTask_FileSystemHandle_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_get_GetAchievementWaitForClaim_Public_get_IEnumerable_1_RogueLikeAchievement_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Private_get_RogueLikeRunTimeData_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Int32_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_Single_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_IEnumerable_1_KeyValuePair_2_CardType_Int32_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_LimitPass_Public_Void_RogueLikeAchievementTriggerType_Boolean_Single_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_TryTriggerTargetTypeAchievement_InstantHit_Public_Void_RogueLikeAchievementTriggerType_Boolean_Int32_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_ForceTriggerTargetTypeAchievement_Public_Void_RogueLikeAchievementTriggerType_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAchievement_Private_Void_RogueLikeAchievementTriggerType_Boolean_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_0_Private_Boolean_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_1_Private_Boolean_RogueLikeAchievement_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_2_Private_Boolean_RogueLikeAchievement_0;

		// Token: 0x02000752 RID: 1874
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeAchievementRunTimeData+<WriteRoguelikeAchievementFile>d__21")]
		public sealed class _WriteRoguelikeAchievementFile_d__21 : ValueType
		{
			// Token: 0x06009F74 RID: 40820 RVA: 0x002A1910 File Offset: 0x0029FB10
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteRoguelikeAchievementFile_d__21()
			{
				Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "<WriteRoguelikeAchievementFile>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr);
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, "<>1__state");
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, "<>t__builder");
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr_fileSystemHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, "fileSystemHandle");
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, "<>u__1");
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, 100669608);
				RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr, 100669609);
			}

			// Token: 0x06009F75 RID: 40821 RVA: 0x002A19B4 File Offset: 0x0029FBB4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83962, XrefRangeStart = 83953, XrefRangeEnd = 83960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F76 RID: 40822 RVA: 0x002A19EC File Offset: 0x0029FBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F77 RID: 40823 RVA: 0x000562CA File Offset: 0x000544CA
			public _WriteRoguelikeAchievementFile_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F78 RID: 40824 RVA: 0x000562D3 File Offset: 0x000544D3
			public _WriteRoguelikeAchievementFile_d__21() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x170034A8 RID: 13480
			// (get) Token: 0x06009F79 RID: 40825 RVA: 0x002A1A34 File Offset: 0x0029FC34
			// (set) Token: 0x06009F7A RID: 40826 RVA: 0x000562E5 File Offset: 0x000544E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034A9 RID: 13481
			// (get) Token: 0x06009F7B RID: 40827 RVA: 0x002A1A5C File Offset: 0x0029FC5C
			// (set) Token: 0x06009F7C RID: 40828 RVA: 0x00056300 File Offset: 0x00054500
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034AA RID: 13482
			// (get) Token: 0x06009F7D RID: 40829 RVA: 0x002A1A8C File Offset: 0x0029FC8C
			// (set) Token: 0x06009F7E RID: 40830 RVA: 0x0005632E File Offset: 0x0005452E
			public FileSystemHandle fileSystemHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr_fileSystemHandle);
					return new FileSystemHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr_fileSystemHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034AB RID: 13483
			// (get) Token: 0x06009F7F RID: 40831 RVA: 0x002A1ABC File Offset: 0x0029FCBC
			// (set) Token: 0x06009F80 RID: 40832 RVA: 0x0005635C File Offset: 0x0005455C
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementRunTimeData._WriteRoguelikeAchievementFile_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006764 RID: 26468
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006765 RID: 26469
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006766 RID: 26470
			private static readonly IntPtr NativeFieldInfoPtr_fileSystemHandle;

			// Token: 0x04006767 RID: 26471
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006768 RID: 26472
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006769 RID: 26473
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000753 RID: 1875
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeAchievementRunTimeData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06009F81 RID: 40833 RVA: 0x002A1AEC File Offset: 0x0029FCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr);
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__23_1");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_0");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_3");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_4");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_5");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_6");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_9");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_10");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_7");
				RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, "<>9__34_8");
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669611);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_1_Internal_RogueLikeAchievement_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669612);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_0_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669613);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_3_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669614);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_4_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669615);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_5_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669616);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_6_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669617);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_7_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669618);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_9_Internal_CardType_KeyValuePair_2_CardType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669619);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_10_Internal_Int32_KeyValuePair_2_CardType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669620);
				RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_8_Internal_Boolean_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr, 100669621);
			}

			// Token: 0x06009F82 RID: 40834 RVA: 0x002A1CD0 File Offset: 0x0029FED0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeAchievementRunTimeData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F83 RID: 40835 RVA: 0x002A1D0C File Offset: 0x0029FF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83962, XrefRangeEnd = 83963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievement _get_GetAchievementWaitForClaim_b__23_1(KeyValuePair<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_1_Internal_RogueLikeAchievement_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_RogueLikeDataProfile.RogueLikeAchievement(pointer);
			}

			// Token: 0x06009F84 RID: 40836 RVA: 0x002A1D5C File Offset: 0x0029FF5C
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_0(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_0_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F85 RID: 40837 RVA: 0x002A1DB0 File Offset: 0x0029FFB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83963, XrefRangeEnd = 83965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_3(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_3_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F86 RID: 40838 RVA: 0x002A1E04 File Offset: 0x002A0004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83965, XrefRangeEnd = 83967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_4(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_4_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F87 RID: 40839 RVA: 0x002A1E58 File Offset: 0x002A0058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83967, XrefRangeEnd = 83970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_5(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_5_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F88 RID: 40840 RVA: 0x002A1EAC File Offset: 0x002A00AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83970, XrefRangeEnd = 83972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_6(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_6_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F89 RID: 40841 RVA: 0x002A1F00 File Offset: 0x002A0100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83972, XrefRangeEnd = 84010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_7(DLC5_RogueLikeDataProfile.RogueLikeAchievement achievementValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievementValue));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_7_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F8A RID: 40842 RVA: 0x002A1F54 File Offset: 0x002A0154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84010, XrefRangeEnd = 84011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeCardBase.CardType _NotifyAchievement_b__34_9(KeyValuePair<RogueLikeCardBase.CardType, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_9_Internal_CardType_KeyValuePair_2_CardType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F8B RID: 40843 RVA: 0x002A1FA8 File Offset: 0x002A01A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84011, XrefRangeEnd = 84012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _NotifyAchievement_b__34_10(KeyValuePair<RogueLikeCardBase.CardType, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_10_Internal_Int32_KeyValuePair_2_CardType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F8C RID: 40844 RVA: 0x002A1FFC File Offset: 0x002A01FC
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifyAchievement_b__34_8(DLC5_RogueLikeDataProfile.RogueLikeAchievement _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementRunTimeData.__c.NativeMethodInfoPtr__NotifyAchievement_b__34_8_Internal_Boolean_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F8D RID: 40845 RVA: 0x0005638A File Offset: 0x0005458A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170034AC RID: 13484
			// (get) Token: 0x06009F8E RID: 40846 RVA: 0x002A2050 File Offset: 0x002A0250
			// (set) Token: 0x06009F8F RID: 40847 RVA: 0x00056393 File Offset: 0x00054593
			public unsafe static RogueLikeAchievementRunTimeData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AD RID: 13485
			// (get) Token: 0x06009F90 RID: 40848 RVA: 0x002A2078 File Offset: 0x002A0278
			// (set) Token: 0x06009F91 RID: 40849 RVA: 0x000563A5 File Offset: 0x000545A5
			public unsafe static Func<KeyValuePair<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, DLC5_RogueLikeDataProfile.RogueLikeAchievement> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AE RID: 13486
			// (get) Token: 0x06009F92 RID: 40850 RVA: 0x002A20A0 File Offset: 0x002A02A0
			// (set) Token: 0x06009F93 RID: 40851 RVA: 0x000563B7 File Offset: 0x000545B7
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AF RID: 13487
			// (get) Token: 0x06009F94 RID: 40852 RVA: 0x002A20C8 File Offset: 0x002A02C8
			// (set) Token: 0x06009F95 RID: 40853 RVA: 0x000563C9 File Offset: 0x000545C9
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B0 RID: 13488
			// (get) Token: 0x06009F96 RID: 40854 RVA: 0x002A20F0 File Offset: 0x002A02F0
			// (set) Token: 0x06009F97 RID: 40855 RVA: 0x000563DB File Offset: 0x000545DB
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B1 RID: 13489
			// (get) Token: 0x06009F98 RID: 40856 RVA: 0x002A2118 File Offset: 0x002A0318
			// (set) Token: 0x06009F99 RID: 40857 RVA: 0x000563ED File Offset: 0x000545ED
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B2 RID: 13490
			// (get) Token: 0x06009F9A RID: 40858 RVA: 0x002A2140 File Offset: 0x002A0340
			// (set) Token: 0x06009F9B RID: 40859 RVA: 0x000563FF File Offset: 0x000545FF
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B3 RID: 13491
			// (get) Token: 0x06009F9C RID: 40860 RVA: 0x002A2168 File Offset: 0x002A0368
			// (set) Token: 0x06009F9D RID: 40861 RVA: 0x00056411 File Offset: 0x00054611
			public unsafe static Func<KeyValuePair<RogueLikeCardBase.CardType, int>, RogueLikeCardBase.CardType> __9__34_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeCardBase.CardType, int>, RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B4 RID: 13492
			// (get) Token: 0x06009F9E RID: 40862 RVA: 0x002A2190 File Offset: 0x002A0390
			// (set) Token: 0x06009F9F RID: 40863 RVA: 0x00056423 File Offset: 0x00054623
			public unsafe static Func<KeyValuePair<RogueLikeCardBase.CardType, int>, int> __9__34_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeCardBase.CardType, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B5 RID: 13493
			// (get) Token: 0x06009FA0 RID: 40864 RVA: 0x002A21B8 File Offset: 0x002A03B8
			// (set) Token: 0x06009FA1 RID: 40865 RVA: 0x00056435 File Offset: 0x00054635
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B6 RID: 13494
			// (get) Token: 0x06009FA2 RID: 40866 RVA: 0x002A21E0 File Offset: 0x002A03E0
			// (set) Token: 0x06009FA3 RID: 40867 RVA: 0x00056447 File Offset: 0x00054647
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool> __9__34_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeAchievementRunTimeData.__c.NativeFieldInfoPtr___9__34_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400676A RID: 26474
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400676B RID: 26475
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x0400676C RID: 26476
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x0400676D RID: 26477
			private static readonly IntPtr NativeFieldInfoPtr___9__34_3;

			// Token: 0x0400676E RID: 26478
			private static readonly IntPtr NativeFieldInfoPtr___9__34_4;

			// Token: 0x0400676F RID: 26479
			private static readonly IntPtr NativeFieldInfoPtr___9__34_5;

			// Token: 0x04006770 RID: 26480
			private static readonly IntPtr NativeFieldInfoPtr___9__34_6;

			// Token: 0x04006771 RID: 26481
			private static readonly IntPtr NativeFieldInfoPtr___9__34_9;

			// Token: 0x04006772 RID: 26482
			private static readonly IntPtr NativeFieldInfoPtr___9__34_10;

			// Token: 0x04006773 RID: 26483
			private static readonly IntPtr NativeFieldInfoPtr___9__34_7;

			// Token: 0x04006774 RID: 26484
			private static readonly IntPtr NativeFieldInfoPtr___9__34_8;

			// Token: 0x04006775 RID: 26485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006776 RID: 26486
			private static readonly IntPtr NativeMethodInfoPtr__get_GetAchievementWaitForClaim_b__23_1_Internal_RogueLikeAchievement_KeyValuePair_2_RogueLikeAchievementType_RogueLikeAchievement_0;

			// Token: 0x04006777 RID: 26487
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_0_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x04006778 RID: 26488
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_3_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x04006779 RID: 26489
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_4_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x0400677A RID: 26490
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_5_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x0400677B RID: 26491
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_6_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x0400677C RID: 26492
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_7_Internal_Boolean_RogueLikeAchievement_0;

			// Token: 0x0400677D RID: 26493
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_9_Internal_CardType_KeyValuePair_2_CardType_Int32_0;

			// Token: 0x0400677E RID: 26494
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_10_Internal_Int32_KeyValuePair_2_CardType_Int32_0;

			// Token: 0x0400677F RID: 26495
			private static readonly IntPtr NativeMethodInfoPtr__NotifyAchievement_b__34_8_Internal_Boolean_RogueLikeAchievement_0;
		}
	}
}
