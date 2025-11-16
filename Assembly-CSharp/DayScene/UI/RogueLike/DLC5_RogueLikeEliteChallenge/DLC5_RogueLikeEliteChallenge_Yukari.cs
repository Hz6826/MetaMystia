using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x0200013B RID: 315
	public class DLC5_RogueLikeEliteChallenge_Yukari : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x060025DD RID: 9693 RVA: 0x0011D81C File Offset: 0x0011BA1C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Yukari()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Yukari");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_banTagDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "banTagDuration");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_ingredientPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "ingredientPrefab");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "YUKARI_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "YUKARI_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "YUKARI_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_MIZUCHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "MIZUCHI_ID");
			DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, 100670074);
			DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, 100670075);
			DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, 100670076);
			DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, 100670077);
			DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, 100670078);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0011D928 File Offset: 0x0011BB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89521, XrefRangeEnd = 89524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x0011D97C File Offset: 0x0011BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89524, XrefRangeEnd = 89533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x0011D9E4 File Offset: 0x0011BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89533, XrefRangeEnd = 89608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0011DA70 File Offset: 0x0011BC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89608, XrefRangeEnd = 89615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0011DAE0 File Offset: 0x0011BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89615, XrefRangeEnd = 89616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Yukari() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00016640 File Offset: 0x00014840
		public DLC5_RogueLikeEliteChallenge_Yukari(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x0011DB1C File Offset: 0x0011BD1C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00016649 File Offset: 0x00014849
		public unsafe int banTagDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_banTagDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_banTagDuration)) = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x0011DB44 File Offset: 0x0011BD44
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00016664 File Offset: 0x00014864
		public unsafe GameObject ingredientPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_ingredientPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_ingredientPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x0011DB74 File Offset: 0x0011BD74
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x00016683 File Offset: 0x00014883
		public unsafe static string YUKARI_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x0011DB94 File Offset: 0x0011BD94
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x00016695 File Offset: 0x00014895
		public unsafe static string YUKARI_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x0011DBB4 File Offset: 0x0011BDB4
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x000166A7 File Offset: 0x000148A7
		public unsafe static string YUKARI_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_YUKARI_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x0011DBD4 File Offset: 0x0011BDD4
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x000166B9 File Offset: 0x000148B9
		public unsafe static int MIZUCHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&value));
			}
		}

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr_banTagDuration;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPrefab;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_CHALLENGE;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_CHALLENGE_TITLE;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_CHALLENGE_DESCRIPTION;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHI_ID;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000776 RID: 1910
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yukari+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A1FF RID: 41471 RVA: 0x002A9664 File Offset: 0x002A7864
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_parentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "parentRect");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allUsedIngredientsRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "allUsedIngredientsRecord");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptTanBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "interruptTanBuff");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_gridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "gridLayoutGroup");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, "allInstance");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670079);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670080);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670081);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670082);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670083);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670084);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670085);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr, 100670086);
			}

			// Token: 0x0600A200 RID: 41472 RVA: 0x002A97D0 File Offset: 0x002A79D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A201 RID: 41473 RVA: 0x002A980C File Offset: 0x002A7A0C
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__0(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A202 RID: 41474 RVA: 0x002A9850 File Offset: 0x002A7A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89220, XrefRangeEnd = 89225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__5(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A203 RID: 41475 RVA: 0x002A9898 File Offset: 0x002A7A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89225, XrefRangeEnd = 89282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Sellable_Recipe_PDM_0(Sellable lastOutput, Recipe targetRecipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastOutput);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetRecipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A204 RID: 41476 RVA: 0x002A98EC File Offset: 0x002A7AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89282, XrefRangeEnd = 89323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A205 RID: 41477 RVA: 0x002A9920 File Offset: 0x002A7B20
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89337, RefRangeEnd = 89339, XrefRangeStart = 89323, XrefRangeEnd = 89337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A206 RID: 41478 RVA: 0x002A9954 File Offset: 0x002A7B54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89386, RefRangeEnd = 89387, XrefRangeStart = 89339, XrefRangeEnd = 89386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A207 RID: 41479 RVA: 0x002A9988 File Offset: 0x002A7B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89387, XrefRangeEnd = 89408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__14(UIElementCluster cluster, ValueTuple<int, int> id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A208 RID: 41480 RVA: 0x00057850 File Offset: 0x00055A50
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700357A RID: 13690
			// (get) Token: 0x0600A209 RID: 41481 RVA: 0x002A99E4 File Offset: 0x002A7BE4
			// (set) Token: 0x0600A20A RID: 41482 RVA: 0x00057859 File Offset: 0x00055A59
			public unsafe RectTransform parentRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_parentRect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_parentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357B RID: 13691
			// (get) Token: 0x0600A20B RID: 41483 RVA: 0x002A9A14 File Offset: 0x002A7C14
			// (set) Token: 0x0600A20C RID: 41484 RVA: 0x00057878 File Offset: 0x00055A78
			public unsafe DLC5_RogueLikeEliteChallenge_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357C RID: 13692
			// (get) Token: 0x0600A20D RID: 41485 RVA: 0x002A9A44 File Offset: 0x002A7C44
			// (set) Token: 0x0600A20E RID: 41486 RVA: 0x00057897 File Offset: 0x00055A97
			public unsafe Dictionary<int, int> allUsedIngredientsRecord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allUsedIngredientsRecord);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allUsedIngredientsRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357D RID: 13693
			// (get) Token: 0x0600A20F RID: 41487 RVA: 0x002A9A74 File Offset: 0x002A7C74
			// (set) Token: 0x0600A210 RID: 41488 RVA: 0x000578B6 File Offset: 0x00055AB6
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357E RID: 13694
			// (get) Token: 0x0600A211 RID: 41489 RVA: 0x002A9AA4 File Offset: 0x002A7CA4
			// (set) Token: 0x0600A212 RID: 41490 RVA: 0x000578D5 File Offset: 0x00055AD5
			public unsafe List<Action> interruptTanBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptTanBuff);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_interruptTanBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357F RID: 13695
			// (get) Token: 0x0600A213 RID: 41491 RVA: 0x002A9AD4 File Offset: 0x002A7CD4
			// (set) Token: 0x0600A214 RID: 41492 RVA: 0x000578F4 File Offset: 0x00055AF4
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003580 RID: 13696
			// (get) Token: 0x0600A215 RID: 41493 RVA: 0x002A9B04 File Offset: 0x002A7D04
			// (set) Token: 0x0600A216 RID: 41494 RVA: 0x00057922 File Offset: 0x00055B22
			public unsafe GridLayoutGroup gridLayoutGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_gridLayoutGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_gridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003581 RID: 13697
			// (get) Token: 0x0600A217 RID: 41495 RVA: 0x002A9B34 File Offset: 0x002A7D34
			// (set) Token: 0x0600A218 RID: 41496 RVA: 0x00057941 File Offset: 0x00055B41
			public unsafe List<GameObject> allInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0.NativeFieldInfoPtr_allInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068EE RID: 26862
			private static readonly IntPtr NativeFieldInfoPtr_parentRect;

			// Token: 0x040068EF RID: 26863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068F0 RID: 26864
			private static readonly IntPtr NativeFieldInfoPtr_allUsedIngredientsRecord;

			// Token: 0x040068F1 RID: 26865
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040068F2 RID: 26866
			private static readonly IntPtr NativeFieldInfoPtr_interruptTanBuff;

			// Token: 0x040068F3 RID: 26867
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040068F4 RID: 26868
			private static readonly IntPtr NativeFieldInfoPtr_gridLayoutGroup;

			// Token: 0x040068F5 RID: 26869
			private static readonly IntPtr NativeFieldInfoPtr_allInstance;

			// Token: 0x040068F6 RID: 26870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068F7 RID: 26871
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_RectTransform_0;

			// Token: 0x040068F8 RID: 26872
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0;

			// Token: 0x040068F9 RID: 26873
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0;

			// Token: 0x040068FA RID: 26874
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040068FB RID: 26875
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x040068FC RID: 26876
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x040068FD RID: 26877
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0;
		}

		// Token: 0x02000777 RID: 1911
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yukari+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Il2CppSystem.Object
		{
			// Token: 0x0600A219 RID: 41497 RVA: 0x002A9B64 File Offset: 0x002A7D64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_allUsedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, "allUsedIngredients");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, "removeCallback");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_thisInterruptTanBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, "thisInterruptTanBuff");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, "<>9__9");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, 100670087);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, 100670088);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, 100670089);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, 100670090);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr, 100670091);
			}

			// Token: 0x0600A21A RID: 41498 RVA: 0x002A9C58 File Offset: 0x002A7E58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A21B RID: 41499 RVA: 0x002A9C94 File Offset: 0x002A7E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89408, XrefRangeEnd = 89423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__6(ValueTuple<Recipe, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A21C RID: 41500 RVA: 0x002A9CE8 File Offset: 0x002A7EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89423, XrefRangeEnd = 89426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__9(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A21D RID: 41501 RVA: 0x002A9D34 File Offset: 0x002A7F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89426, XrefRangeEnd = 89447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A21E RID: 41502 RVA: 0x002A9D68 File Offset: 0x002A7F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89447, XrefRangeEnd = 89492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__8(int currentTime, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A21F RID: 41503 RVA: 0x00057960 File Offset: 0x00055B60
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003582 RID: 13698
			// (get) Token: 0x0600A220 RID: 41504 RVA: 0x002A9DC0 File Offset: 0x002A7FC0
			// (set) Token: 0x0600A221 RID: 41505 RVA: 0x00057969 File Offset: 0x00055B69
			public unsafe HashSet<int> allUsedIngredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_allUsedIngredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_allUsedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003583 RID: 13699
			// (get) Token: 0x0600A222 RID: 41506 RVA: 0x002A9DF0 File Offset: 0x002A7FF0
			// (set) Token: 0x0600A223 RID: 41507 RVA: 0x00057988 File Offset: 0x00055B88
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003584 RID: 13700
			// (get) Token: 0x0600A224 RID: 41508 RVA: 0x002A9E20 File Offset: 0x002A8020
			// (set) Token: 0x0600A225 RID: 41509 RVA: 0x000579A7 File Offset: 0x00055BA7
			public unsafe Action thisInterruptTanBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_thisInterruptTanBuff);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_thisInterruptTanBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003585 RID: 13701
			// (get) Token: 0x0600A226 RID: 41510 RVA: 0x002A9E50 File Offset: 0x002A8050
			// (set) Token: 0x0600A227 RID: 41511 RVA: 0x000579C6 File Offset: 0x00055BC6
			public unsafe DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003586 RID: 13702
			// (get) Token: 0x0600A228 RID: 41512 RVA: 0x002A9E80 File Offset: 0x002A8080
			// (set) Token: 0x0600A229 RID: 41513 RVA: 0x000579E5 File Offset: 0x00055BE5
			public unsafe Func<int, bool> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_1.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068FE RID: 26878
			private static readonly IntPtr NativeFieldInfoPtr_allUsedIngredients;

			// Token: 0x040068FF RID: 26879
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x04006900 RID: 26880
			private static readonly IntPtr NativeFieldInfoPtr_thisInterruptTanBuff;

			// Token: 0x04006901 RID: 26881
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x04006902 RID: 26882
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x04006903 RID: 26883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006904 RID: 26884
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__6_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0;

			// Token: 0x04006905 RID: 26885
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_Boolean_Int32_0;

			// Token: 0x04006906 RID: 26886
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_0;

			// Token: 0x04006907 RID: 26887
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0;
		}

		// Token: 0x02000778 RID: 1912
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yukari+<>c__DisplayClass8_2")]
		public sealed class __c__DisplayClass8_2 : Il2CppSystem.Object
		{
			// Token: 0x0600A22A RID: 41514 RVA: 0x002A9EB0 File Offset: 0x002A80B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "<>c__DisplayClass8_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr, "id");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr, "CS$<>8__locals2");
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr, 100670092);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__EliteBossChallenge_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr, 100670093);
				DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__EliteBossChallenge_b__16_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr, 100670094);
			}

			// Token: 0x0600A22B RID: 41515 RVA: 0x002A9F40 File Offset: 0x002A8140
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A22C RID: 41516 RVA: 0x002A9F7C File Offset: 0x002A817C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89492, XrefRangeEnd = 89496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__15(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__EliteBossChallenge_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A22D RID: 41517 RVA: 0x002A9FC0 File Offset: 0x002A81C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89496, XrefRangeEnd = 89498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__16(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeMethodInfoPtr__EliteBossChallenge_b__16_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A22E RID: 41518 RVA: 0x00057A04 File Offset: 0x00055C04
			public __c__DisplayClass8_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003587 RID: 13703
			// (get) Token: 0x0600A22F RID: 41519 RVA: 0x002AA004 File Offset: 0x002A8204
			// (set) Token: 0x0600A230 RID: 41520 RVA: 0x00057A0D File Offset: 0x00055C0D
			public ValueTuple<int, int> id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_id);
					return new ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_id), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003588 RID: 13704
			// (get) Token: 0x0600A231 RID: 41521 RVA: 0x002AA034 File Offset: 0x002A8234
			// (set) Token: 0x0600A232 RID: 41522 RVA: 0x00057A3B File Offset: 0x00055C3B
			public unsafe DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006908 RID: 26888
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04006909 RID: 26889
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x0400690A RID: 26890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400690B RID: 26891
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__15_Internal_Void_Image_0;

			// Token: 0x0400690C RID: 26892
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__16_Internal_Void_Image_0;
		}

		// Token: 0x02000779 RID: 1913
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yukari+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A233 RID: 41523 RVA: 0x002AA064 File Offset: 0x002A8264
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, "<>9__8_10");
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, "<>9__8_11");
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, "<>9__8_12");
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, "<>9__8_13");
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, 100670096);
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_10_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, 100670097);
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_11_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, 100670098);
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_12_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, 100670099);
				DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_13_Internal_Int32_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr, 100670100);
			}

			// Token: 0x0600A234 RID: 41524 RVA: 0x002AA158 File Offset: 0x002A8358
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A235 RID: 41525 RVA: 0x002AA194 File Offset: 0x002A8394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__8_10(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_10_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A236 RID: 41526 RVA: 0x002AA1D8 File Offset: 0x002A83D8
			[CallerCount(0)]
			public unsafe void _EliteBossChallenge_b__8_11(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_11_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A237 RID: 41527 RVA: 0x002AA21C File Offset: 0x002A841C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89498, XrefRangeEnd = 89503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int> _EliteBossChallenge_b__8_12(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_12_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int>(pointer);
			}

			// Token: 0x0600A238 RID: 41528 RVA: 0x002AA26C File Offset: 0x002A846C
			[CallerCount(0)]
			public unsafe int _EliteBossChallenge_b__8_13(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeMethodInfoPtr__EliteBossChallenge_b__8_13_Internal_Int32_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A239 RID: 41529 RVA: 0x00057A5A File Offset: 0x00055C5A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003589 RID: 13705
			// (get) Token: 0x0600A23A RID: 41530 RVA: 0x002AA2C0 File Offset: 0x002A84C0
			// (set) Token: 0x0600A23B RID: 41531 RVA: 0x00057A63 File Offset: 0x00055C63
			public unsafe static DLC5_RogueLikeEliteChallenge_Yukari.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yukari.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358A RID: 13706
			// (get) Token: 0x0600A23C RID: 41532 RVA: 0x002AA2E8 File Offset: 0x002A84E8
			// (set) Token: 0x0600A23D RID: 41533 RVA: 0x00057A75 File Offset: 0x00055C75
			public unsafe static Func<int, string> __9__8_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358B RID: 13707
			// (get) Token: 0x0600A23E RID: 41534 RVA: 0x002AA310 File Offset: 0x002A8510
			// (set) Token: 0x0600A23F RID: 41535 RVA: 0x00057A87 File Offset: 0x00055C87
			public unsafe static Action<Action> __9__8_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358C RID: 13708
			// (get) Token: 0x0600A240 RID: 41536 RVA: 0x002AA338 File Offset: 0x002A8538
			// (set) Token: 0x0600A241 RID: 41537 RVA: 0x00057A99 File Offset: 0x00055C99
			public unsafe static Func<KeyValuePair<int, int>, ValueTuple<int, int>> __9__8_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, ValueTuple<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358D RID: 13709
			// (get) Token: 0x0600A242 RID: 41538 RVA: 0x002AA360 File Offset: 0x002A8560
			// (set) Token: 0x0600A243 RID: 41539 RVA: 0x00057AAB File Offset: 0x00055CAB
			public unsafe static Func<ValueTuple<int, int>, int> __9__8_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yukari.__c.NativeFieldInfoPtr___9__8_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400690D RID: 26893
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400690E RID: 26894
			private static readonly IntPtr NativeFieldInfoPtr___9__8_10;

			// Token: 0x0400690F RID: 26895
			private static readonly IntPtr NativeFieldInfoPtr___9__8_11;

			// Token: 0x04006910 RID: 26896
			private static readonly IntPtr NativeFieldInfoPtr___9__8_12;

			// Token: 0x04006911 RID: 26897
			private static readonly IntPtr NativeFieldInfoPtr___9__8_13;

			// Token: 0x04006912 RID: 26898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006913 RID: 26899
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_10_Internal_String_Int32_0;

			// Token: 0x04006914 RID: 26900
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_11_Internal_Void_Action_0;

			// Token: 0x04006915 RID: 26901
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_12_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006916 RID: 26902
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_13_Internal_Int32_ValueTuple_2_Int32_Int32_0;
		}

		// Token: 0x0200077A RID: 1914
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yukari+<EliteBossSpellCardDeclaration>d__9")]
		public sealed class _EliteBossSpellCardDeclaration_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600A244 RID: 41540 RVA: 0x002AA388 File Offset: 0x002A8588
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__9()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670101);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670102);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670103);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670104);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670105);
				DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr, 100670106);
			}

			// Token: 0x0600A245 RID: 41541 RVA: 0x002AA490 File Offset: 0x002A8690
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A246 RID: 41542 RVA: 0x002AA4D8 File Offset: 0x002A86D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A247 RID: 41543 RVA: 0x002AA50C File Offset: 0x002A870C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89503, XrefRangeEnd = 89515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003593 RID: 13715
			// (get) Token: 0x0600A248 RID: 41544 RVA: 0x002AA548 File Offset: 0x002A8748
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A249 RID: 41545 RVA: 0x002AA588 File Offset: 0x002A8788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89515, XrefRangeEnd = 89521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003594 RID: 13716
			// (get) Token: 0x0600A24A RID: 41546 RVA: 0x002AA5BC File Offset: 0x002A87BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A24B RID: 41547 RVA: 0x00057ABD File Offset: 0x00055CBD
			public _EliteBossSpellCardDeclaration_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700358E RID: 13710
			// (get) Token: 0x0600A24C RID: 41548 RVA: 0x002AA5FC File Offset: 0x002A87FC
			// (set) Token: 0x0600A24D RID: 41549 RVA: 0x00057AC6 File Offset: 0x00055CC6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700358F RID: 13711
			// (get) Token: 0x0600A24E RID: 41550 RVA: 0x002AA624 File Offset: 0x002A8824
			// (set) Token: 0x0600A24F RID: 41551 RVA: 0x00057AE1 File Offset: 0x00055CE1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003590 RID: 13712
			// (get) Token: 0x0600A250 RID: 41552 RVA: 0x002AA654 File Offset: 0x002A8854
			// (set) Token: 0x0600A251 RID: 41553 RVA: 0x00057B00 File Offset: 0x00055D00
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003591 RID: 13713
			// (get) Token: 0x0600A252 RID: 41554 RVA: 0x002AA684 File Offset: 0x002A8884
			// (set) Token: 0x0600A253 RID: 41555 RVA: 0x00057B1F File Offset: 0x00055D1F
			public unsafe DLC5_RogueLikeEliteChallenge_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003592 RID: 13714
			// (get) Token: 0x0600A254 RID: 41556 RVA: 0x002AA6B4 File Offset: 0x002A88B4
			// (set) Token: 0x0600A255 RID: 41557 RVA: 0x00057B3E File Offset: 0x00055D3E
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yukari._EliteBossSpellCardDeclaration_d__9.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006917 RID: 26903
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006918 RID: 26904
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006919 RID: 26905
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x0400691A RID: 26906
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400691B RID: 26907
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x0400691C RID: 26908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400691D RID: 26909
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400691E RID: 26910
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400691F RID: 26911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006920 RID: 26912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006921 RID: 26913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
