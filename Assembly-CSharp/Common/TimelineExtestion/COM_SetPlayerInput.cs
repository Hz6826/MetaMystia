using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000406 RID: 1030
	public class COM_SetPlayerInput : PlayableAsset
	{
		// Token: 0x06007752 RID: 30546 RVA: 0x0022BAC0 File Offset: 0x00229CC0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SetPlayerInput()
		{
			Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SetPlayerInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr);
			COM_SetPlayerInput.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr, "enabled");
			COM_SetPlayerInput.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr, 100687567);
			COM_SetPlayerInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr, 100687568);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x0022BB2C File Offset: 0x00229D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293153, XrefRangeEnd = 293165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SetPlayerInput.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x0022BB94 File Offset: 0x00229D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SetPlayerInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SetPlayerInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SetPlayerInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00040850 File Offset: 0x0003EA50
		public COM_SetPlayerInput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x0022BBD0 File Offset: 0x00229DD0
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x00040859 File Offset: 0x0003EA59
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerInput.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerInput.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x04004ED8 RID: 20184
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04004ED9 RID: 20185
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EDA RID: 20186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
