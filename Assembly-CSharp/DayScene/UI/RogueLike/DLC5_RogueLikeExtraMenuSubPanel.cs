using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010F RID: 271
	public class DLC5_RogueLikeExtraMenuSubPanel : UIPanelParamOpen<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x001019B4 File Offset: 0x000FFBB4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeExtraMenuSubPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeExtraMenuSubPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr);
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_NoteBookBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "NoteBookBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_StorageBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "StorageBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_CardBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "CardBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_TutorialBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "TutorialBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_SettingBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "SettingBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_ExitBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "ExitBtn");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_ConfirmPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "m_ConfirmPanel");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_StartAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "m_StartAnim");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "m_LogicalGroup");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "m_IsOpening");
			DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "m_IsClosing");
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668594);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_WaitFrameToClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668595);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668596);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_Exit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668597);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668598);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668599);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_TryClosePanel_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668600);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668601);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668602);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__WaitFrameToClose_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668603);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668604);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668605);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668606);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668607);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668608);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668609);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668610);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_6_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668611);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668612);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Private_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668613);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668614);
			DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__TryClosePanel_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, 100668615);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00101C78 File Offset: 0x000FFE78
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00101CC0 File Offset: 0x000FFEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74239, XrefRangeEnd = 74250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitFrameToClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_WaitFrameToClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00101CF4 File Offset: 0x000FFEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74250, XrefRangeEnd = 74343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00101D30 File Offset: 0x000FFF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74343, XrefRangeEnd = 74347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_Exit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00101D64 File Offset: 0x000FFF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74347, XrefRangeEnd = 74351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00101DA0 File Offset: 0x000FFFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74351, XrefRangeEnd = 74363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeExtraMenuSubPanel.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00101DF4 File Offset: 0x000FFFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74363, XrefRangeEnd = 74377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryClosePanel(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_TryClosePanel_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00101E3C File Offset: 0x0010003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74377, XrefRangeEnd = 74387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00101E78 File Offset: 0x00100078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74387, XrefRangeEnd = 74390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeExtraMenuSubPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00101EB4 File Offset: 0x001000B4
		[CallerCount(0)]
		public unsafe void _WaitFrameToClose_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__WaitFrameToClose_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00101EE8 File Offset: 0x001000E8
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__15_0(MoveDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00101F28 File Offset: 0x00100128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74390, XrefRangeEnd = 74401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00101F5C File Offset: 0x0010015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74401, XrefRangeEnd = 74412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00101F90 File Offset: 0x00100190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74412, XrefRangeEnd = 74420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00101FC4 File Offset: 0x001001C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74420, XrefRangeEnd = 74429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00101FF8 File Offset: 0x001001F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74429, XrefRangeEnd = 74449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0010202C File Offset: 0x0010022C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74449, XrefRangeEnd = 74453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00102060 File Offset: 0x00100260
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__15_6(MoveDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_6_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x001020A0 File Offset: 0x001002A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74453, XrefRangeEnd = 74476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x001020D4 File Offset: 0x001002D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74476, XrefRangeEnd = 74480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_9(DLC5_RogueLikeWinPanel.CloseContext closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Private_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00102114 File Offset: 0x00100314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74480, XrefRangeEnd = 74485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00102148 File Offset: 0x00100348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74485, XrefRangeEnd = 74490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TryClosePanel_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.NativeMethodInfoPtr__TryClosePanel_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00011E4B File Offset: 0x0001004B
		public DLC5_RogueLikeExtraMenuSubPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0010217C File Offset: 0x0010037C
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00011E54 File Offset: 0x00010054
		public unsafe UIButtonSimple NoteBookBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_NoteBookBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_NoteBookBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x001021AC File Offset: 0x001003AC
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00011E73 File Offset: 0x00010073
		public unsafe UIButtonSimple StorageBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_StorageBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_StorageBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x001021DC File Offset: 0x001003DC
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00011E92 File Offset: 0x00010092
		public unsafe UIButtonSimple CardBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_CardBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_CardBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0010220C File Offset: 0x0010040C
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00011EB1 File Offset: 0x000100B1
		public unsafe UIButtonSimple TutorialBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_TutorialBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_TutorialBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0010223C File Offset: 0x0010043C
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00011ED0 File Offset: 0x000100D0
		public unsafe UIButtonSimple SettingBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_SettingBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_SettingBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0010226C File Offset: 0x0010046C
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00011EEF File Offset: 0x000100EF
		public unsafe UIButtonSimple ExitBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_ExitBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_ExitBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0010229C File Offset: 0x0010049C
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00011F0E File Offset: 0x0001010E
		public unsafe DLC5_RogueLikeWinPanel m_ConfirmPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_ConfirmPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeWinPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_ConfirmPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x001022CC File Offset: 0x001004CC
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00011F2D File Offset: 0x0001012D
		public unsafe Animator m_StartAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_StartAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_StartAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x001022FC File Offset: 0x001004FC
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00011F4C File Offset: 0x0001014C
		public unsafe UILogicalGroup m_LogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_LogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0010232C File Offset: 0x0010052C
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00011F6B File Offset: 0x0001016B
		public unsafe bool m_IsOpening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsOpening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsOpening)) = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00102354 File Offset: 0x00100554
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00011F86 File Offset: 0x00010186
		public unsafe bool m_IsClosing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsClosing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.NativeFieldInfoPtr_m_IsClosing)) = value;
			}
		}

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_NoteBookBtn;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_StorageBtn;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_CardBtn;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_TutorialBtn;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_SettingBtn;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_ExitBtn;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmPanel;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAnim;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOpening;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_m_IsClosing;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_WaitFrameToClose_Private_Void_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_TryClosePanel_Private_Void_CallbackContext_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr__WaitFrameToClose_b__14_0_Private_Void_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_MoveDirection_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_2_Private_Void_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_3_Private_Void_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_4_Private_Void_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_5_Private_Void_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Private_Void_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_6_Private_Void_MoveDirection_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Private_Void_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Private_Void_CloseContext_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_0_Private_Void_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__19_0_Private_Void_0;

		// Token: 0x020006E3 RID: 1763
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009A9B RID: 39579 RVA: 0x00292288 File Offset: 0x00290488
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr);
				DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr, "RogueLikeRunTimeData");
				DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_CloseParentCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr, "CloseParentCallback");
				DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Action_1_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr, 100668616);
			}

			// Token: 0x06009A9C RID: 39580 RVA: 0x002922F0 File Offset: 0x002904F0
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext> closeParentCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closeParentCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Action_1_CloseContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A9D RID: 39581 RVA: 0x00053AA0 File Offset: 0x00051CA0
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009A9E RID: 39582 RVA: 0x00053AA9 File Offset: 0x00051CA9
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003358 RID: 13144
			// (get) Token: 0x06009A9F RID: 39583 RVA: 0x00292354 File Offset: 0x00290554
			// (set) Token: 0x06009AA0 RID: 39584 RVA: 0x00053ABB File Offset: 0x00051CBB
			public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003359 RID: 13145
			// (get) Token: 0x06009AA1 RID: 39585 RVA: 0x00292384 File Offset: 0x00290584
			// (set) Token: 0x06009AA2 RID: 39586 RVA: 0x00053ADA File Offset: 0x00051CDA
			public unsafe Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext> CloseParentCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_CloseParentCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeExtraMenuSubPanel.OpenContext.NativeFieldInfoPtr_CloseParentCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006486 RID: 25734
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeRunTimeData;

			// Token: 0x04006487 RID: 25735
			private static readonly IntPtr NativeFieldInfoPtr_CloseParentCallback;

			// Token: 0x04006488 RID: 25736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Action_1_CloseContext_0;
		}

		// Token: 0x020006E4 RID: 1764
		public enum CloseContext
		{
			// Token: 0x0400648A RID: 25738
			Norm,
			// Token: 0x0400648B RID: 25739
			ExitRogueMode,
			// Token: 0x0400648C RID: 25740
			BackToMenu
		}
	}
}
