using System;
using GameData.Core.Collections;
using GameData.Profile;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using TMPro;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x0200013C RID: 316
	public class DLC5_RogueLikeEliteChallenge_Yuuma : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x060025F0 RID: 9712 RVA: 0x0011DBF0 File Offset: 0x0011BDF0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Yuuma()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Yuuma");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_exceptTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "exceptTagId");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "YUUMA_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "YUUMA_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "YUUMA_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_POSTCHECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "YUUMA_CHALLENGE_POSTCHECK");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "YUUMA_ID");
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670107);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670108);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670109);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670110);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670111);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670112);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670113);
			DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_2_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, 100670114);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0011DD38 File Offset: 0x0011BF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89650, XrefRangeEnd = 89653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0011DD8C File Offset: 0x0011BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89653, XrefRangeEnd = 89662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0011DDF4 File Offset: 0x0011BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89662, XrefRangeEnd = 89723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeCache>(intPtr3) : null;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0011DE64 File Offset: 0x0011C064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89723, XrefRangeEnd = 89755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x0011DEF0 File Offset: 0x0011C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89755, XrefRangeEnd = 89762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0011DF60 File Offset: 0x0011C160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89762, XrefRangeEnd = 89825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckNeedNoticeBeforeWork(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, IzakayaConfigure izakayaConfigure, out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayaConfigure);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89825, XrefRangeEnd = 89833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Yuuma() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0011E024 File Offset: 0x0011C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89833, XrefRangeEnd = 89841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateEliteChallengeCache_b__8_2(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_2_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000166C7 File Offset: 0x000148C7
		public DLC5_RogueLikeEliteChallenge_Yuuma(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0011E070 File Offset: 0x0011C270
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x000166D0 File Offset: 0x000148D0
		public unsafe Il2CppStructArray<int> exceptTagId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_exceptTagId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_exceptTagId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0011E0A0 File Offset: 0x0011C2A0
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000166EF File Offset: 0x000148EF
		public unsafe static string YUUMA_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0011E0C0 File Offset: 0x0011C2C0
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x00016701 File Offset: 0x00014901
		public unsafe static string YUUMA_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0011E0E0 File Offset: 0x0011C2E0
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x00016713 File Offset: 0x00014913
		public unsafe static string YUUMA_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0011E100 File Offset: 0x0011C300
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x00016725 File Offset: 0x00014925
		public unsafe static string YUUMA_CHALLENGE_POSTCHECK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_POSTCHECK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_CHALLENGE_POSTCHECK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x0011E120 File Offset: 0x0011C320
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00016737 File Offset: 0x00014937
		public unsafe static int YUUMA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.NativeFieldInfoPtr_YUUMA_ID, (void*)(&value));
			}
		}

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_exceptTagId;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE_DESCRIPTION;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE_POSTCHECK;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_ID;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_2_Private_Boolean_Int32_0;

		// Token: 0x0200077B RID: 1915
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuuma+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A256 RID: 41558 RVA: 0x002AA6E4 File Offset: 0x002A88E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, "<>9__8_0");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, "<>9__8_1");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, "<>9__11_0");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, 100670116);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_0_Internal_IEnumerable_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, 100670117);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_1_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, 100670118);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__11_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr, 100670119);
			}

			// Token: 0x0600A257 RID: 41559 RVA: 0x002AA7B0 File Offset: 0x002A89B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A258 RID: 41560 RVA: 0x002AA7EC File Offset: 0x002A89EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89616, XrefRangeEnd = 89618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GenerateEliteChallengeCache_b__8_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_0_Internal_IEnumerable_1_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600A259 RID: 41561 RVA: 0x002AA83C File Offset: 0x002A8A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89618, XrefRangeEnd = 89620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GenerateEliteChallengeCache_b__8_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_1_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600A25A RID: 41562 RVA: 0x002AA888 File Offset: 0x002A8A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CheckNeedNoticeBeforeWork_b__11_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__11_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A25B RID: 41563 RVA: 0x00057B5D File Offset: 0x00055D5D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003595 RID: 13717
			// (get) Token: 0x0600A25C RID: 41564 RVA: 0x002AA8CC File Offset: 0x002A8ACC
			// (set) Token: 0x0600A25D RID: 41565 RVA: 0x00057B66 File Offset: 0x00055D66
			public unsafe static DLC5_RogueLikeEliteChallenge_Yuuma.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yuuma.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003596 RID: 13718
			// (get) Token: 0x0600A25E RID: 41566 RVA: 0x002AA8F4 File Offset: 0x002A8AF4
			// (set) Token: 0x0600A25F RID: 41567 RVA: 0x00057B78 File Offset: 0x00055D78
			public unsafe static Func<Recipe, IEnumerable<int>> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003597 RID: 13719
			// (get) Token: 0x0600A260 RID: 41568 RVA: 0x002AA91C File Offset: 0x002A8B1C
			// (set) Token: 0x0600A261 RID: 41569 RVA: 0x00057B8A File Offset: 0x00055D8A
			public unsafe static Func<int, IEnumerable<int>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003598 RID: 13720
			// (get) Token: 0x0600A262 RID: 41570 RVA: 0x002AA944 File Offset: 0x002A8B44
			// (set) Token: 0x0600A263 RID: 41571 RVA: 0x00057B9C File Offset: 0x00055D9C
			public unsafe static Func<int, string> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuuma.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006922 RID: 26914
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006923 RID: 26915
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04006924 RID: 26916
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04006925 RID: 26917
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04006926 RID: 26918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006927 RID: 26919
			private static readonly IntPtr NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_0_Internal_IEnumerable_1_Int32_Recipe_0;

			// Token: 0x04006928 RID: 26920
			private static readonly IntPtr NativeMethodInfoPtr__GenerateEliteChallengeCache_b__8_1_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04006929 RID: 26921
			private static readonly IntPtr NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__11_0_Internal_String_Int32_0;
		}

		// Token: 0x0200077C RID: 1916
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuuma+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600A264 RID: 41572 RVA: 0x002AA96C File Offset: 0x002A8B6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagMappingBaseEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, "tagMappingBaseEval");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, "tagId");
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, 100670120);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, 100670121);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, 100670122);
				DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr, 100670123);
			}

			// Token: 0x0600A265 RID: 41573 RVA: 0x002AAA24 File Offset: 0x002A8C24
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A266 RID: 41574 RVA: 0x002AAA60 File Offset: 0x002A8C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89620, XrefRangeEnd = 89621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A267 RID: 41575 RVA: 0x002AAA94 File Offset: 0x002A8C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89621, XrefRangeEnd = 89630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_String_PDM_0(string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_String_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A268 RID: 41576 RVA: 0x002AAADC File Offset: 0x002A8CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89630, XrefRangeEnd = 89632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A269 RID: 41577 RVA: 0x00057BAE File Offset: 0x00055DAE
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003599 RID: 13721
			// (get) Token: 0x0600A26A RID: 41578 RVA: 0x002AAB20 File Offset: 0x002A8D20
			// (set) Token: 0x0600A26B RID: 41579 RVA: 0x00057BB7 File Offset: 0x00055DB7
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700359A RID: 13722
			// (get) Token: 0x0600A26C RID: 41580 RVA: 0x002AAB50 File Offset: 0x002A8D50
			// (set) Token: 0x0600A26D RID: 41581 RVA: 0x00057BE5 File Offset: 0x00055DE5
			public EventManager.EvalModifier tagMappingBaseEval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagMappingBaseEval);
					return new EventManager.EvalModifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagMappingBaseEval), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700359B RID: 13723
			// (get) Token: 0x0600A26E RID: 41582 RVA: 0x002AAB80 File Offset: 0x002A8D80
			// (set) Token: 0x0600A26F RID: 41583 RVA: 0x00057C13 File Offset: 0x00055E13
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma.__c__DisplayClass9_0.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x0400692A RID: 26922
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400692B RID: 26923
			private static readonly IntPtr NativeFieldInfoPtr_tagMappingBaseEval;

			// Token: 0x0400692C RID: 26924
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x0400692D RID: 26925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400692E RID: 26926
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_0;

			// Token: 0x0400692F RID: 26927
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_String_PDM_0;

			// Token: 0x04006930 RID: 26928
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200077D RID: 1917
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuuma+<EliteBossSpellCardDeclaration>d__10")]
		public sealed class _EliteBossSpellCardDeclaration_d__10 : Object
		{
			// Token: 0x0600A270 RID: 41584 RVA: 0x002AABA8 File Offset: 0x002A8DA8
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__10()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670124);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670125);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670126);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670127);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670128);
				DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670129);
			}

			// Token: 0x0600A271 RID: 41585 RVA: 0x002AACB0 File Offset: 0x002A8EB0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A272 RID: 41586 RVA: 0x002AACF8 File Offset: 0x002A8EF8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A273 RID: 41587 RVA: 0x002AAD2C File Offset: 0x002A8F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89632, XrefRangeEnd = 89644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170035A1 RID: 13729
			// (get) Token: 0x0600A274 RID: 41588 RVA: 0x002AAD68 File Offset: 0x002A8F68
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A275 RID: 41589 RVA: 0x002AADA8 File Offset: 0x002A8FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89644, XrefRangeEnd = 89650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035A2 RID: 13730
			// (get) Token: 0x0600A276 RID: 41590 RVA: 0x002AADDC File Offset: 0x002A8FDC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A277 RID: 41591 RVA: 0x00057C2E File Offset: 0x00055E2E
			public _EliteBossSpellCardDeclaration_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700359C RID: 13724
			// (get) Token: 0x0600A278 RID: 41592 RVA: 0x002AAE1C File Offset: 0x002A901C
			// (set) Token: 0x0600A279 RID: 41593 RVA: 0x00057C37 File Offset: 0x00055E37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700359D RID: 13725
			// (get) Token: 0x0600A27A RID: 41594 RVA: 0x002AAE44 File Offset: 0x002A9044
			// (set) Token: 0x0600A27B RID: 41595 RVA: 0x00057C52 File Offset: 0x00055E52
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700359E RID: 13726
			// (get) Token: 0x0600A27C RID: 41596 RVA: 0x002AAE74 File Offset: 0x002A9074
			// (set) Token: 0x0600A27D RID: 41597 RVA: 0x00057C71 File Offset: 0x00055E71
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700359F RID: 13727
			// (get) Token: 0x0600A27E RID: 41598 RVA: 0x002AAEA4 File Offset: 0x002A90A4
			// (set) Token: 0x0600A27F RID: 41599 RVA: 0x00057C90 File Offset: 0x00055E90
			public unsafe DLC5_RogueLikeEliteChallenge_Yuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035A0 RID: 13728
			// (get) Token: 0x0600A280 RID: 41600 RVA: 0x002AAED4 File Offset: 0x002A90D4
			// (set) Token: 0x0600A281 RID: 41601 RVA: 0x00057CAF File Offset: 0x00055EAF
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuuma._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006931 RID: 26929
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006932 RID: 26930
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006933 RID: 26931
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04006934 RID: 26932
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006935 RID: 26933
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x04006936 RID: 26934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006937 RID: 26935
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006938 RID: 26936
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006939 RID: 26937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400693A RID: 26938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400693B RID: 26939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
