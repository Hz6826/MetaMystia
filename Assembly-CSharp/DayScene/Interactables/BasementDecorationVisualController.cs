using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x0200015E RID: 350
	public class BasementDecorationVisualController : MonoBehaviour
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x00122D80 File Offset: 0x00120F80
		// Note: this type is marked as 'beforefieldinit'.
		static BasementDecorationVisualController()
		{
			Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables", "BasementDecorationVisualController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr);
			BasementDecorationVisualController.NativeFieldInfoPtr__itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, "_itemId");
			BasementDecorationVisualController.NativeFieldInfoPtr__renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, "_renderer");
			BasementDecorationVisualController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, 100670303);
			BasementDecorationVisualController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, 100670304);
			BasementDecorationVisualController.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, 100670305);
			BasementDecorationVisualController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr, 100670306);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00122E28 File Offset: 0x00121028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91544, XrefRangeEnd = 91566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasementDecorationVisualController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00122E5C File Offset: 0x0012105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91566, XrefRangeEnd = 91582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasementDecorationVisualController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00122E90 File Offset: 0x00121090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91582, XrefRangeEnd = 91585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasementDecorationVisualController.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00122EC4 File Offset: 0x001210C4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasementDecorationVisualController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasementDecorationVisualController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasementDecorationVisualController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000176F0 File Offset: 0x000158F0
		public BasementDecorationVisualController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00122F00 File Offset: 0x00121100
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x000176F9 File Offset: 0x000158F9
		public unsafe int _itemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasementDecorationVisualController.NativeFieldInfoPtr__itemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasementDecorationVisualController.NativeFieldInfoPtr__itemId)) = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00122F28 File Offset: 0x00121128
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00017714 File Offset: 0x00015914
		public unsafe SpriteRenderer _renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasementDecorationVisualController.NativeFieldInfoPtr__renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasementDecorationVisualController.NativeFieldInfoPtr__renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeFieldInfoPtr__itemId;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeFieldInfoPtr__renderer;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
