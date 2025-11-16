using System;
using Common.Audio;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A6 RID: 166
	public class DLC4_GuardYuka : DLC4_GuardController
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x000D9504 File Offset: 0x000D7704
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardYuka()
		{
			Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardYuka");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr);
			DLC4_GuardYuka.NativeFieldInfoPtr_m_EachSunflowerDecreaseCookTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_EachSunflowerDecreaseCookTimeMultiplier");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGuardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_FlowerGuardId");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_Spark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_Spark");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SparkStunDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkWaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SparkWaitDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkRecoverDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SparkRecoverDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnPInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_FlowerSpawnPInterval");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_FlowerSpawnP");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_FlowerSpawnDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGenerateDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_FlowerGenerateDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointStayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_PPointStayDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointFlyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_PPointFlyDuration");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SunVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SunVFX");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SparkSfx");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_EndSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_EndSfx");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStartSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SparkStartSfx");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerGiantBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SunFlowerGiantBullet");
			DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerSmallBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "m_SunFlowerSmallBullet");
			DLC4_GuardYuka.NativeFieldInfoPtr_allFlowerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "allFlowerPosition");
			DLC4_GuardYuka.NativeFieldInfoPtr_hasSpawnedPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "hasSpawnedPlace");
			DLC4_GuardYuka.NativeFieldInfoPtr_interruptSunflowerBuffCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "interruptSunflowerBuffCallback");
			DLC4_GuardYuka.NativeFieldInfoPtr_sunflowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "sunflowers");
			DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnPInterval_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666362);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666363);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666364);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerGenerateDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666365);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_PPointStayDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666366);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_PPointFlyDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666367);
			DLC4_GuardYuka.NativeMethodInfoPtr_get_SunVFX_Public_get_VFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666368);
			DLC4_GuardYuka.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666369);
			DLC4_GuardYuka.NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666370);
			DLC4_GuardYuka.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666371);
			DLC4_GuardYuka.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666372);
			DLC4_GuardYuka.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666373);
			DLC4_GuardYuka.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666374);
			DLC4_GuardYuka.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666375);
			DLC4_GuardYuka.NativeMethodInfoPtr__Eat_b__37_0_Private_Boolean_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666376);
			DLC4_GuardYuka.NativeMethodInfoPtr__Eat_b__37_1_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666377);
			DLC4_GuardYuka.NativeMethodInfoPtr__SkillAttack_b__39_0_Private_Void_DLC4_BulletYukaSpark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, 100666378);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000D9840 File Offset: 0x000D7A40
		public unsafe float FlowerSpawnPInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnPInterval_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x000D987C File Offset: 0x000D7A7C
		public unsafe int FlowerSpawnP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		public unsafe float FlowerSpawnDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerSpawnDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x000D98F4 File Offset: 0x000D7AF4
		public unsafe float FlowerGenerateDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_FlowerGenerateDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000D9930 File Offset: 0x000D7B30
		public unsafe float PPointStayDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_PPointStayDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x000D996C File Offset: 0x000D7B6C
		public unsafe float PPointFlyDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_PPointFlyDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000D99A8 File Offset: 0x000D7BA8
		public unsafe VFXPrefab SunVFX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_get_SunVFX_Public_get_VFXPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new VFXPrefab(pointer);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000D99E0 File Offset: 0x000D7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50383, XrefRangeEnd = 50429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuardControllerEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYuka.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000D9A1C File Offset: 0x000D7C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50429, XrefRangeEnd = 50485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController.EvaluationResult Eat(GuestGroupController.EvaluationResult result, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000D9AB0 File Offset: 0x000D7CB0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYuka.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000D9AEC File Offset: 0x000D7CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50485, XrefRangeEnd = 50490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYuka.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000D9B38 File Offset: 0x000D7D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50490, XrefRangeEnd = 50512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYuka.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000D9B74 File Offset: 0x000D7D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50512, XrefRangeEnd = 50519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYuka.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000D9BB0 File Offset: 0x000D7DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50519, XrefRangeEnd = 50520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardYuka() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000D9BEC File Offset: 0x000D7DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50520, XrefRangeEnd = 50524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Eat_b__37_0(KeyValuePair<int, Vector2> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr__Eat_b__37_0_Private_Boolean_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000D9C40 File Offset: 0x000D7E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50524, XrefRangeEnd = 50530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _Eat_b__37_1(int _, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr__Eat_b__37_1_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000D9C98 File Offset: 0x000D7E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50530, XrefRangeEnd = 50531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SkillAttack_b__39_0(DLC4_BulletYukaSpark x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.NativeMethodInfoPtr__SkillAttack_b__39_0_Private_Void_DLC4_BulletYukaSpark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0000B285 File Offset: 0x00009485
		public DLC4_GuardYuka(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000D9CDC File Offset: 0x000D7EDC
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0000B28E File Offset: 0x0000948E
		public unsafe float m_EachSunflowerDecreaseCookTimeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_EachSunflowerDecreaseCookTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_EachSunflowerDecreaseCookTimeMultiplier)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000D9D04 File Offset: 0x000D7F04
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000B2A9 File Offset: 0x000094A9
		public unsafe int m_FlowerGuardId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGuardId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGuardId)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000D9D2C File Offset: 0x000D7F2C
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000B2C4 File Offset: 0x000094C4
		public DLC4_GuardController.TeamBulletProperty m_Spark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_Spark);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_Spark), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000D9D5C File Offset: 0x000D7F5C
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0000B2F2 File Offset: 0x000094F2
		public unsafe float m_SparkStunDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStunDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStunDuration)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x000D9D84 File Offset: 0x000D7F84
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0000B30D File Offset: 0x0000950D
		public unsafe float m_SparkWaitDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkWaitDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkWaitDuration)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000D9DAC File Offset: 0x000D7FAC
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0000B328 File Offset: 0x00009528
		public unsafe float m_SparkRecoverDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkRecoverDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkRecoverDuration)) = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x000D9DD4 File Offset: 0x000D7FD4
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0000B343 File Offset: 0x00009543
		public unsafe float m_FlowerSpawnPInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnPInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnPInterval)) = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000D9DFC File Offset: 0x000D7FFC
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0000B35E File Offset: 0x0000955E
		public unsafe int m_FlowerSpawnP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnP)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000D9E24 File Offset: 0x000D8024
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0000B379 File Offset: 0x00009579
		public unsafe float m_FlowerSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerSpawnDuration)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000D9E4C File Offset: 0x000D804C
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0000B394 File Offset: 0x00009594
		public unsafe float m_FlowerGenerateDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGenerateDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_FlowerGenerateDuration)) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000D9E74 File Offset: 0x000D8074
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000B3AF File Offset: 0x000095AF
		public unsafe float m_PPointStayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointStayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointStayDuration)) = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000D9E9C File Offset: 0x000D809C
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000B3CA File Offset: 0x000095CA
		public unsafe float m_PPointFlyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointFlyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_PPointFlyDuration)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000D9EC4 File Offset: 0x000D80C4
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0000B3E5 File Offset: 0x000095E5
		public VFXPrefab m_SunVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000D9EF4 File Offset: 0x000D80F4
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000B413 File Offset: 0x00009613
		public unsafe LoopedBGMPackage m_SparkSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x000D9F24 File Offset: 0x000D8124
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000B432 File Offset: 0x00009632
		public unsafe AudioClip m_EndSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_EndSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_EndSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000D9F54 File Offset: 0x000D8154
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x0000B451 File Offset: 0x00009651
		public GlobalAudioManager.DelayAudioClip m_SparkStartSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStartSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SparkStartSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000D9F84 File Offset: 0x000D8184
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0000B47F File Offset: 0x0000967F
		public DLC4_GuardController.TeamBulletProperty m_SunFlowerGiantBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerGiantBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerGiantBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000D9FB4 File Offset: 0x000D81B4
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0000B4AD File Offset: 0x000096AD
		public DLC4_GuardController.TeamBulletProperty m_SunFlowerSmallBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerSmallBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_m_SunFlowerSmallBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000D9FE4 File Offset: 0x000D81E4
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000B4DB File Offset: 0x000096DB
		public unsafe Dictionary<int, Vector2> allFlowerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_allFlowerPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_allFlowerPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000DA014 File Offset: 0x000D8214
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0000B4FA File Offset: 0x000096FA
		public unsafe List<int> hasSpawnedPlace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_hasSpawnedPlace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_hasSpawnedPlace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000DA044 File Offset: 0x000D8244
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0000B519 File Offset: 0x00009719
		public unsafe Action interruptSunflowerBuffCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_interruptSunflowerBuffCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_interruptSunflowerBuffCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000DA074 File Offset: 0x000D8274
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0000B538 File Offset: 0x00009738
		public unsafe List<DLC4_GuardYukaSunFlower> sunflowers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_sunflowers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_GuardYukaSunFlower>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka.NativeFieldInfoPtr_sunflowers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_m_EachSunflowerDecreaseCookTimeMultiplier;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr_m_FlowerGuardId;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_m_Spark;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_m_SparkStunDuration;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_m_SparkWaitDuration;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr_m_SparkRecoverDuration;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_m_FlowerSpawnPInterval;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_m_FlowerSpawnP;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_m_FlowerSpawnDuration;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_m_FlowerGenerateDuration;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_m_PPointStayDuration;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr_m_PPointFlyDuration;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr_m_SunVFX;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr_m_SparkSfx;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_m_EndSfx;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_m_SparkStartSfx;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_m_SunFlowerGiantBullet;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr_m_SunFlowerSmallBullet;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_allFlowerPosition;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr_hasSpawnedPlace;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr_interruptSunflowerBuffCallback;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeFieldInfoPtr_sunflowers;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_get_FlowerSpawnPInterval_Public_get_Single_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_get_FlowerSpawnP_Public_get_Int32_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_get_FlowerSpawnDuration_Public_get_Single_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_get_FlowerGenerateDuration_Public_get_Single_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_get_PPointStayDuration_Public_get_Single_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_get_PPointFlyDuration_Public_get_Single_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_get_SunVFX_Public_get_VFXPrefab_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr__Eat_b__37_0_Private_Boolean_KeyValuePair_2_Int32_Vector2_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr__Eat_b__37_1_Private_String_Int32_String_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__39_0_Private_Void_DLC4_BulletYukaSpark_0;

		// Token: 0x020005AB RID: 1451
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYuka+<SkillAttack>d__39")]
		public sealed class _SkillAttack_d__39 : Il2CppSystem.Object
		{
			// Token: 0x06008BB1 RID: 35761 RVA: 0x00267628 File Offset: 0x00265828
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__39()
			{
				Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "<SkillAttack>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr);
				DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, "<>1__state");
				DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, "<>2__current");
				DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, "<>4__this");
				DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__spark_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, "<spark>5__2");
				DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__yukaLaser_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, "<yukaLaser>5__3");
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666379);
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666380);
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666381);
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666382);
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666383);
				DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr, 100666384);
			}

			// Token: 0x06008BB2 RID: 35762 RVA: 0x00267730 File Offset: 0x00265930
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYuka._SkillAttack_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BB3 RID: 35763 RVA: 0x00267778 File Offset: 0x00265978
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BB4 RID: 35764 RVA: 0x002677AC File Offset: 0x002659AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50345, XrefRangeEnd = 50365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002ECA RID: 11978
			// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x002677E8 File Offset: 0x002659E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BB6 RID: 35766 RVA: 0x00267828 File Offset: 0x00265A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50365, XrefRangeEnd = 50371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002ECB RID: 11979
			// (get) Token: 0x06008BB7 RID: 35767 RVA: 0x0026785C File Offset: 0x00265A5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka._SkillAttack_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BB8 RID: 35768 RVA: 0x0004B107 File Offset: 0x00049307
			public _SkillAttack_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EC5 RID: 11973
			// (get) Token: 0x06008BB9 RID: 35769 RVA: 0x0026789C File Offset: 0x00265A9C
			// (set) Token: 0x06008BBA RID: 35770 RVA: 0x0004B110 File Offset: 0x00049310
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EC6 RID: 11974
			// (get) Token: 0x06008BBB RID: 35771 RVA: 0x002678C4 File Offset: 0x00265AC4
			// (set) Token: 0x06008BBC RID: 35772 RVA: 0x0004B12B File Offset: 0x0004932B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EC7 RID: 11975
			// (get) Token: 0x06008BBD RID: 35773 RVA: 0x002678F4 File Offset: 0x00265AF4
			// (set) Token: 0x06008BBE RID: 35774 RVA: 0x0004B14A File Offset: 0x0004934A
			public unsafe DLC4_GuardYuka __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYuka>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EC8 RID: 11976
			// (get) Token: 0x06008BBF RID: 35775 RVA: 0x00267924 File Offset: 0x00265B24
			// (set) Token: 0x06008BC0 RID: 35776 RVA: 0x0004B169 File Offset: 0x00049369
			public unsafe DLC4_BulletYukaSpark _spark_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__spark_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletYukaSpark>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__spark_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EC9 RID: 11977
			// (get) Token: 0x06008BC1 RID: 35777 RVA: 0x00267954 File Offset: 0x00265B54
			// (set) Token: 0x06008BC2 RID: 35778 RVA: 0x0004B188 File Offset: 0x00049388
			public unsafe GameObject _yukaLaser_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__yukaLaser_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYuka._SkillAttack_d__39.NativeFieldInfoPtr__yukaLaser_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B79 RID: 23417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B7A RID: 23418
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B7B RID: 23419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B7C RID: 23420
			private static readonly IntPtr NativeFieldInfoPtr__spark_5__2;

			// Token: 0x04005B7D RID: 23421
			private static readonly IntPtr NativeFieldInfoPtr__yukaLaser_5__3;

			// Token: 0x04005B7E RID: 23422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B7F RID: 23423
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B80 RID: 23424
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B81 RID: 23425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B82 RID: 23426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B83 RID: 23427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005AC RID: 1452
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYuka+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008BC3 RID: 35779 RVA: 0x00267984 File Offset: 0x00265B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYuka>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr);
				DLC4_GuardYuka.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr, "<>9");
				DLC4_GuardYuka.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr, "<>9__40_0");
				DLC4_GuardYuka.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr, 100666386);
				DLC4_GuardYuka.__c.NativeMethodInfoPtr__OnDispose_b__40_0_Internal_Void_DLC4_GuardYukaSunFlower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr, 100666387);
			}

			// Token: 0x06008BC4 RID: 35780 RVA: 0x00267A00 File Offset: 0x00265C00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYuka.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BC5 RID: 35781 RVA: 0x00267A3C File Offset: 0x00265C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50371, XrefRangeEnd = 50383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDispose_b__40_0(DLC4_GuardYukaSunFlower x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYuka.__c.NativeMethodInfoPtr__OnDispose_b__40_0_Internal_Void_DLC4_GuardYukaSunFlower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BC6 RID: 35782 RVA: 0x0004B1A7 File Offset: 0x000493A7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ECC RID: 11980
			// (get) Token: 0x06008BC7 RID: 35783 RVA: 0x00267A80 File Offset: 0x00265C80
			// (set) Token: 0x06008BC8 RID: 35784 RVA: 0x0004B1B0 File Offset: 0x000493B0
			public unsafe static DLC4_GuardYuka.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardYuka.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYuka.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardYuka.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ECD RID: 11981
			// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x00267AA8 File Offset: 0x00265CA8
			// (set) Token: 0x06008BCA RID: 35786 RVA: 0x0004B1C2 File Offset: 0x000493C2
			public unsafe static Action<DLC4_GuardYukaSunFlower> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardYuka.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC4_GuardYukaSunFlower>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardYuka.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B84 RID: 23428
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005B85 RID: 23429
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04005B86 RID: 23430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B87 RID: 23431
			private static readonly IntPtr NativeMethodInfoPtr__OnDispose_b__40_0_Internal_Void_DLC4_GuardYukaSunFlower_0;
		}
	}
}
