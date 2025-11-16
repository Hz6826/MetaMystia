using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using NightScene;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000116 RID: 278
	public class DLC5_RogueLikeNewGamePanel : UISubPanel<DLC5_RogueLikeMainPanel>
	{
		// Token: 0x06001E91 RID: 7825 RVA: 0x00104714 File Offset: 0x00102914
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeNewGamePanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeNewGamePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr);
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentDifficultyTargetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_CurrentDifficultyTargetText");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_CurrentIndexText");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_StartBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_StartBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_PerviousBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_PerviousBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_NextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_NextBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_EasyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "EasyBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_NormalBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "NormalBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_HardBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "HardBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_LunaticBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "LunaticBtn");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__Difficulty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "<Difficulty>k__BackingField");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__PanelCloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "<PanelCloseContext>k__BackingField");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__IsFirstOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "<IsFirstOpen>k__BackingField");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_AllToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_AllToggles");
			DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentViewRoundIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, "m_CurrentViewRoundIndex");
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668714);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_Difficulty_Private_set_Void_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668715);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_PanelCloseContext_Public_get_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668716);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_PanelCloseContext_Private_set_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668717);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_IsFirstOpen_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668718);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_IsFirstOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668719);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668720);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_BackToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668721);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668722);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668723);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668724);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668725);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668726);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668727);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668728);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668729);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668730);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_Method_Private_Void_MoveDirection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668731);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_Method_Private_Void_Difficulty_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668732);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_7_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668733);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_8_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668734);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_9_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668735);
			DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr, 100668736);
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00104A28 File Offset: 0x00102C28
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x00104A64 File Offset: 0x00102C64
		public unsafe NightSceneDirector.Difficulty Difficulty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_Difficulty_Private_set_Void_Difficulty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00104AA4 File Offset: 0x00102CA4
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00104AE0 File Offset: 0x00102CE0
		public unsafe DLC5_RogueLikeNewGamePanel.CloseContext PanelCloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_PanelCloseContext_Public_get_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_PanelCloseContext_Private_set_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00104B20 File Offset: 0x00102D20
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x00104B5C File Offset: 0x00102D5C
		public unsafe bool IsFirstOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_get_IsFirstOpen_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_set_IsFirstOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00104B9C File Offset: 0x00102D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75818, XrefRangeEnd = 75921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00104BD8 File Offset: 0x00102DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75921, XrefRangeEnd = 75929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_BackToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00104C0C File Offset: 0x00102E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75929, XrefRangeEnd = 75937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00104C40 File Offset: 0x00102E40
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 75964, RefRangeEnd = 75973, XrefRangeStart = 75937, XrefRangeEnd = 75964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00104C74 File Offset: 0x00102E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75973, XrefRangeEnd = 75985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00104CB0 File Offset: 0x00102EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75985, XrefRangeEnd = 75988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeNewGamePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeNewGamePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00104CEC File Offset: 0x00102EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75988, XrefRangeEnd = 75997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_0(UIButtonToggle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00104D30 File Offset: 0x00102F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75997, XrefRangeEnd = 75998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00104D64 File Offset: 0x00102F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75998, XrefRangeEnd = 75999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00104D98 File Offset: 0x00102F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75999, XrefRangeEnd = 76000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00104DCC File Offset: 0x00102FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76000, XrefRangeEnd = 76001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00104E00 File Offset: 0x00103000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76001, XrefRangeEnd = 76006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_MoveDirection_PDM_0(MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_Method_Private_Void_MoveDirection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00104E40 File Offset: 0x00103040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76006, XrefRangeEnd = 76007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Difficulty_PDM_0(NightSceneDirector.Difficulty difficulty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difficulty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr_Method_Private_Void_Difficulty_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00104E80 File Offset: 0x00103080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76007, XrefRangeEnd = 76013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_7(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_7_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00104EC8 File Offset: 0x001030C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76013, XrefRangeEnd = 76017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_8(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_8_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00104F10 File Offset: 0x00103110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76017, XrefRangeEnd = 76019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_9(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_9_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00104F58 File Offset: 0x00103158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76019, XrefRangeEnd = 76022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeNewGamePanel.NativeMethodInfoPtr__OnPanelInitialize_b__24_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00012846 File Offset: 0x00010A46
		public DLC5_RogueLikeNewGamePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00104F8C File Offset: 0x0010318C
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0001284F File Offset: 0x00010A4F
		public unsafe TextMeshProUGUI m_CurrentDifficultyTargetText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentDifficultyTargetText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentDifficultyTargetText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00104FBC File Offset: 0x001031BC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0001286E File Offset: 0x00010A6E
		public unsafe TextMeshProUGUI m_CurrentIndexText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentIndexText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentIndexText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00104FEC File Offset: 0x001031EC
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0001288D File Offset: 0x00010A8D
		public unsafe UIButtonHold m_StartBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_StartBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_StartBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0010501C File Offset: 0x0010321C
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x000128AC File Offset: 0x00010AAC
		public unsafe UIButtonSimple m_PerviousBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_PerviousBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_PerviousBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0010504C File Offset: 0x0010324C
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x000128CB File Offset: 0x00010ACB
		public unsafe UIButtonSimple m_NextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_NextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_NextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0010507C File Offset: 0x0010327C
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x000128EA File Offset: 0x00010AEA
		public unsafe UIButtonToggle EasyBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_EasyBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_EasyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x001050AC File Offset: 0x001032AC
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00012909 File Offset: 0x00010B09
		public unsafe UIButtonToggle NormalBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_NormalBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_NormalBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x001050DC File Offset: 0x001032DC
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00012928 File Offset: 0x00010B28
		public unsafe UIButtonToggle HardBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_HardBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_HardBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0010510C File Offset: 0x0010330C
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00012947 File Offset: 0x00010B47
		public unsafe UIButtonToggle LunaticBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_LunaticBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_LunaticBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0010513C File Offset: 0x0010333C
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00012966 File Offset: 0x00010B66
		public unsafe NightSceneDirector.Difficulty _Difficulty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__Difficulty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__Difficulty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00105164 File Offset: 0x00103364
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00012981 File Offset: 0x00010B81
		public unsafe DLC5_RogueLikeNewGamePanel.CloseContext _PanelCloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__PanelCloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__PanelCloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x0010518C File Offset: 0x0010338C
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0001299C File Offset: 0x00010B9C
		public unsafe bool _IsFirstOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__IsFirstOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr__IsFirstOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x001051B4 File Offset: 0x001033B4
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x000129B7 File Offset: 0x00010BB7
		public unsafe Il2CppReferenceArray<UIButtonToggle> m_AllToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_AllToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_AllToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x001051E4 File Offset: 0x001033E4
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x000129D6 File Offset: 0x00010BD6
		public unsafe int m_CurrentViewRoundIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentViewRoundIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeNewGamePanel.NativeFieldInfoPtr_m_CurrentViewRoundIndex)) = value;
			}
		}

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDifficultyTargetText;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndexText;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_m_StartBtn;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_m_PerviousBtn;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_m_NextBtn;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeFieldInfoPtr_EasyBtn;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_NormalBtn;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_HardBtn;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_LunaticBtn;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr__Difficulty_k__BackingField;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr__PanelCloseContext_k__BackingField;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr__IsFirstOpen_k__BackingField;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr_m_AllToggles;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentViewRoundIndex;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_set_Difficulty_Private_set_Void_Difficulty_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelCloseContext_Public_get_CloseContext_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_set_PanelCloseContext_Private_set_Void_CloseContext_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFirstOpen_Private_get_Boolean_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFirstOpen_Public_set_Void_Boolean_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_BackToPrevious_Private_Void_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_UIButtonToggle_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Private_Void_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_2_Private_Void_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_3_Private_Void_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_4_Private_Void_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_MoveDirection_PDM_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Difficulty_PDM_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_7_Private_Void_CallbackContext_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_8_Private_Void_CallbackContext_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_9_Private_Void_CallbackContext_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_10_Private_Void_0;

		// Token: 0x020006F3 RID: 1779
		public enum CloseContext
		{
			// Token: 0x040064EA RID: 25834
			Back,
			// Token: 0x040064EB RID: 25835
			Start
		}
	}
}
