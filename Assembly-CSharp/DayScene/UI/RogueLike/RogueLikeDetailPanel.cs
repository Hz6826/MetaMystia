using System;
using Common.UI.Extensions;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000132 RID: 306
	public class RogueLikeDetailPanel : UIPanelParamOpen<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>
	{
		// Token: 0x060023BD RID: 9149 RVA: 0x00115E18 File Offset: 0x00114018
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeDetailPanel()
		{
			Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr);
			RogueLikeDetailPanel.NativeFieldInfoPtr_m_DescriberExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, "m_DescriberExtended");
			RogueLikeDetailPanel.NativeFieldInfoPtr_m_ScrollRectComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, "m_ScrollRectComponent");
			RogueLikeDetailPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669671);
			RogueLikeDetailPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669672);
			RogueLikeDetailPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669673);
			RogueLikeDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669674);
			RogueLikeDetailPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669675);
			RogueLikeDetailPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr, 100669676);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00115EE8 File Offset: 0x001140E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85082, XrefRangeEnd = 85112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDetailPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00115F1C File Offset: 0x0011411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85112, XrefRangeEnd = 85121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeDetailPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00115F70 File Offset: 0x00114170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85121, XrefRangeEnd = 85124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeDetailPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00115FAC File Offset: 0x001141AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85124, XrefRangeEnd = 85127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00115FE8 File Offset: 0x001141E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85127, XrefRangeEnd = 85131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__2_0(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDetailPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00116030 File Offset: 0x00114230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85131, XrefRangeEnd = 85135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__2_1(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDetailPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000155F4 File Offset: 0x000137F4
		public RogueLikeDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x00116078 File Offset: 0x00114278
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x000155FD File Offset: 0x000137FD
		public unsafe DLC5_RogueLikeMapDescriberExtended m_DescriberExtended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDetailPanel.NativeFieldInfoPtr_m_DescriberExtended);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMapDescriberExtended>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDetailPanel.NativeFieldInfoPtr_m_DescriberExtended), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x001160A8 File Offset: 0x001142A8
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0001561C File Offset: 0x0001381C
		public unsafe ScrollRectComponent m_ScrollRectComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDetailPanel.NativeFieldInfoPtr_m_ScrollRectComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRectComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDetailPanel.NativeFieldInfoPtr_m_ScrollRectComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberExtended;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollRectComponent;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_CallbackContext_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_CallbackContext_0;
	}
}
