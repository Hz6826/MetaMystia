using System;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using TMPro;
using UnityEngine;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x02000139 RID: 313
	public class DLC5_RogueLikeEliteChallenge_Mamizou : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x0011CD74 File Offset: 0x0011AF74
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Mamizou()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Mamizou");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_qteInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "qteInterval");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_addDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "addDuration");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_kyoukouPotroyal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "kyoukouPotroyal");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "MAMIZOU_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "MAMIZOU_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "MAMIZOU_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_KYOUKO_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "KYOUKO_ID");
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, 100670020);
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, 100670021);
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, 100670022);
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, 100670023);
			DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, 100670024);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0011CE94 File Offset: 0x0011B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88931, XrefRangeEnd = 88934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0011CEE8 File Offset: 0x0011B0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88934, XrefRangeEnd = 88951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0011CF50 File Offset: 0x0011B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88951, XrefRangeEnd = 88981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0011CFDC File Offset: 0x0011B1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88981, XrefRangeEnd = 88988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0011D04C File Offset: 0x0011B24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88988, XrefRangeEnd = 88989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Mamizou() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000164BB File Offset: 0x000146BB
		public DLC5_RogueLikeEliteChallenge_Mamizou(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x0011D088 File Offset: 0x0011B288
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x000164C4 File Offset: 0x000146C4
		public unsafe int qteInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_qteInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_qteInterval)) = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x0011D0B0 File Offset: 0x0011B2B0
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x000164DF File Offset: 0x000146DF
		public unsafe int addDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_addDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_addDuration)) = value;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0011D0D8 File Offset: 0x0011B2D8
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x000164FA File Offset: 0x000146FA
		public unsafe Sprite kyoukouPotroyal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_kyoukouPotroyal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_kyoukouPotroyal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0011D108 File Offset: 0x0011B308
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00016519 File Offset: 0x00014719
		public unsafe static string MAMIZOU_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0011D128 File Offset: 0x0011B328
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x0001652B File Offset: 0x0001472B
		public unsafe static string MAMIZOU_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0011D148 File Offset: 0x0011B348
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x0001653D File Offset: 0x0001473D
		public unsafe static string MAMIZOU_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_MAMIZOU_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0011D168 File Offset: 0x0011B368
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x0001654F File Offset: 0x0001474F
		public unsafe static int KYOUKO_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_KYOUKO_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Mamizou.NativeFieldInfoPtr_KYOUKO_ID, (void*)(&value));
			}
		}

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr_qteInterval;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeFieldInfoPtr_addDuration;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeFieldInfoPtr_kyoukouPotroyal;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeFieldInfoPtr_MAMIZOU_CHALLENGE;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeFieldInfoPtr_MAMIZOU_CHALLENGE_TITLE;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeFieldInfoPtr_MAMIZOU_CHALLENGE_DESCRIPTION;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeFieldInfoPtr_KYOUKO_ID;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200076E RID: 1902
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Mamizou+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A18F RID: 41359 RVA: 0x002A81F8 File Offset: 0x002A63F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_qteCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "qteCorotine");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_uiElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "uiElement");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_roguelikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "roguelikeManager");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_remainingWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "remainingWait");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "<>9__4");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670025);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670026);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670027);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670028);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670029);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670030);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, 100670031);
			}

			// Token: 0x0600A190 RID: 41360 RVA: 0x002A8350 File Offset: 0x002A6550
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A191 RID: 41361 RVA: 0x002A838C File Offset: 0x002A658C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88867, XrefRangeEnd = 88876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A192 RID: 41362 RVA: 0x002A83D4 File Offset: 0x002A65D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88876, XrefRangeEnd = 88886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A193 RID: 41363 RVA: 0x002A8408 File Offset: 0x002A6608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88886, XrefRangeEnd = 88894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A194 RID: 41364 RVA: 0x002A844C File Offset: 0x002A664C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88899, RefRangeEnd = 88900, XrefRangeStart = 88894, XrefRangeEnd = 88899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A195 RID: 41365 RVA: 0x002A848C File Offset: 0x002A668C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88908, RefRangeEnd = 88909, XrefRangeStart = 88900, XrefRangeEnd = 88908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A196 RID: 41366 RVA: 0x002A84C0 File Offset: 0x002A66C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88909, XrefRangeEnd = 88917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A197 RID: 41367 RVA: 0x0005746E File Offset: 0x0005566E
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003557 RID: 13655
			// (get) Token: 0x0600A198 RID: 41368 RVA: 0x002A8504 File Offset: 0x002A6704
			// (set) Token: 0x0600A199 RID: 41369 RVA: 0x00057477 File Offset: 0x00055677
			public unsafe DLC5_RogueLikeEliteChallenge_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003558 RID: 13656
			// (get) Token: 0x0600A19A RID: 41370 RVA: 0x002A8534 File Offset: 0x002A6734
			// (set) Token: 0x0600A19B RID: 41371 RVA: 0x00057496 File Offset: 0x00055696
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003559 RID: 13657
			// (get) Token: 0x0600A19C RID: 41372 RVA: 0x002A8564 File Offset: 0x002A6764
			// (set) Token: 0x0600A19D RID: 41373 RVA: 0x000574B5 File Offset: 0x000556B5
			public unsafe Coroutine qteCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_qteCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_qteCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700355A RID: 13658
			// (get) Token: 0x0600A19E RID: 41374 RVA: 0x002A8594 File Offset: 0x002A6794
			// (set) Token: 0x0600A19F RID: 41375 RVA: 0x000574D4 File Offset: 0x000556D4
			public unsafe UIElementCluster uiElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_uiElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_uiElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700355B RID: 13659
			// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x002A85C4 File Offset: 0x002A67C4
			// (set) Token: 0x0600A1A1 RID: 41377 RVA: 0x000574F3 File Offset: 0x000556F3
			public unsafe RogueLikeManager roguelikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_roguelikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_roguelikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700355C RID: 13660
			// (get) Token: 0x0600A1A2 RID: 41378 RVA: 0x002A85F4 File Offset: 0x002A67F4
			// (set) Token: 0x0600A1A3 RID: 41379 RVA: 0x00057512 File Offset: 0x00055712
			public unsafe int remainingWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_remainingWait);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_remainingWait)) = value;
				}
			}

			// Token: 0x1700355D RID: 13661
			// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x002A861C File Offset: 0x002A681C
			// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x0005752D File Offset: 0x0005572D
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700355E RID: 13662
			// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x002A864C File Offset: 0x002A684C
			// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x0005755B File Offset: 0x0005575B
			public unsafe Action<TextMeshProUGUI> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068AD RID: 26797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068AE RID: 26798
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040068AF RID: 26799
			private static readonly IntPtr NativeFieldInfoPtr_qteCorotine;

			// Token: 0x040068B0 RID: 26800
			private static readonly IntPtr NativeFieldInfoPtr_uiElement;

			// Token: 0x040068B1 RID: 26801
			private static readonly IntPtr NativeFieldInfoPtr_roguelikeManager;

			// Token: 0x040068B2 RID: 26802
			private static readonly IntPtr NativeFieldInfoPtr_remainingWait;

			// Token: 0x040068B3 RID: 26803
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040068B4 RID: 26804
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040068B5 RID: 26805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068B6 RID: 26806
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_String_String_0;

			// Token: 0x040068B7 RID: 26807
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Void_1;

			// Token: 0x040068B8 RID: 26808
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x040068B9 RID: 26809
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040068BA RID: 26810
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x040068BB RID: 26811
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x02000FDD RID: 4061
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Mamizou+<>c__DisplayClass9_0+<<EliteBossChallenge>g__QTECheck|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011702 RID: 71426 RVA: 0x00401A64 File Offset: 0x003FFC64
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>.NativeClassPtr, "<<EliteBossChallenge>g__QTECheck|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>8__1");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>8__2");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait2_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<wait2>5__2");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait3_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<wait3>5__3");
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670032);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670033);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670034);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670035);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670036);
					DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100670037);
				}

				// Token: 0x06011703 RID: 71427 RVA: 0x00401B94 File Offset: 0x003FFD94
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011704 RID: 71428 RVA: 0x00401BDC File Offset: 0x003FFDDC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011705 RID: 71429 RVA: 0x00401C10 File Offset: 0x003FFE10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88849, XrefRangeEnd = 88861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AA9 RID: 23209
				// (get) Token: 0x06011706 RID: 71430 RVA: 0x00401C4C File Offset: 0x003FFE4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011707 RID: 71431 RVA: 0x00401C8C File Offset: 0x003FFE8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88861, XrefRangeEnd = 88867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AAA RID: 23210
				// (get) Token: 0x06011708 RID: 71432 RVA: 0x00401CC0 File Offset: 0x003FFEC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011709 RID: 71433 RVA: 0x00097BF3 File Offset: 0x00095DF3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AA2 RID: 23202
				// (get) Token: 0x0601170A RID: 71434 RVA: 0x00401D00 File Offset: 0x003FFF00
				// (set) Token: 0x0601170B RID: 71435 RVA: 0x00097BFC File Offset: 0x00095DFC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AA3 RID: 23203
				// (get) Token: 0x0601170C RID: 71436 RVA: 0x00401D28 File Offset: 0x003FFF28
				// (set) Token: 0x0601170D RID: 71437 RVA: 0x00097C17 File Offset: 0x00095E17
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AA4 RID: 23204
				// (get) Token: 0x0601170E RID: 71438 RVA: 0x00401D58 File Offset: 0x003FFF58
				// (set) Token: 0x0601170F RID: 71439 RVA: 0x00097C36 File Offset: 0x00095E36
				public unsafe DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AA5 RID: 23205
				// (get) Token: 0x06011710 RID: 71440 RVA: 0x00401D88 File Offset: 0x003FFF88
				// (set) Token: 0x06011711 RID: 71441 RVA: 0x00097C55 File Offset: 0x00095E55
				public unsafe DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AA6 RID: 23206
				// (get) Token: 0x06011712 RID: 71442 RVA: 0x00401DB8 File Offset: 0x003FFFB8
				// (set) Token: 0x06011713 RID: 71443 RVA: 0x00097C74 File Offset: 0x00095E74
				public unsafe DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2 __8__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AA7 RID: 23207
				// (get) Token: 0x06011714 RID: 71444 RVA: 0x00401DE8 File Offset: 0x003FFFE8
				// (set) Token: 0x06011715 RID: 71445 RVA: 0x00097C93 File Offset: 0x00095E93
				public unsafe WaitForSeconds _wait2_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait2_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait2_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AA8 RID: 23208
				// (get) Token: 0x06011716 RID: 71446 RVA: 0x00401E18 File Offset: 0x00400018
				// (set) Token: 0x06011717 RID: 71447 RVA: 0x00097CB2 File Offset: 0x00095EB2
				public unsafe WaitUntil _wait3_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait3_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait3_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B031 RID: 45105
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B032 RID: 45106
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B033 RID: 45107
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B034 RID: 45108
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B035 RID: 45109
				private static readonly IntPtr NativeFieldInfoPtr___8__2;

				// Token: 0x0400B036 RID: 45110
				private static readonly IntPtr NativeFieldInfoPtr__wait2_5__2;

				// Token: 0x0400B037 RID: 45111
				private static readonly IntPtr NativeFieldInfoPtr__wait3_5__3;

				// Token: 0x0400B038 RID: 45112
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B039 RID: 45113
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B03A RID: 45114
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B03B RID: 45115
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B03C RID: 45116
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B03D RID: 45117
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200076F RID: 1903
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Mamizou+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x0600A1A8 RID: 41384 RVA: 0x002A867C File Offset: 0x002A687C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeFieldInfoPtr_hasQTEEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr, "hasQTEEnd");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr, 100670038);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr, 100670039);
			}

			// Token: 0x0600A1A9 RID: 41385 RVA: 0x002A86E4 File Offset: 0x002A68E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1AA RID: 41386 RVA: 0x002A8720 File Offset: 0x002A6920
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A1AB RID: 41387 RVA: 0x0005757A File Offset: 0x0005577A
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700355F RID: 13663
			// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x002A875C File Offset: 0x002A695C
			// (set) Token: 0x0600A1AD RID: 41389 RVA: 0x00057583 File Offset: 0x00055783
			public unsafe bool hasQTEEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeFieldInfoPtr_hasQTEEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1.NativeFieldInfoPtr_hasQTEEnd)) = value;
				}
			}

			// Token: 0x040068BC RID: 26812
			private static readonly IntPtr NativeFieldInfoPtr_hasQTEEnd;

			// Token: 0x040068BD RID: 26813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068BE RID: 26814
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_Boolean_0;
		}

		// Token: 0x02000770 RID: 1904
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Mamizou+<>c__DisplayClass9_2")]
		public sealed class __c__DisplayClass9_2 : Il2CppSystem.Object
		{
			// Token: 0x0600A1AE RID: 41390 RVA: 0x002A8784 File Offset: 0x002A6984
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "<>c__DisplayClass9_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr, "score");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr, 100670040);
				DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr, 100670041);
			}

			// Token: 0x0600A1AF RID: 41391 RVA: 0x002A8800 File Offset: 0x002A6A00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1B0 RID: 41392 RVA: 0x002A883C File Offset: 0x002A6A3C
			[CallerCount(0)]
			public unsafe void _EliteBossChallenge_b__6(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1B1 RID: 41393 RVA: 0x0005759E File Offset: 0x0005579E
			public __c__DisplayClass9_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003560 RID: 13664
			// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x002A887C File Offset: 0x002A6A7C
			// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x000575A7 File Offset: 0x000557A7
			public unsafe float score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_score)) = value;
				}
			}

			// Token: 0x17003561 RID: 13665
			// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x002A88A4 File Offset: 0x002A6AA4
			// (set) Token: 0x0600A1B5 RID: 41397 RVA: 0x000575C2 File Offset: 0x000557C2
			public unsafe DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1 field_Public___c__DisplayClass9_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou.__c__DisplayClass9_2.NativeFieldInfoPtr_field_Public___c__DisplayClass9_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068BF RID: 26815
			private static readonly IntPtr NativeFieldInfoPtr_score;

			// Token: 0x040068C0 RID: 26816
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_1_0;

			// Token: 0x040068C1 RID: 26817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068C2 RID: 26818
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Void_Single_0;
		}

		// Token: 0x02000771 RID: 1905
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Mamizou+<EliteBossSpellCardDeclaration>d__10")]
		public sealed class _EliteBossSpellCardDeclaration_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600A1B6 RID: 41398 RVA: 0x002A88D4 File Offset: 0x002A6AD4
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__10()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670042);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670043);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670044);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670045);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670046);
				DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr, 100670047);
			}

			// Token: 0x0600A1B7 RID: 41399 RVA: 0x002A89DC File Offset: 0x002A6BDC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1B8 RID: 41400 RVA: 0x002A8A24 File Offset: 0x002A6C24
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1B9 RID: 41401 RVA: 0x002A8A58 File Offset: 0x002A6C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88917, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003567 RID: 13671
			// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x002A8A94 File Offset: 0x002A6C94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A1BB RID: 41403 RVA: 0x002A8AD4 File Offset: 0x002A6CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88925, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003568 RID: 13672
			// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x002A8B08 File Offset: 0x002A6D08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A1BD RID: 41405 RVA: 0x000575E1 File Offset: 0x000557E1
			public _EliteBossSpellCardDeclaration_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003562 RID: 13666
			// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x002A8B48 File Offset: 0x002A6D48
			// (set) Token: 0x0600A1BF RID: 41407 RVA: 0x000575EA File Offset: 0x000557EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003563 RID: 13667
			// (get) Token: 0x0600A1C0 RID: 41408 RVA: 0x002A8B70 File Offset: 0x002A6D70
			// (set) Token: 0x0600A1C1 RID: 41409 RVA: 0x00057605 File Offset: 0x00055805
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003564 RID: 13668
			// (get) Token: 0x0600A1C2 RID: 41410 RVA: 0x002A8BA0 File Offset: 0x002A6DA0
			// (set) Token: 0x0600A1C3 RID: 41411 RVA: 0x00057624 File Offset: 0x00055824
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003565 RID: 13669
			// (get) Token: 0x0600A1C4 RID: 41412 RVA: 0x002A8BD0 File Offset: 0x002A6DD0
			// (set) Token: 0x0600A1C5 RID: 41413 RVA: 0x00057643 File Offset: 0x00055843
			public unsafe DLC5_RogueLikeEliteChallenge_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003566 RID: 13670
			// (get) Token: 0x0600A1C6 RID: 41414 RVA: 0x002A8C00 File Offset: 0x002A6E00
			// (set) Token: 0x0600A1C7 RID: 41415 RVA: 0x00057662 File Offset: 0x00055862
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Mamizou._EliteBossSpellCardDeclaration_d__10.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068C3 RID: 26819
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040068C4 RID: 26820
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040068C5 RID: 26821
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040068C6 RID: 26822
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068C7 RID: 26823
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x040068C8 RID: 26824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040068C9 RID: 26825
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068CA RID: 26826
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040068CB RID: 26827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040068CC RID: 26828
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068CD RID: 26829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
