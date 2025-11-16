using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace StaffScene
{
	// Token: 0x02000035 RID: 53
	public class FlexibleCGElement : MonoBehaviour
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x000AFB3C File Offset: 0x000ADD3C
		// Note: this type is marked as 'beforefieldinit'.
		static FlexibleCGElement()
		{
			Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StaffScene", "FlexibleCGElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr);
			FlexibleCGElement.NativeFieldInfoPtr_unlockedEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, "unlockedEventLabel");
			FlexibleCGElement.NativeFieldInfoPtr_flexibleElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, "flexibleElements");
			FlexibleCGElement.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, "page");
			FlexibleCGElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, 100664037);
			FlexibleCGElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, 100664038);
			FlexibleCGElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, 100664039);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000AFBE4 File Offset: 0x000ADDE4
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexibleCGElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000AFC18 File Offset: 0x000ADE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24513, XrefRangeEnd = 24516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexibleCGElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000AFC54 File Offset: 0x000ADE54
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlexibleCGElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexibleCGElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000051C3 File Offset: 0x000033C3
		public FlexibleCGElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x000AFC90 File Offset: 0x000ADE90
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x000051CC File Offset: 0x000033CC
		public unsafe string unlockedEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_unlockedEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_unlockedEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x000AFCB8 File Offset: 0x000ADEB8
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x000051EB File Offset: 0x000033EB
		public unsafe Il2CppReferenceArray<FlexibleCGElement.FlexibleElement> flexibleElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_flexibleElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlexibleCGElement.FlexibleElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_flexibleElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000AFCE8 File Offset: 0x000ADEE8
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0000520A File Offset: 0x0000340A
		public unsafe CanvasGroup page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_page);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_unlockedEventLabel;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_flexibleElements;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004B0 RID: 1200
		[Serializable]
		public sealed class FlexibleElement : ValueType
		{
			// Token: 0x06007EEA RID: 32490 RVA: 0x00241FC8 File Offset: 0x002401C8
			// Note: this type is marked as 'beforefieldinit'.
			static FlexibleElement()
			{
				Il2CppClassPointerStore<FlexibleCGElement.FlexibleElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlexibleCGElement>.NativeClassPtr, "FlexibleElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlexibleCGElement.FlexibleElement>.NativeClassPtr);
				FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleCGElement.FlexibleElement>.NativeClassPtr, "npcName");
				FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleCGElement.FlexibleElement>.NativeClassPtr, "visual");
			}

			// Token: 0x06007EEB RID: 32491 RVA: 0x00044436 File Offset: 0x00042636
			public FlexibleElement(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007EEC RID: 32492 RVA: 0x0004443F File Offset: 0x0004263F
			public FlexibleElement() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlexibleCGElement.FlexibleElement>.NativeClassPtr))
			{
			}

			// Token: 0x17002AD5 RID: 10965
			// (get) Token: 0x06007EED RID: 32493 RVA: 0x0024201C File Offset: 0x0024021C
			// (set) Token: 0x06007EEE RID: 32494 RVA: 0x00044451 File Offset: 0x00042651
			public unsafe string npcName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_npcName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_npcName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002AD6 RID: 10966
			// (get) Token: 0x06007EEF RID: 32495 RVA: 0x00242044 File Offset: 0x00240244
			// (set) Token: 0x06007EF0 RID: 32496 RVA: 0x00044470 File Offset: 0x00042670
			public unsafe GameObject visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexibleCGElement.FlexibleElement.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005371 RID: 21361
			private static readonly IntPtr NativeFieldInfoPtr_npcName;

			// Token: 0x04005372 RID: 21362
			private static readonly IntPtr NativeFieldInfoPtr_visual;
		}
	}
}
