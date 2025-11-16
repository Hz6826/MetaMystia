using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000213 RID: 531
	public class NS_Set_DoSpawnNGuest : PlayableAsset
	{
		// Token: 0x06003DB3 RID: 15795 RVA: 0x0016F978 File Offset: 0x0016DB78
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoSpawnNGuest()
		{
			Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoSpawnNGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr);
			NS_Set_DoSpawnNGuest.NativeFieldInfoPtr_shouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr, "shouldSpawn");
			NS_Set_DoSpawnNGuest.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr, 100674592);
			NS_Set_DoSpawnNGuest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr, 100674593);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x0016F9E4 File Offset: 0x0016DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137368, XrefRangeEnd = 137380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoSpawnNGuest.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x0016FA4C File Offset: 0x0016DC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoSpawnNGuest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoSpawnNGuest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x000227C1 File Offset: 0x000209C1
		public NS_Set_DoSpawnNGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x0016FA88 File Offset: 0x0016DC88
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x000227CA File Offset: 0x000209CA
		public unsafe bool shouldSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnNGuest.NativeFieldInfoPtr_shouldSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnNGuest.NativeFieldInfoPtr_shouldSpawn)) = value;
			}
		}

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeFieldInfoPtr_shouldSpawn;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
