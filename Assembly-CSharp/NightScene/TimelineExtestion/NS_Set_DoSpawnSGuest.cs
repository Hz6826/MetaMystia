using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000214 RID: 532
	public class NS_Set_DoSpawnSGuest : PlayableAsset
	{
		// Token: 0x06003DB9 RID: 15801 RVA: 0x0016FAB0 File Offset: 0x0016DCB0
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoSpawnSGuest()
		{
			Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoSpawnSGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr);
			NS_Set_DoSpawnSGuest.NativeFieldInfoPtr_shouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr, "shouldSpawn");
			NS_Set_DoSpawnSGuest.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr, 100674594);
			NS_Set_DoSpawnSGuest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr, 100674595);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x0016FB1C File Offset: 0x0016DD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137380, XrefRangeEnd = 137392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoSpawnSGuest.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x0016FB84 File Offset: 0x0016DD84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoSpawnSGuest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoSpawnSGuest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x000227E5 File Offset: 0x000209E5
		public NS_Set_DoSpawnSGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x0016FBC0 File Offset: 0x0016DDC0
		// (set) Token: 0x06003DBE RID: 15806 RVA: 0x000227EE File Offset: 0x000209EE
		public unsafe bool shouldSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnSGuest.NativeFieldInfoPtr_shouldSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnSGuest.NativeFieldInfoPtr_shouldSpawn)) = value;
			}
		}

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeFieldInfoPtr_shouldSpawn;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
