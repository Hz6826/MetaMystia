using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Common
{
	// Token: 0x0200033A RID: 826
	public class VisualizeAllTilePositions : MonoBehaviour
	{
		// Token: 0x06006276 RID: 25206 RVA: 0x001E78E4 File Offset: 0x001E5AE4
		// Note: this type is marked as 'beforefieldinit'.
		static VisualizeAllTilePositions()
		{
			Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "VisualizeAllTilePositions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr);
			VisualizeAllTilePositions.NativeFieldInfoPtr_tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, "tilemap");
			VisualizeAllTilePositions.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, "offset");
			VisualizeAllTilePositions.NativeFieldInfoPtr_allTilePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, "allTilePositions");
			VisualizeAllTilePositions.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, "style");
			VisualizeAllTilePositions.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684029);
			VisualizeAllTilePositions.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684030);
			VisualizeAllTilePositions.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684031);
			VisualizeAllTilePositions.NativeMethodInfoPtr_UpdateAllTilePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684032);
			VisualizeAllTilePositions.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684033);
			VisualizeAllTilePositions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr, 100684034);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x001E79DC File Offset: 0x001E5BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255063, XrefRangeEnd = 255064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualizeAllTilePositions.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x001E7A10 File Offset: 0x001E5C10
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualizeAllTilePositions.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x001E7A44 File Offset: 0x001E5C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualizeAllTilePositions.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x001E7A78 File Offset: 0x001E5C78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255091, RefRangeEnd = 255093, XrefRangeStart = 255064, XrefRangeEnd = 255091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAllTilePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualizeAllTilePositions.NativeMethodInfoPtr_UpdateAllTilePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x001E7AAC File Offset: 0x001E5CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualizeAllTilePositions.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x001E7AE8 File Offset: 0x001E5CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255093, XrefRangeEnd = 255102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualizeAllTilePositions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualizeAllTilePositions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualizeAllTilePositions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x00035374 File Offset: 0x00033574
		public VisualizeAllTilePositions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600627E RID: 25214 RVA: 0x001E7B24 File Offset: 0x001E5D24
		// (set) Token: 0x0600627F RID: 25215 RVA: 0x0003537D File Offset: 0x0003357D
		public unsafe Tilemap tilemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_tilemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_tilemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x001E7B54 File Offset: 0x001E5D54
		// (set) Token: 0x06006281 RID: 25217 RVA: 0x0003539C File Offset: 0x0003359C
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06006282 RID: 25218 RVA: 0x001E7B7C File Offset: 0x001E5D7C
		// (set) Token: 0x06006283 RID: 25219 RVA: 0x000353B7 File Offset: 0x000335B7
		public unsafe HashSet<Vector2> allTilePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_allTilePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_allTilePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x001E7BAC File Offset: 0x001E5DAC
		// (set) Token: 0x06006285 RID: 25221 RVA: 0x000353D6 File Offset: 0x000335D6
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualizeAllTilePositions.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeFieldInfoPtr_tilemap;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeFieldInfoPtr_allTilePositions;

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllTilePositions_Private_Void_0;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
