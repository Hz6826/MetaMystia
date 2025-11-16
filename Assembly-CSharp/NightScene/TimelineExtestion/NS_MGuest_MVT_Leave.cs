using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000201 RID: 513
	public class NS_MGuest_MVT_Leave : PlayableAsset
	{
		// Token: 0x06003D2D RID: 15661 RVA: 0x0016E06C File Offset: 0x0016C26C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_Leave()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_Leave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr);
			NS_MGuest_MVT_Leave.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr, "label");
			NS_MGuest_MVT_Leave.NativeFieldInfoPtr_shouldLeaveInstantly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr, "shouldLeaveInstantly");
			NS_MGuest_MVT_Leave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr, 100674556);
			NS_MGuest_MVT_Leave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr, 100674557);
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x0016E0EC File Offset: 0x0016C2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137118, XrefRangeEnd = 137133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_Leave.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0016E154 File Offset: 0x0016C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137133, XrefRangeEnd = 137134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_Leave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_Leave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_Leave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x000223AA File Offset: 0x000205AA
		public NS_MGuest_MVT_Leave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x0016E190 File Offset: 0x0016C390
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x000223B3 File Offset: 0x000205B3
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x0016E1B8 File Offset: 0x0016C3B8
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x000223D2 File Offset: 0x000205D2
		public unsafe bool shouldLeaveInstantly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave.NativeFieldInfoPtr_shouldLeaveInstantly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Leave.NativeFieldInfoPtr_shouldLeaveInstantly)) = value;
			}
		}

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeFieldInfoPtr_shouldLeaveInstantly;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
