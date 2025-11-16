using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000205 RID: 517
	public class NS_MGuest_Order_Special : PlayableAsset
	{
		// Token: 0x06003D55 RID: 15701 RVA: 0x0016E72C File Offset: 0x0016C92C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_Order_Special()
		{
			Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_Order_Special");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr);
			NS_MGuest_Order_Special.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr, "label");
			NS_MGuest_Order_Special.NativeFieldInfoPtr_foodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr, "foodTag");
			NS_MGuest_Order_Special.NativeFieldInfoPtr_bevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr, "bevTag");
			NS_MGuest_Order_Special.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr, 100674564);
			NS_MGuest_Order_Special.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr, 100674565);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0016E7C0 File Offset: 0x0016C9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137187, XrefRangeEnd = 137204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_Order_Special.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x0016E828 File Offset: 0x0016CA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_Order_Special() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_Order_Special>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_Order_Special.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00022522 File Offset: 0x00020722
		public NS_MGuest_Order_Special(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x0016E864 File Offset: 0x0016CA64
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x0002252B File Offset: 0x0002072B
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x0016E88C File Offset: 0x0016CA8C
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x0002254A File Offset: 0x0002074A
		public unsafe int foodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_foodTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_foodTag)) = value;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x0016E8B4 File Offset: 0x0016CAB4
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00022565 File Offset: 0x00020765
		public unsafe int bevTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_bevTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_Order_Special.NativeFieldInfoPtr_bevTag)) = value;
			}
		}

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeFieldInfoPtr_foodTag;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeFieldInfoPtr_bevTag;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
