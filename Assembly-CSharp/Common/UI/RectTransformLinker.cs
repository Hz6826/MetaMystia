using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Common.UI
{
	// Token: 0x02000355 RID: 853
	public class RectTransformLinker : UIBehaviour
	{
		// Token: 0x06006490 RID: 25744 RVA: 0x001EE3B4 File Offset: 0x001EC5B4
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformLinker()
		{
			Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "RectTransformLinker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr);
			RectTransformLinker.NativeFieldInfoPtr_m_TargetRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, "m_TargetRectTransform");
			RectTransformLinker.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, "m_Padding");
			RectTransformLinker.NativeFieldInfoPtr_m_MaximumRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, "m_MaximumRectTransform");
			RectTransformLinker.NativeFieldInfoPtr_m_ApplyRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, "m_ApplyRequested");
			RectTransformLinker.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684380);
			RectTransformLinker.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684381);
			RectTransformLinker.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684382);
			RectTransformLinker.NativeMethodInfoPtr_Apply_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684383);
			RectTransformLinker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684384);
			RectTransformLinker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr, 100684385);
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x001EE4AC File Offset: 0x001EC6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258796, XrefRangeEnd = 258797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLinker.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x001EE4E0 File Offset: 0x001EC6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258797, RefRangeEnd = 258798, XrefRangeStart = 258797, XrefRangeEnd = 258797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformLinker.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x001EE51C File Offset: 0x001EC71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258798, XrefRangeEnd = 258800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformLinker.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x001EE558 File Offset: 0x001EC758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258827, RefRangeEnd = 258829, XrefRangeStart = 258800, XrefRangeEnd = 258827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLinker.NativeMethodInfoPtr_Apply_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x001EE58C File Offset: 0x001EC78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformLinker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x001EE5C8 File Offset: 0x001EC7C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransformLinker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransformLinker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLinker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x0003667D File Offset: 0x0003487D
		public RectTransformLinker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06006498 RID: 25752 RVA: 0x001EE604 File Offset: 0x001EC804
		// (set) Token: 0x06006499 RID: 25753 RVA: 0x00036686 File Offset: 0x00034886
		public unsafe RectTransform m_TargetRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_TargetRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_TargetRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600649A RID: 25754 RVA: 0x001EE634 File Offset: 0x001EC834
		// (set) Token: 0x0600649B RID: 25755 RVA: 0x000366A5 File Offset: 0x000348A5
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x001EE664 File Offset: 0x001EC864
		// (set) Token: 0x0600649D RID: 25757 RVA: 0x000366C4 File Offset: 0x000348C4
		public unsafe RectTransform m_MaximumRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_MaximumRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_MaximumRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600649E RID: 25758 RVA: 0x001EE694 File Offset: 0x001EC894
		// (set) Token: 0x0600649F RID: 25759 RVA: 0x000366E3 File Offset: 0x000348E3
		public unsafe bool m_ApplyRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_ApplyRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLinker.NativeFieldInfoPtr_m_ApplyRequested)) = value;
			}
		}

		// Token: 0x040042A8 RID: 17064
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetRectTransform;

		// Token: 0x040042A9 RID: 17065
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040042AA RID: 17066
		private static readonly IntPtr NativeFieldInfoPtr_m_MaximumRectTransform;

		// Token: 0x040042AB RID: 17067
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyRequested;

		// Token: 0x040042AC RID: 17068
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040042AD RID: 17069
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040042AE RID: 17070
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040042AF RID: 17071
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_0;

		// Token: 0x040042B0 RID: 17072
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040042B1 RID: 17073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
