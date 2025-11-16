using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FA RID: 506
	public class NS_AMGuest_Spawn : PlayableAsset
	{
		// Token: 0x06003D03 RID: 15619 RVA: 0x0016D7D4 File Offset: 0x0016B9D4
		// Note: this type is marked as 'beforefieldinit'.
		static NS_AMGuest_Spawn()
		{
			Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_AMGuest_Spawn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr);
			NS_AMGuest_Spawn.NativeFieldInfoPtr_specialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr, "specialGuestId");
			NS_AMGuest_Spawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr, 100674542);
			NS_AMGuest_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr, 100674543);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0016D840 File Offset: 0x0016BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137034, XrefRangeEnd = 137046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_AMGuest_Spawn.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0016D8A8 File Offset: 0x0016BAA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_AMGuest_Spawn() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_AMGuest_Spawn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_AMGuest_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x000222A6 File Offset: 0x000204A6
		public NS_AMGuest_Spawn(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0016D8E4 File Offset: 0x0016BAE4
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x000222AF File Offset: 0x000204AF
		public unsafe int specialGuestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_AMGuest_Spawn.NativeFieldInfoPtr_specialGuestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_AMGuest_Spawn.NativeFieldInfoPtr_specialGuestId)) = value;
			}
		}

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestId;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
