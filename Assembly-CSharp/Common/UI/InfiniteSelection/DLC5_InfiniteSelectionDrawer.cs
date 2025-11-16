using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x020003CA RID: 970
	public class DLC5_InfiniteSelectionDrawer : MonoBehaviour
	{
		// Token: 0x06007376 RID: 29558 RVA: 0x0021F90C File Offset: 0x0021DB0C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_InfiniteSelectionDrawer()
		{
			Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.InfiniteSelection", "DLC5_InfiniteSelectionDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr);
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_ValidGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "m_ValidGroup");
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_InValidGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "m_InValidGroup");
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_LightCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "m_LightCanvasGroup");
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "m_IngredientCanvasGroup");
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "m_IngredientIcon");
			DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr__Button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, "<Button>k__BackingField");
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_get_Button_Public_get_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687037);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_set_Button_Private_set_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687038);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687039);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_SetValid_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687040);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_UpdateVisual_Public_Void_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687041);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687042);
			DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr, 100687043);
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06007377 RID: 29559 RVA: 0x0021FA40 File Offset: 0x0021DC40
		// (set) Token: 0x06007378 RID: 29560 RVA: 0x0021FA80 File Offset: 0x0021DC80
		public unsafe UIButtonSimple Button
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_get_Button_Public_get_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_set_Button_Private_set_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x0021FAC4 File Offset: 0x0021DCC4
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x0021FAF8 File Offset: 0x0021DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287693, XrefRangeEnd = 287697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValid(bool isValid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_SetValid_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x0021FB38 File Offset: 0x0021DD38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287701, RefRangeEnd = 287704, XrefRangeStart = 287697, XrefRangeEnd = 287701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(Nullable<int> currentActiveIngredientId, bool noAnimation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentActiveIngredientId));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noAnimation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_UpdateVisual_Public_Void_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0021FB90 File Offset: 0x0021DD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0021FBCC File Offset: 0x0021DDCC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_InfiniteSelectionDrawer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteSelectionDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0003E6A3 File Offset: 0x0003C8A3
		public DLC5_InfiniteSelectionDrawer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600737F RID: 29567 RVA: 0x0021FC08 File Offset: 0x0021DE08
		// (set) Token: 0x06007380 RID: 29568 RVA: 0x0003E6AC File Offset: 0x0003C8AC
		public unsafe CanvasGroup m_ValidGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_ValidGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_ValidGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x0021FC38 File Offset: 0x0021DE38
		// (set) Token: 0x06007382 RID: 29570 RVA: 0x0003E6CB File Offset: 0x0003C8CB
		public unsafe CanvasGroup m_InValidGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_InValidGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_InValidGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06007383 RID: 29571 RVA: 0x0021FC68 File Offset: 0x0021DE68
		// (set) Token: 0x06007384 RID: 29572 RVA: 0x0003E6EA File Offset: 0x0003C8EA
		public unsafe CanvasGroup m_LightCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_LightCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_LightCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06007385 RID: 29573 RVA: 0x0021FC98 File Offset: 0x0021DE98
		// (set) Token: 0x06007386 RID: 29574 RVA: 0x0003E709 File Offset: 0x0003C909
		public unsafe CanvasGroup m_IngredientCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06007387 RID: 29575 RVA: 0x0021FCC8 File Offset: 0x0021DEC8
		// (set) Token: 0x06007388 RID: 29576 RVA: 0x0003E728 File Offset: 0x0003C928
		public unsafe Image m_IngredientIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr_m_IngredientIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06007389 RID: 29577 RVA: 0x0021FCF8 File Offset: 0x0021DEF8
		// (set) Token: 0x0600738A RID: 29578 RVA: 0x0003E747 File Offset: 0x0003C947
		public unsafe UIButtonSimple _Button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr__Button_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionDrawer.NativeFieldInfoPtr__Button_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C8A RID: 19594
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidGroup;

		// Token: 0x04004C8B RID: 19595
		private static readonly IntPtr NativeFieldInfoPtr_m_InValidGroup;

		// Token: 0x04004C8C RID: 19596
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCanvasGroup;

		// Token: 0x04004C8D RID: 19597
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientCanvasGroup;

		// Token: 0x04004C8E RID: 19598
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientIcon;

		// Token: 0x04004C8F RID: 19599
		private static readonly IntPtr NativeFieldInfoPtr__Button_k__BackingField;

		// Token: 0x04004C90 RID: 19600
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_UIButtonSimple_0;

		// Token: 0x04004C91 RID: 19601
		private static readonly IntPtr NativeMethodInfoPtr_set_Button_Private_set_Void_UIButtonSimple_0;

		// Token: 0x04004C92 RID: 19602
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004C93 RID: 19603
		private static readonly IntPtr NativeMethodInfoPtr_SetValid_Public_Void_Boolean_0;

		// Token: 0x04004C94 RID: 19604
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Public_Void_Nullable_1_Int32_Boolean_0;

		// Token: 0x04004C95 RID: 19605
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004C96 RID: 19606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
