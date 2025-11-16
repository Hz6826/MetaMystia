using System;
using Common.UI.GlobalMap;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000124 RID: 292
	public class DLC5_RogueLikeSpotSelectionPanelEliteTipPanel : UIPanelParamOpen<IGuideMapSpot>
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x0010D86C File Offset: 0x0010BA6C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeSpotSelectionPanelEliteTipPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeSpotSelectionPanelEliteTipPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr);
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_MaskRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, "m_MaskRect");
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_TextRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, "m_TextRect");
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, "m_Text");
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_StartAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, "m_StartAnim");
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, "DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE");
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, 100669296);
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, 100669297);
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, 100669298);
			DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr, 100669299);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0010D950 File Offset: 0x0010BB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82037, XrefRangeEnd = 82087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(IGuideMapSpot openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0010D9A0 File Offset: 0x0010BBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82087, XrefRangeEnd = 82092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0010D9DC File Offset: 0x0010BBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82092, XrefRangeEnd = 82095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeSpotSelectionPanelEliteTipPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0010DA18 File Offset: 0x0010BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82095, XrefRangeEnd = 82104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000146FA File Offset: 0x000128FA
		public DLC5_RogueLikeSpotSelectionPanelEliteTipPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x0010DA4C File Offset: 0x0010BC4C
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00014703 File Offset: 0x00012903
		public unsafe RectTransform m_MaskRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_MaskRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_MaskRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x0010DA7C File Offset: 0x0010BC7C
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00014722 File Offset: 0x00012922
		public unsafe RectTransform m_TextRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_TextRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_TextRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x0010DAAC File Offset: 0x0010BCAC
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00014741 File Offset: 0x00012941
		public unsafe TextMeshProUGUI m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x0010DADC File Offset: 0x0010BCDC
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x00014760 File Offset: 0x00012960
		public unsafe Animator m_StartAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_StartAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_m_StartAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0010DB0C File Offset: 0x0010BD0C
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x0001477F File Offset: 0x0001297F
		public unsafe static string DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel.NativeFieldInfoPtr_DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskRect;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr_m_TextRect;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAnim;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0;
	}
}
