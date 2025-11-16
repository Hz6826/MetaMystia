using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000113 RID: 275
	public class DLC5_RogueLikeMainPanel : UIPanelParam<ValueTuple<DLC5_RogueLikeSaveLoadPanel, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>, IRogueLikeData>, ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x00102EEC File Offset: 0x001010EC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeMainPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeMainPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr);
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_RogueLikeNewGamePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_RogueLikeNewGamePanel");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_ContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_ContinueButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_NewGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_NewGameButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_CloseButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_TutorialButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_StaffButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_BadgeButton");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_BadgeDialog");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeClaimPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_BadgeClaimPanel");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_StaffPanel");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_TutorialDialog");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_Difficulty");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_AchievementRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "m_AchievementRunTimeData");
			DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_MIKE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "MIKE_ID");
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_get_RogueLikeData_Public_get_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668646);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668647);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_ClosePanelWithData_Private_Void_Selection_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668648);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_3_DLC5_RogueLikeSaveLoadPanel_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668649);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OpenStaffPanel_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668650);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668651);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668652);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668653);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668654);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668655);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668656);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_3_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668657);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668658);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668659);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668660);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_10_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668661);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668662);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668663);
			DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, 100668664);
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x001031B0 File Offset: 0x001013B0
		public unsafe IRogueLikeData RogueLikeData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74931, XrefRangeEnd = 74932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_get_RogueLikeData_Public_get_IRogueLikeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new IRogueLikeData(pointer);
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x001031E8 File Offset: 0x001013E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74932, XrefRangeEnd = 74988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00103224 File Offset: 0x00101424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74994, RefRangeEnd = 74997, XrefRangeStart = 74988, XrefRangeEnd = 74994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePanelWithData(DLC5_RogueLikeMainPanel.Selection selection, Nullable<int> index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(index));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_ClosePanelWithData_Private_Void_Selection_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0010327C File Offset: 0x0010147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74997, XrefRangeEnd = 75024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<DLC5_RogueLikeSaveLoadPanel, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>, IRogueLikeData> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_3_DLC5_RogueLikeSaveLoadPanel_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x001032D0 File Offset: 0x001014D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75041, RefRangeEnd = 75042, XrefRangeStart = 75024, XrefRangeEnd = 75041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenStaffPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OpenStaffPanel_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00103308 File Offset: 0x00101508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00103344 File Offset: 0x00101544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75042, XrefRangeEnd = 75055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMainPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00103380 File Offset: 0x00101580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75055, XrefRangeEnd = 75058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeMainPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x001033BC File Offset: 0x001015BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75058, XrefRangeEnd = 75063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid _OnPanelInitialize_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x001033F8 File Offset: 0x001015F8
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__17_1(MoveDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00103438 File Offset: 0x00101638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75063, XrefRangeEnd = 75086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0010346C File Offset: 0x0010166C
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__17_3(MoveDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_3_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x001034AC File Offset: 0x001016AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75086, XrefRangeEnd = 75087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x001034E0 File Offset: 0x001016E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75087, XrefRangeEnd = 75101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00103514 File Offset: 0x00101714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75101, XrefRangeEnd = 75103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00103548 File Offset: 0x00101748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75103, XrefRangeEnd = 75107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_10(Action x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_10_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0010358C File Offset: 0x0010178C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75107, XrefRangeEnd = 75109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x001035C0 File Offset: 0x001017C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75109, XrefRangeEnd = 75119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x001035F4 File Offset: 0x001017F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75119, XrefRangeEnd = 75130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__17_11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.NativeMethodInfoPtr__OnPanelInitialize_b__17_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000121F4 File Offset: 0x000103F4
		public DLC5_RogueLikeMainPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00103628 File Offset: 0x00101828
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x000121FD File Offset: 0x000103FD
		public unsafe DLC5_RogueLikeNewGamePanel m_RogueLikeNewGamePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_RogueLikeNewGamePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeNewGamePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_RogueLikeNewGamePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00103658 File Offset: 0x00101858
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x0001221C File Offset: 0x0001041C
		public unsafe UIButtonSimple m_ContinueButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_ContinueButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_ContinueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x00103688 File Offset: 0x00101888
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x0001223B File Offset: 0x0001043B
		public unsafe UIButtonSimple m_NewGameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_NewGameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_NewGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x001036B8 File Offset: 0x001018B8
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x0001225A File Offset: 0x0001045A
		public unsafe UIButtonSimple m_CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x001036E8 File Offset: 0x001018E8
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00012279 File Offset: 0x00010479
		public unsafe UIButtonSimple m_TutorialButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00103718 File Offset: 0x00101918
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00012298 File Offset: 0x00010498
		public unsafe UIButtonSimple m_StaffButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00103748 File Offset: 0x00101948
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x000122B7 File Offset: 0x000104B7
		public unsafe UIButtonSimple m_BadgeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00103778 File Offset: 0x00101978
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x000122D6 File Offset: 0x000104D6
		public unsafe DialogPackage m_BadgeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x001037A8 File Offset: 0x001019A8
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x000122F5 File Offset: 0x000104F5
		public unsafe DLC5_RogueLikeMainBadgeRewardPanel m_BadgeClaimPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeClaimPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainBadgeRewardPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_BadgeClaimPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x001037D8 File Offset: 0x001019D8
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00012314 File Offset: 0x00010514
		public unsafe AssetReference m_StaffPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_StaffPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00103808 File Offset: 0x00101A08
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00012333 File Offset: 0x00010533
		public unsafe DialogPackage m_TutorialDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_TutorialDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00103838 File Offset: 0x00101A38
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00012352 File Offset: 0x00010552
		public unsafe NightSceneDirector.Difficulty m_Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_Difficulty)) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00103860 File Offset: 0x00101A60
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x0001236D File Offset: 0x0001056D
		public unsafe RogueLikeAchievementRunTimeData m_AchievementRunTimeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_AchievementRunTimeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_m_AchievementRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00103890 File Offset: 0x00101A90
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0001238C File Offset: 0x0001058C
		public unsafe static int MIKE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_MIKE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMainPanel.NativeFieldInfoPtr_MIKE_ID, (void*)(&value));
			}
		}

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeNewGamePanel;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeFieldInfoPtr_m_ContinueButton;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_m_NewGameButton;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_m_CloseButton;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_m_TutorialButton;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_m_StaffButton;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeButton;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeDialog;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeClaimPanel;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeFieldInfoPtr_m_StaffPanel;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeFieldInfoPtr_m_TutorialDialog;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeFieldInfoPtr_m_Difficulty;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementRunTimeData;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeFieldInfoPtr_MIKE_ID;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeData_Public_get_IRogueLikeData_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_ClosePanelWithData_Private_Void_Selection_Nullable_1_Int32_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_3_DLC5_RogueLikeSaveLoadPanel_HashSet_1_RogueLikeAchievementType_IRogueLikeData_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_OpenStaffPanel_Private_UniTask_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_0_Private_UniTaskVoid_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_1_Private_Void_MoveDirection_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_2_Private_Void_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_3_Private_Void_MoveDirection_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_4_Private_Void_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_5_Private_Void_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_9_Private_Void_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_10_Private_Void_Action_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_6_Private_Void_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_7_Private_Void_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_11_Private_Void_0;

		// Token: 0x020006E8 RID: 1768
		public enum Selection
		{
			// Token: 0x040064A0 RID: 25760
			Continue,
			// Token: 0x040064A1 RID: 25761
			NewGame,
			// Token: 0x040064A2 RID: 25762
			None
		}

		// Token: 0x020006E9 RID: 1769
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainPanel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x06009AC4 RID: 39620 RVA: 0x00292970 File Offset: 0x00290B70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr);
				DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_newGamePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr, "newGamePanel");
				DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr, 100668665);
				DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr, 100668666);
			}

			// Token: 0x06009AC5 RID: 39621 RVA: 0x002929EC File Offset: 0x00290BEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AC6 RID: 39622 RVA: 0x00292A28 File Offset: 0x00290C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74804, XrefRangeEnd = 74805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AC7 RID: 39623 RVA: 0x00053BF8 File Offset: 0x00051DF8
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003363 RID: 13155
			// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x00292A5C File Offset: 0x00290C5C
			// (set) Token: 0x06009AC9 RID: 39625 RVA: 0x00053C01 File Offset: 0x00051E01
			public unsafe DLC5_RogueLikeNewGamePanel newGamePanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_newGamePanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeNewGamePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_newGamePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003364 RID: 13156
			// (get) Token: 0x06009ACA RID: 39626 RVA: 0x00292A8C File Offset: 0x00290C8C
			// (set) Token: 0x06009ACB RID: 39627 RVA: 0x00053C20 File Offset: 0x00051E20
			public unsafe DLC5_RogueLikeMainPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064A3 RID: 25763
			private static readonly IntPtr NativeFieldInfoPtr_newGamePanel;

			// Token: 0x040064A4 RID: 25764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064A5 RID: 25765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064A6 RID: 25766
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_0;
		}

		// Token: 0x020006EA RID: 1770
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainPanel+<OpenStaffPanel>d__20")]
		public sealed class _OpenStaffPanel_d__20 : ValueType
		{
			// Token: 0x06009ACC RID: 39628 RVA: 0x00292ABC File Offset: 0x00290CBC
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenStaffPanel_d__20()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "<OpenStaffPanel>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr);
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, 100668667);
				DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr, 100668668);
			}

			// Token: 0x06009ACD RID: 39629 RVA: 0x00292B60 File Offset: 0x00290D60
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 74851, RefRangeEnd = 74854, XrefRangeStart = 74805, XrefRangeEnd = 74851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ACE RID: 39630 RVA: 0x00292B98 File Offset: 0x00290D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ACF RID: 39631 RVA: 0x00053C3F File Offset: 0x00051E3F
			public _OpenStaffPanel_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009AD0 RID: 39632 RVA: 0x00053C48 File Offset: 0x00051E48
			public _OpenStaffPanel_d__20() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17003365 RID: 13157
			// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x00292BE0 File Offset: 0x00290DE0
			// (set) Token: 0x06009AD2 RID: 39634 RVA: 0x00053C5A File Offset: 0x00051E5A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003366 RID: 13158
			// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x00292C08 File Offset: 0x00290E08
			// (set) Token: 0x06009AD4 RID: 39636 RVA: 0x00053C75 File Offset: 0x00051E75
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003367 RID: 13159
			// (get) Token: 0x06009AD5 RID: 39637 RVA: 0x00292C38 File Offset: 0x00290E38
			// (set) Token: 0x06009AD6 RID: 39638 RVA: 0x00053CA3 File Offset: 0x00051EA3
			public unsafe DLC5_RogueLikeMainPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003368 RID: 13160
			// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x00292C68 File Offset: 0x00290E68
			// (set) Token: 0x06009AD8 RID: 39640 RVA: 0x00053CC2 File Offset: 0x00051EC2
			public UniTask<DLC5_RogueLikeStaffPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeStaffPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeStaffPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel._OpenStaffPanel_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeStaffPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040064A7 RID: 25767
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040064A8 RID: 25768
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040064A9 RID: 25769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064AA RID: 25770
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040064AB RID: 25771
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040064AC RID: 25772
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020006EB RID: 1771
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMainPanel+<<OnPanelInitialize>b__17_0>d")]
		public sealed class __OnPanelInitialize_b__17_0_d : ValueType
		{
			// Token: 0x06009AD9 RID: 39641 RVA: 0x00292C98 File Offset: 0x00290E98
			// Note: this type is marked as 'beforefieldinit'.
			static __OnPanelInitialize_b__17_0_d()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel>.NativeClassPtr, "<<OnPanelInitialize>b__17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr);
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, 100668669);
				DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr, 100668670);
			}

			// Token: 0x06009ADA RID: 39642 RVA: 0x00292D3C File Offset: 0x00290F3C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 74929, RefRangeEnd = 74931, XrefRangeStart = 74854, XrefRangeEnd = 74929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ADB RID: 39643 RVA: 0x00292D74 File Offset: 0x00290F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ADC RID: 39644 RVA: 0x00053CF0 File Offset: 0x00051EF0
			public __OnPanelInitialize_b__17_0_d(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009ADD RID: 39645 RVA: 0x00053CF9 File Offset: 0x00051EF9
			public __OnPanelInitialize_b__17_0_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d>.NativeClassPtr))
			{
			}

			// Token: 0x17003369 RID: 13161
			// (get) Token: 0x06009ADE RID: 39646 RVA: 0x00292DBC File Offset: 0x00290FBC
			// (set) Token: 0x06009ADF RID: 39647 RVA: 0x00053D0B File Offset: 0x00051F0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700336A RID: 13162
			// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x00292DE4 File Offset: 0x00290FE4
			// (set) Token: 0x06009AE1 RID: 39649 RVA: 0x00053D26 File Offset: 0x00051F26
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700336B RID: 13163
			// (get) Token: 0x06009AE2 RID: 39650 RVA: 0x00292E14 File Offset: 0x00291014
			// (set) Token: 0x06009AE3 RID: 39651 RVA: 0x00053D54 File Offset: 0x00051F54
			public unsafe DLC5_RogueLikeMainPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700336C RID: 13164
			// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x00292E44 File Offset: 0x00291044
			// (set) Token: 0x06009AE5 RID: 39653 RVA: 0x00053D73 File Offset: 0x00051F73
			public UniTask<Nullable<int>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___u__1);
					return new UniTask<Nullable<int>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMainPanel.__OnPanelInitialize_b__17_0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040064AD RID: 25773
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040064AE RID: 25774
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040064AF RID: 25775
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064B0 RID: 25776
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040064B1 RID: 25777
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040064B2 RID: 25778
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
