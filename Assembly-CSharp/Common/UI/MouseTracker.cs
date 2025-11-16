using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000352 RID: 850
	public class MouseTracker : MonoBehaviour
	{
		// Token: 0x06006474 RID: 25716 RVA: 0x001EDCD4 File Offset: 0x001EBED4
		// Note: this type is marked as 'beforefieldinit'.
		static MouseTracker()
		{
			Il2CppClassPointerStore<MouseTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "MouseTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr);
			MouseTracker.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, "visual");
			MouseTracker.NativeFieldInfoPtr_m_DependentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, "m_DependentCanvas");
			MouseTracker.NativeFieldInfoPtr_m_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, "m_MainCamera");
			MouseTracker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684366);
			MouseTracker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684367);
			MouseTracker.NativeMethodInfoPtr_OnPointActionOnPerformed_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684368);
			MouseTracker.NativeMethodInfoPtr_OnMouseInputStateChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684369);
			MouseTracker.NativeMethodInfoPtr_SetVisualAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684370);
			MouseTracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684371);
			MouseTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr, 100684372);
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x001EDDCC File Offset: 0x001EBFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258557, XrefRangeEnd = 258602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x001EDE00 File Offset: 0x001EC000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258602, XrefRangeEnd = 258637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x001EDE34 File Offset: 0x001EC034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258637, XrefRangeEnd = 258647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointActionOnPerformed(Vector2 mouseScreenPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mouseScreenPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr_OnPointActionOnPerformed_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x001EDE74 File Offset: 0x001EC074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258647, XrefRangeEnd = 258654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseInputStateChange(bool isMouse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isMouse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr_OnMouseInputStateChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x001EDEB4 File Offset: 0x001EC0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258654, XrefRangeEnd = 258661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr_SetVisualAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x001EDEF4 File Offset: 0x001EC0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseTracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x001EDF30 File Offset: 0x001EC130
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x000365E6 File Offset: 0x000347E6
		public MouseTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600647D RID: 25725 RVA: 0x001EDF6C File Offset: 0x001EC16C
		// (set) Token: 0x0600647E RID: 25726 RVA: 0x000365EF File Offset: 0x000347EF
		public unsafe Image visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x001EDF9C File Offset: 0x001EC19C
		// (set) Token: 0x06006480 RID: 25728 RVA: 0x0003660E File Offset: 0x0003480E
		public unsafe Canvas m_DependentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_m_DependentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_m_DependentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06006481 RID: 25729 RVA: 0x001EDFCC File Offset: 0x001EC1CC
		// (set) Token: 0x06006482 RID: 25730 RVA: 0x0003662D File Offset: 0x0003482D
		public unsafe Camera m_MainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_m_MainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTracker.NativeFieldInfoPtr_m_MainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeFieldInfoPtr_visual;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeFieldInfoPtr_m_DependentCanvas;

		// Token: 0x04004298 RID: 17048
		private static readonly IntPtr NativeFieldInfoPtr_m_MainCamera;

		// Token: 0x04004299 RID: 17049
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400429A RID: 17050
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400429B RID: 17051
		private static readonly IntPtr NativeMethodInfoPtr_OnPointActionOnPerformed_Private_Void_Vector2_0;

		// Token: 0x0400429C RID: 17052
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseInputStateChange_Private_Void_Boolean_0;

		// Token: 0x0400429D RID: 17053
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualAlpha_Private_Void_Single_0;

		// Token: 0x0400429E RID: 17054
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400429F RID: 17055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
