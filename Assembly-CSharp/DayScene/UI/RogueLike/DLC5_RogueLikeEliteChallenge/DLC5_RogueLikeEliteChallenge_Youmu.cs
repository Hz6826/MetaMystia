using System;
using GameData.Core.Collections;
using GameData.Profile;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using TMPro;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x0200013A RID: 314
	public class DLC5_RogueLikeEliteChallenge_Youmu : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x060025B9 RID: 9657 RVA: 0x0011D184 File Offset: 0x0011B384
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Youmu()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Youmu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_1");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_2");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_3");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1_INGTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_1_INGTYPE");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2_INGTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_2_INGTYPE");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3_INGTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_3_INGTYPE");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_POSTCHECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_CHALLENGE_POSTCHECK");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_MEAT_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "MEAT_TAG_ID");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_SEA_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "SEA_TAG_ID");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_VEGGIE_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "VEGGIE_TAG_ID");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "YOUMU_ID");
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670048);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670049);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetTagName_Private_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670050);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670051);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670052);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670053);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670054);
			DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, 100670055);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x0011D358 File Offset: 0x0011B558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89059, XrefRangeEnd = 89076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0011D3AC File Offset: 0x0011B5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89076, XrefRangeEnd = 89085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0011D414 File Offset: 0x0011B614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 89090, RefRangeEnd = 89093, XrefRangeStart = 89085, XrefRangeEnd = 89090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTagName(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GetTagName_Private_String_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0011D45C File Offset: 0x0011B65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89093, XrefRangeEnd = 89098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeCache>(intPtr3) : null;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0011D4CC File Offset: 0x0011B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89098, XrefRangeEnd = 89138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0011D558 File Offset: 0x0011B758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89138, XrefRangeEnd = 89145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89145, XrefRangeEnd = 89220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0011D650 File Offset: 0x0011B850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Youmu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0001655D File Offset: 0x0001475D
		public DLC5_RogueLikeEliteChallenge_Youmu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x0011D68C File Offset: 0x0011B88C
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x00016566 File Offset: 0x00014766
		public unsafe static string YOUMU_CHALLENGE_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x0011D6AC File Offset: 0x0011B8AC
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00016578 File Offset: 0x00014778
		public unsafe static string YOUMU_CHALLENGE_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0011D6CC File Offset: 0x0011B8CC
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x0001658A File Offset: 0x0001478A
		public unsafe static string YOUMU_CHALLENGE_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x0011D6EC File Offset: 0x0011B8EC
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x0001659C File Offset: 0x0001479C
		public unsafe static string YOUMU_CHALLENGE_1_INGTYPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1_INGTYPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_1_INGTYPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x0011D70C File Offset: 0x0011B90C
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x000165AE File Offset: 0x000147AE
		public unsafe static string YOUMU_CHALLENGE_2_INGTYPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2_INGTYPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_2_INGTYPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x0011D72C File Offset: 0x0011B92C
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x000165C0 File Offset: 0x000147C0
		public unsafe static string YOUMU_CHALLENGE_3_INGTYPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3_INGTYPE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_3_INGTYPE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x0011D74C File Offset: 0x0011B94C
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x000165D2 File Offset: 0x000147D2
		public unsafe static string YOUMU_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x0011D76C File Offset: 0x0011B96C
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x000165E4 File Offset: 0x000147E4
		public unsafe static string YOUMU_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x0011D78C File Offset: 0x0011B98C
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x000165F6 File Offset: 0x000147F6
		public unsafe static string YOUMU_CHALLENGE_POSTCHECK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_POSTCHECK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_CHALLENGE_POSTCHECK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x0011D7AC File Offset: 0x0011B9AC
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00016608 File Offset: 0x00014808
		public unsafe static int MEAT_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_MEAT_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_MEAT_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0011D7C8 File Offset: 0x0011B9C8
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00016616 File Offset: 0x00014816
		public unsafe static int SEA_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_SEA_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_SEA_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0011D7E4 File Offset: 0x0011B9E4
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x00016624 File Offset: 0x00014824
		public unsafe static int VEGGIE_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_VEGGIE_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_VEGGIE_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x0011D800 File Offset: 0x0011BA00
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x00016632 File Offset: 0x00014832
		public unsafe static int YOUMU_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.NativeFieldInfoPtr_YOUMU_ID, (void*)(&value));
			}
		}

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_1;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_2;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_3;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_1_INGTYPE;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_2_INGTYPE;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_3_INGTYPE;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_TITLE;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_DESCRIPTION;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_CHALLENGE_POSTCHECK;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeFieldInfoPtr_MEAT_TAG_ID;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeFieldInfoPtr_SEA_TAG_ID;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeFieldInfoPtr_VEGGIE_TAG_ID;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeFieldInfoPtr_YOUMU_ID;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_GetTagName_Private_String_EliteChallengeCache_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_CheckNeedNoticeBeforeWork_Public_Virtual_Boolean_EliteChallengeCache_IzakayaConfigure_byref_String_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000772 RID: 1906
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Youmu+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600A1C8 RID: 41416 RVA: 0x002A8C30 File Offset: 0x002A6E30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "tagId");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "removeCallback");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "<>9__3");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, "<>9__4");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670056);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670057);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670058);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670059);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670060);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670061);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr, 100670062);
			}

			// Token: 0x0600A1C9 RID: 41417 RVA: 0x002A8D60 File Offset: 0x002A6F60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1CA RID: 41418 RVA: 0x002A8D9C File Offset: 0x002A6F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88989, XrefRangeEnd = 89009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__0(ValueTuple<Recipe, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A1CB RID: 41419 RVA: 0x002A8DF0 File Offset: 0x002A6FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89009, XrefRangeEnd = 89014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__3(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A1CC RID: 41420 RVA: 0x002A8E3C File Offset: 0x002A703C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89014, XrefRangeEnd = 89019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EliteBossChallenge_b__4(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A1CD RID: 41421 RVA: 0x002A8E88 File Offset: 0x002A7088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89019, XrefRangeEnd = 89024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__5(string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A1CE RID: 41422 RVA: 0x002A8ED0 File Offset: 0x002A70D0
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1CF RID: 41423 RVA: 0x002A8F04 File Offset: 0x002A7104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89024, XrefRangeEnd = 89032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1D0 RID: 41424 RVA: 0x00057681 File Offset: 0x00055881
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003569 RID: 13673
			// (get) Token: 0x0600A1D1 RID: 41425 RVA: 0x002A8F48 File Offset: 0x002A7148
			// (set) Token: 0x0600A1D2 RID: 41426 RVA: 0x0005768A File Offset: 0x0005588A
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x1700356A RID: 13674
			// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x002A8F70 File Offset: 0x002A7170
			// (set) Token: 0x0600A1D4 RID: 41428 RVA: 0x000576A5 File Offset: 0x000558A5
			public unsafe DLC5_RogueLikeEliteChallenge_Youmu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Youmu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700356B RID: 13675
			// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x002A8FA0 File Offset: 0x002A71A0
			// (set) Token: 0x0600A1D6 RID: 41430 RVA: 0x000576C4 File Offset: 0x000558C4
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700356C RID: 13676
			// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x002A8FD0 File Offset: 0x002A71D0
			// (set) Token: 0x0600A1D8 RID: 41432 RVA: 0x000576E3 File Offset: 0x000558E3
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700356D RID: 13677
			// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x002A9000 File Offset: 0x002A7200
			// (set) Token: 0x0600A1DA RID: 41434 RVA: 0x00057702 File Offset: 0x00055902
			public unsafe Func<int, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700356E RID: 13678
			// (get) Token: 0x0600A1DB RID: 41435 RVA: 0x002A9030 File Offset: 0x002A7230
			// (set) Token: 0x0600A1DC RID: 41436 RVA: 0x00057721 File Offset: 0x00055921
			public unsafe Func<int, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068CE RID: 26830
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x040068CF RID: 26831
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068D0 RID: 26832
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x040068D1 RID: 26833
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x040068D2 RID: 26834
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040068D3 RID: 26835
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040068D4 RID: 26836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068D5 RID: 26837
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0;

			// Token: 0x040068D6 RID: 26838
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__3_Internal_Boolean_Int32_0;

			// Token: 0x040068D7 RID: 26839
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__4_Internal_Boolean_Int32_0;

			// Token: 0x040068D8 RID: 26840
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__5_Internal_String_String_0;

			// Token: 0x040068D9 RID: 26841
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040068DA RID: 26842
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000773 RID: 1907
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Youmu+<EliteBossSpellCardDeclaration>d__18")]
		public sealed class _EliteBossSpellCardDeclaration_d__18 : Object
		{
			// Token: 0x0600A1DD RID: 41437 RVA: 0x002A9060 File Offset: 0x002A7260
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__18()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670063);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670064);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670065);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670066);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670067);
				DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr, 100670068);
			}

			// Token: 0x0600A1DE RID: 41438 RVA: 0x002A9168 File Offset: 0x002A7368
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1DF RID: 41439 RVA: 0x002A91B0 File Offset: 0x002A73B0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1E0 RID: 41440 RVA: 0x002A91E4 File Offset: 0x002A73E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89032, XrefRangeEnd = 89044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003574 RID: 13684
			// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x002A9220 File Offset: 0x002A7420
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A1E2 RID: 41442 RVA: 0x002A9260 File Offset: 0x002A7460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89044, XrefRangeEnd = 89050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003575 RID: 13685
			// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x002A9294 File Offset: 0x002A7494
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A1E4 RID: 41444 RVA: 0x00057740 File Offset: 0x00055940
			public _EliteBossSpellCardDeclaration_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700356F RID: 13679
			// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x002A92D4 File Offset: 0x002A74D4
			// (set) Token: 0x0600A1E6 RID: 41446 RVA: 0x00057749 File Offset: 0x00055949
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003570 RID: 13680
			// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x002A92FC File Offset: 0x002A74FC
			// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x00057764 File Offset: 0x00055964
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003571 RID: 13681
			// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x002A932C File Offset: 0x002A752C
			// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x00057783 File Offset: 0x00055983
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003572 RID: 13682
			// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x002A935C File Offset: 0x002A755C
			// (set) Token: 0x0600A1EC RID: 41452 RVA: 0x000577A2 File Offset: 0x000559A2
			public unsafe DLC5_RogueLikeEliteChallenge_Youmu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Youmu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003573 RID: 13683
			// (get) Token: 0x0600A1ED RID: 41453 RVA: 0x002A938C File Offset: 0x002A758C
			// (set) Token: 0x0600A1EE RID: 41454 RVA: 0x000577C1 File Offset: 0x000559C1
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu._EliteBossSpellCardDeclaration_d__18.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068DB RID: 26843
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040068DC RID: 26844
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040068DD RID: 26845
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040068DE RID: 26846
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040068DF RID: 26847
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x040068E0 RID: 26848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040068E1 RID: 26849
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068E2 RID: 26850
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040068E3 RID: 26851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040068E4 RID: 26852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040068E5 RID: 26853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000774 RID: 1908
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Youmu+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600A1EF RID: 41455 RVA: 0x002A93BC File Offset: 0x002A75BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr, "tagId");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr, "<>9__1");
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr, 100670069);
				DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr, 100670070);
			}

			// Token: 0x0600A1F0 RID: 41456 RVA: 0x002A9438 File Offset: 0x002A7638
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1F1 RID: 41457 RVA: 0x002A9474 File Offset: 0x002A7674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89050, XrefRangeEnd = 89055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckNeedNoticeBeforeWork_b__1(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A1F2 RID: 41458 RVA: 0x000577E0 File Offset: 0x000559E0
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003576 RID: 13686
			// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x002A94C0 File Offset: 0x002A76C0
			// (set) Token: 0x0600A1F4 RID: 41460 RVA: 0x000577E9 File Offset: 0x000559E9
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x17003577 RID: 13687
			// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x002A94E8 File Offset: 0x002A76E8
			// (set) Token: 0x0600A1F6 RID: 41462 RVA: 0x00057804 File Offset: 0x00055A04
			public unsafe Func<int, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Youmu.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068E6 RID: 26854
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x040068E7 RID: 26855
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040068E8 RID: 26856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068E9 RID: 26857
			private static readonly IntPtr NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000775 RID: 1909
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Youmu+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A1F7 RID: 41463 RVA: 0x002A9518 File Offset: 0x002A7718
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr, "<>9__19_0");
				DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr, 100670072);
				DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__19_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr, 100670073);
			}

			// Token: 0x0600A1F8 RID: 41464 RVA: 0x002A9594 File Offset: 0x002A7794
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Youmu.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A1F9 RID: 41465 RVA: 0x002A95D0 File Offset: 0x002A77D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89055, XrefRangeEnd = 89059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CheckNeedNoticeBeforeWork_b__19_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__19_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A1FA RID: 41466 RVA: 0x00057823 File Offset: 0x00055A23
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003578 RID: 13688
			// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x002A9614 File Offset: 0x002A7814
			// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x0005782C File Offset: 0x00055A2C
			public unsafe static DLC5_RogueLikeEliteChallenge_Youmu.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Youmu.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003579 RID: 13689
			// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x002A963C File Offset: 0x002A783C
			// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x0005783E File Offset: 0x00055A3E
			public unsafe static Func<int, string> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Youmu.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040068EA RID: 26858
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040068EB RID: 26859
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040068EC RID: 26860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040068ED RID: 26861
			private static readonly IntPtr NativeMethodInfoPtr__CheckNeedNoticeBeforeWork_b__19_0_Internal_String_Int32_0;
		}
	}
}
