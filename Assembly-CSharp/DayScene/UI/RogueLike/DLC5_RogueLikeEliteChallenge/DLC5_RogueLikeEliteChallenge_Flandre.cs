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

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000137 RID: 311
	public class DLC5_RogueLikeEliteChallenge_Flandre : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06002580 RID: 9600 RVA: 0x0011C5A8 File Offset: 0x0011A7A8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Flandre()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Flandre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "extraGuestRate");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "extraGuestFund");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "FLANDRE_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "FLANDRE_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "FLANDRE_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "FLANDRE_ID");
			DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, 100669988);
			DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, 100669989);
			DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, 100669990);
			DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, 100669991);
			DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, 100669992);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0011C6B4 File Offset: 0x0011A8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88654, XrefRangeEnd = 88657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0011C708 File Offset: 0x0011A908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88657, XrefRangeEnd = 88675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x0011C770 File Offset: 0x0011A970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88675, XrefRangeEnd = 88696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0011C7FC File Offset: 0x0011A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88696, XrefRangeEnd = 88703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0011C86C File Offset: 0x0011AA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88703, XrefRangeEnd = 88704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Flandre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000163EB File Offset: 0x000145EB
		public DLC5_RogueLikeEliteChallenge_Flandre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x0011C8A8 File Offset: 0x0011AAA8
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x000163F4 File Offset: 0x000145F4
		public unsafe int extraGuestRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestRate)) = value;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0011C8D0 File Offset: 0x0011AAD0
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x0001640F File Offset: 0x0001460F
		public unsafe int extraGuestFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_extraGuestFund)) = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x0011C8F8 File Offset: 0x0011AAF8
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x0001642A File Offset: 0x0001462A
		public unsafe static string FLANDRE_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x0011C918 File Offset: 0x0011AB18
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x0001643C File Offset: 0x0001463C
		public unsafe static string FLANDRE_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x0011C938 File Offset: 0x0011AB38
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x0001644E File Offset: 0x0001464E
		public unsafe static string FLANDRE_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x0011C958 File Offset: 0x0011AB58
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00016460 File Offset: 0x00014660
		public unsafe static int FLANDRE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Flandre.NativeFieldInfoPtr_FLANDRE_ID, (void*)(&value));
			}
		}

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr_extraGuestRate;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr_extraGuestFund;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr_FLANDRE_CHALLENGE;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr_FLANDRE_CHALLENGE_TITLE;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_FLANDRE_CHALLENGE_DESCRIPTION;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeFieldInfoPtr_FLANDRE_ID;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000769 RID: 1897
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Flandre+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600A152 RID: 41298 RVA: 0x002A76FC File Offset: 0x002A58FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeFundCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, "removeFundCallback");
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeGuestSpawnRateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, "removeGuestSpawnRateCallback");
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, 100669993);
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, 100669994);
				DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr, 100669995);
			}

			// Token: 0x0600A153 RID: 41299 RVA: 0x002A77A0 File Offset: 0x002A59A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A154 RID: 41300 RVA: 0x002A77DC File Offset: 0x002A59DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88626, XrefRangeEnd = 88636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A155 RID: 41301 RVA: 0x002A7824 File Offset: 0x002A5A24
			[CallerCount(0)]
			public unsafe void _EliteBossChallenge_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A156 RID: 41302 RVA: 0x00057264 File Offset: 0x00055464
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003543 RID: 13635
			// (get) Token: 0x0600A157 RID: 41303 RVA: 0x002A7858 File Offset: 0x002A5A58
			// (set) Token: 0x0600A158 RID: 41304 RVA: 0x0005726D File Offset: 0x0005546D
			public unsafe DLC5_RogueLikeEliteChallenge_Flandre __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Flandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003544 RID: 13636
			// (get) Token: 0x0600A159 RID: 41305 RVA: 0x002A7888 File Offset: 0x002A5A88
			// (set) Token: 0x0600A15A RID: 41306 RVA: 0x0005728C File Offset: 0x0005548C
			public unsafe Action removeFundCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeFundCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeFundCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003545 RID: 13637
			// (get) Token: 0x0600A15B RID: 41307 RVA: 0x002A78B8 File Offset: 0x002A5AB8
			// (set) Token: 0x0600A15C RID: 41308 RVA: 0x000572AB File Offset: 0x000554AB
			public unsafe Action removeGuestSpawnRateCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeGuestSpawnRateCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre.__c__DisplayClass8_0.NativeFieldInfoPtr_removeGuestSpawnRateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400688A RID: 26762
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400688B RID: 26763
			private static readonly IntPtr NativeFieldInfoPtr_removeFundCallback;

			// Token: 0x0400688C RID: 26764
			private static readonly IntPtr NativeFieldInfoPtr_removeGuestSpawnRateCallback;

			// Token: 0x0400688D RID: 26765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400688E RID: 26766
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_String_String_0;

			// Token: 0x0400688F RID: 26767
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__1_Internal_Void_0;
		}

		// Token: 0x0200076A RID: 1898
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Flandre+<EliteBossSpellCardDeclaration>d__9")]
		public sealed class _EliteBossSpellCardDeclaration_d__9 : Object
		{
			// Token: 0x0600A15D RID: 41309 RVA: 0x002A78E8 File Offset: 0x002A5AE8
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__9()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100669996);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100669997);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100669998);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100669999);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670000);
				DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670001);
			}

			// Token: 0x0600A15E RID: 41310 RVA: 0x002A79F0 File Offset: 0x002A5BF0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A15F RID: 41311 RVA: 0x002A7A38 File Offset: 0x002A5C38
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A160 RID: 41312 RVA: 0x002A7A6C File Offset: 0x002A5C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88636, XrefRangeEnd = 88648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700354B RID: 13643
			// (get) Token: 0x0600A161 RID: 41313 RVA: 0x002A7AA8 File Offset: 0x002A5CA8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A162 RID: 41314 RVA: 0x002A7AE8 File Offset: 0x002A5CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88648, XrefRangeEnd = 88654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700354C RID: 13644
			// (get) Token: 0x0600A163 RID: 41315 RVA: 0x002A7B1C File Offset: 0x002A5D1C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A164 RID: 41316 RVA: 0x000572CA File Offset: 0x000554CA
			public _EliteBossSpellCardDeclaration_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003546 RID: 13638
			// (get) Token: 0x0600A165 RID: 41317 RVA: 0x002A7B5C File Offset: 0x002A5D5C
			// (set) Token: 0x0600A166 RID: 41318 RVA: 0x000572D3 File Offset: 0x000554D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003547 RID: 13639
			// (get) Token: 0x0600A167 RID: 41319 RVA: 0x002A7B84 File Offset: 0x002A5D84
			// (set) Token: 0x0600A168 RID: 41320 RVA: 0x000572EE File Offset: 0x000554EE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003548 RID: 13640
			// (get) Token: 0x0600A169 RID: 41321 RVA: 0x002A7BB4 File Offset: 0x002A5DB4
			// (set) Token: 0x0600A16A RID: 41322 RVA: 0x0005730D File Offset: 0x0005550D
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003549 RID: 13641
			// (get) Token: 0x0600A16B RID: 41323 RVA: 0x002A7BE4 File Offset: 0x002A5DE4
			// (set) Token: 0x0600A16C RID: 41324 RVA: 0x0005732C File Offset: 0x0005552C
			public unsafe DLC5_RogueLikeEliteChallenge_Flandre __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Flandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700354A RID: 13642
			// (get) Token: 0x0600A16D RID: 41325 RVA: 0x002A7C14 File Offset: 0x002A5E14
			// (set) Token: 0x0600A16E RID: 41326 RVA: 0x0005734B File Offset: 0x0005554B
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Flandre._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006890 RID: 26768
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006891 RID: 26769
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006892 RID: 26770
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04006893 RID: 26771
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006894 RID: 26772
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x04006895 RID: 26773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006896 RID: 26774
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006897 RID: 26775
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006898 RID: 26776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006899 RID: 26777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400689A RID: 26778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
