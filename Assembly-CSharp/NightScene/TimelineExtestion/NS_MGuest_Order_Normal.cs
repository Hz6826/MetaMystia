using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000204 RID: 516
	public class NS_MGuest_Order_Normal : PlayableAsset
	{
		// Token: 0x06003D4B RID: 15691 RVA: 0x0016E57C File Offset: 0x0016C77C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_Order_Normal()
		{
			Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_Order_Normal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr);
			NS_MGuest_Order_Normal.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr, "label");
			NS_MGuest_Order_Normal.NativeFieldInfoPtr_foodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr, "foodId");
			NS_MGuest_Order_Normal.NativeFieldInfoPtr_bevId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr, "bevId");
			NS_MGuest_Order_Normal.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr, 100674562);
			NS_MGuest_Order_Normal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr, 100674563);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x0016E610 File Offset: 0x0016C810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137170, XrefRangeEnd = 137187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_Order_Normal.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x0016E678 File Offset: 0x0016C878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_Order_Normal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_Order_Normal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Normal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x000224C4 File Offset: 0x000206C4
		public NS_MGuest_Order_Normal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x0016E6B4 File Offset: 0x0016C8B4
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x000224CD File Offset: 0x000206CD
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x0016E6DC File Offset: 0x0016C8DC
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x000224EC File Offset: 0x000206EC
		public unsafe int foodId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_foodId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_foodId)) = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x0016E704 File Offset: 0x0016C904
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00022507 File Offset: 0x00020707
		public unsafe int bevId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_bevId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Normal.NativeFieldInfoPtr_bevId)) = value;
			}
		}

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeFieldInfoPtr_foodId;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeFieldInfoPtr_bevId;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
