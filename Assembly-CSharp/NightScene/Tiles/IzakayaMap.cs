using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x020001B0 RID: 432
	public class IzakayaMap : MonoBehaviour
	{
		// Token: 0x06003423 RID: 13347 RVA: 0x001519FC File Offset: 0x0014FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaMap()
		{
			Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.Tiles", "IzakayaMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr);
			IzakayaMap.NativeFieldInfoPtr_referenceGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "referenceGrid");
			IzakayaMap.NativeFieldInfoPtr_additionalCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "additionalCollision");
			IzakayaMap.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "interactable");
			IzakayaMap.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "height");
			IzakayaMap.NativeFieldInfoPtr_decoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "decoration");
			IzakayaMap.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "space");
			IzakayaMap.NativeFieldInfoPtr_rayCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, "rayCollider");
			IzakayaMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, 100673282);
			IzakayaMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr, 100673283);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00151AE0 File Offset: 0x0014FCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00151B1C File Offset: 0x0014FD1C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0001CFD9 File Offset: 0x0001B1D9
		public IzakayaMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x00151B58 File Offset: 0x0014FD58
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x0001CFE2 File Offset: 0x0001B1E2
		public unsafe Grid referenceGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_referenceGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_referenceGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00151B88 File Offset: 0x0014FD88
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x0001D001 File Offset: 0x0001B201
		public unsafe Tilemap additionalCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_additionalCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_additionalCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x00151BB8 File Offset: 0x0014FDB8
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x0001D020 File Offset: 0x0001B220
		public unsafe Tilemap interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x00151BE8 File Offset: 0x0014FDE8
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x0001D03F File Offset: 0x0001B23F
		public unsafe Tilemap height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_height);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_height), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x00151C18 File Offset: 0x0014FE18
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x0001D05E File Offset: 0x0001B25E
		public unsafe Tilemap decoration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_decoration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_decoration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x00151C48 File Offset: 0x0014FE48
		// (set) Token: 0x06003432 RID: 13362 RVA: 0x0001D07D File Offset: 0x0001B27D
		public unsafe Tilemap space
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_space);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x00151C78 File Offset: 0x0014FE78
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x0001D09C File Offset: 0x0001B29C
		public unsafe Tilemap rayCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_rayCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaMap.NativeFieldInfoPtr_rayCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeFieldInfoPtr_referenceGrid;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeFieldInfoPtr_additionalCollision;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeFieldInfoPtr_decoration;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeFieldInfoPtr_space;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeFieldInfoPtr_rayCollider;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
