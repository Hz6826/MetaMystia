using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000138 RID: 312
	public class DLC5_RogueLikeEliteChallenge_Koishi : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06002593 RID: 9619 RVA: 0x0011C974 File Offset: 0x0011AB74
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Koishi()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Koishi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "KOISHI_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "KOISHI_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "KOISHI_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "KOISHI_ID");
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670002);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670003);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670004);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670005);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670006);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670007);
			DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, 100670008);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0011CA80 File Offset: 0x0011AC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88772, XrefRangeEnd = 88775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0011CAD4 File Offset: 0x0011ACD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88775, XrefRangeEnd = 88784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0011CB3C File Offset: 0x0011AD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88784, XrefRangeEnd = 88819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0011CBC8 File Offset: 0x0011ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88819, XrefRangeEnd = 88826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0011CC38 File Offset: 0x0011AE38
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Koishi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0011CC74 File Offset: 0x0011AE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88826, XrefRangeEnd = 88847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0011CCAC File Offset: 0x0011AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88847, XrefRangeEnd = 88849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int32_String_PDM_0(int tagId, string oldText)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tagId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0001646E File Offset: 0x0001466E
		public DLC5_RogueLikeEliteChallenge_Koishi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x0011CCF8 File Offset: 0x0011AEF8
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x00016477 File Offset: 0x00014677
		public unsafe static string KOISHI_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0011CD18 File Offset: 0x0011AF18
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x00016489 File Offset: 0x00014689
		public unsafe static string KOISHI_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0011CD38 File Offset: 0x0011AF38
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0001649B File Offset: 0x0001469B
		public unsafe static string KOISHI_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0011CD58 File Offset: 0x0011AF58
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x000164AD File Offset: 0x000146AD
		public unsafe static int KOISHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.NativeFieldInfoPtr_KOISHI_ID, (void*)(&value));
			}
		}

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_CHALLENGE;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_CHALLENGE_TITLE;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_CHALLENGE_DESCRIPTION;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_ID;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0;

		// Token: 0x0200076B RID: 1899
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Koishi+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600A16F RID: 41327 RVA: 0x002A7C44 File Offset: 0x002A5E44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr, 100670009);
				DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr, 100670010);
			}

			// Token: 0x0600A170 RID: 41328 RVA: 0x002A7CAC File Offset: 0x002A5EAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A171 RID: 41329 RVA: 0x002A7CE8 File Offset: 0x002A5EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88704, XrefRangeEnd = 88754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A172 RID: 41330 RVA: 0x0005736A File Offset: 0x0005556A
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700354D RID: 13645
			// (get) Token: 0x0600A173 RID: 41331 RVA: 0x002A7D1C File Offset: 0x002A5F1C
			// (set) Token: 0x0600A174 RID: 41332 RVA: 0x00057373 File Offset: 0x00055573
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi.__c__DisplayClass6_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400689B RID: 26779
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400689C RID: 26780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400689D RID: 26781
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_0;
		}

		// Token: 0x0200076C RID: 1900
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Koishi+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A175 RID: 41333 RVA: 0x002A7D4C File Offset: 0x002A5F4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr, "<>9__6_2");
				DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr, 100670012);
				DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeMethodInfoPtr__EliteBossChallenge_b__6_2_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr, 100670013);
			}

			// Token: 0x0600A176 RID: 41334 RVA: 0x002A7DC8 File Offset: 0x002A5FC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A177 RID: 41335 RVA: 0x002A7E04 File Offset: 0x002A6004
			[CallerCount(0)]
			public unsafe string _EliteBossChallenge_b__6_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeMethodInfoPtr__EliteBossChallenge_b__6_2_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A178 RID: 41336 RVA: 0x000573A1 File Offset: 0x000555A1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700354E RID: 13646
			// (get) Token: 0x0600A179 RID: 41337 RVA: 0x002A7E4C File Offset: 0x002A604C
			// (set) Token: 0x0600A17A RID: 41338 RVA: 0x000573AA File Offset: 0x000555AA
			public unsafe static DLC5_RogueLikeEliteChallenge_Koishi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Koishi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700354F RID: 13647
			// (get) Token: 0x0600A17B RID: 41339 RVA: 0x002A7E74 File Offset: 0x002A6074
			// (set) Token: 0x0600A17C RID: 41340 RVA: 0x000573BC File Offset: 0x000555BC
			public unsafe static Func<string, string> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Koishi.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400689E RID: 26782
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400689F RID: 26783
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x040068A0 RID: 26784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068A1 RID: 26785
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__6_2_Internal_String_String_0;
		}

		// Token: 0x0200076D RID: 1901
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Koishi+<EliteBossSpellCardDeclaration>d__7")]
		public sealed class _EliteBossSpellCardDeclaration_d__7 : Object
		{
			// Token: 0x0600A17D RID: 41341 RVA: 0x002A7E9C File Offset: 0x002A609C
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__7()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670014);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670015);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670016);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670017);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670018);
				DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr, 100670019);
			}

			// Token: 0x0600A17E RID: 41342 RVA: 0x002A7FA4 File Offset: 0x002A61A4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A17F RID: 41343 RVA: 0x002A7FEC File Offset: 0x002A61EC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A180 RID: 41344 RVA: 0x002A8020 File Offset: 0x002A6220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88754, XrefRangeEnd = 88766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003555 RID: 13653
			// (get) Token: 0x0600A181 RID: 41345 RVA: 0x002A805C File Offset: 0x002A625C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A182 RID: 41346 RVA: 0x002A809C File Offset: 0x002A629C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88766, XrefRangeEnd = 88772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003556 RID: 13654
			// (get) Token: 0x0600A183 RID: 41347 RVA: 0x002A80D0 File Offset: 0x002A62D0
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A184 RID: 41348 RVA: 0x000573CE File Offset: 0x000555CE
			public _EliteBossSpellCardDeclaration_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003550 RID: 13648
			// (get) Token: 0x0600A185 RID: 41349 RVA: 0x002A8110 File Offset: 0x002A6310
			// (set) Token: 0x0600A186 RID: 41350 RVA: 0x000573D7 File Offset: 0x000555D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003551 RID: 13649
			// (get) Token: 0x0600A187 RID: 41351 RVA: 0x002A8138 File Offset: 0x002A6338
			// (set) Token: 0x0600A188 RID: 41352 RVA: 0x000573F2 File Offset: 0x000555F2
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003552 RID: 13650
			// (get) Token: 0x0600A189 RID: 41353 RVA: 0x002A8168 File Offset: 0x002A6368
			// (set) Token: 0x0600A18A RID: 41354 RVA: 0x00057411 File Offset: 0x00055611
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003553 RID: 13651
			// (get) Token: 0x0600A18B RID: 41355 RVA: 0x002A8198 File Offset: 0x002A6398
			// (set) Token: 0x0600A18C RID: 41356 RVA: 0x00057430 File Offset: 0x00055630
			public unsafe DLC5_RogueLikeEliteChallenge_Koishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Koishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003554 RID: 13652
			// (get) Token: 0x0600A18D RID: 41357 RVA: 0x002A81C8 File Offset: 0x002A63C8
			// (set) Token: 0x0600A18E RID: 41358 RVA: 0x0005744F File Offset: 0x0005564F
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Koishi._EliteBossSpellCardDeclaration_d__7.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068A2 RID: 26786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040068A3 RID: 26787
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040068A4 RID: 26788
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040068A5 RID: 26789
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068A6 RID: 26790
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x040068A7 RID: 26791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040068A8 RID: 26792
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068A9 RID: 26793
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040068AA RID: 26794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040068AB RID: 26795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068AC RID: 26796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
