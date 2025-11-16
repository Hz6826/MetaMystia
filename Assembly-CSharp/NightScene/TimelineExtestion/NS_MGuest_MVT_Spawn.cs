using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000202 RID: 514
	public class NS_MGuest_MVT_Spawn : PlayableAsset
	{
		// Token: 0x06003D35 RID: 15669 RVA: 0x0016E1E0 File Offset: 0x0016C3E0
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_Spawn()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_Spawn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr);
			NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_specialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr, "specialGuestId");
			NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr, "label");
			NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_spawnInA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr, "spawnInA");
			NS_MGuest_MVT_Spawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr, 100674558);
			NS_MGuest_MVT_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr, 100674559);
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0016E274 File Offset: 0x0016C474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137134, XrefRangeEnd = 137151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_Spawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x0016E2DC File Offset: 0x0016C4DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_Spawn() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000223ED File Offset: 0x000205ED
		public NS_MGuest_MVT_Spawn(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x0016E318 File Offset: 0x0016C518
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x000223F6 File Offset: 0x000205F6
		public unsafe int specialGuestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_specialGuestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_specialGuestId)) = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x0016E340 File Offset: 0x0016C540
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x00022411 File Offset: 0x00020611
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x0016E368 File Offset: 0x0016C568
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x00022430 File Offset: 0x00020630
		public unsafe bool spawnInA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_spawnInA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn.NativeFieldInfoPtr_spawnInA)) = value;
			}
		}

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestId;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeFieldInfoPtr_spawnInA;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
