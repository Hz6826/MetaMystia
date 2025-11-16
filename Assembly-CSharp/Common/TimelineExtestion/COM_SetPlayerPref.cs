using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000407 RID: 1031
	public class COM_SetPlayerPref : PlayableAsset
	{
		// Token: 0x06007758 RID: 30552 RVA: 0x0022BBF8 File Offset: 0x00229DF8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SetPlayerPref()
		{
			Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SetPlayerPref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr);
			COM_SetPlayerPref.NativeFieldInfoPtr_playerPrefLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr, "playerPrefLabel");
			COM_SetPlayerPref.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr, 100687569);
			COM_SetPlayerPref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr, 100687570);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x0022BC64 File Offset: 0x00229E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293165, XrefRangeEnd = 293178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SetPlayerPref.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x0022BCCC File Offset: 0x00229ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SetPlayerPref() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SetPlayerPref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SetPlayerPref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00040874 File Offset: 0x0003EA74
		public COM_SetPlayerPref(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600775C RID: 30556 RVA: 0x0022BD08 File Offset: 0x00229F08
		// (set) Token: 0x0600775D RID: 30557 RVA: 0x0004087D File Offset: 0x0003EA7D
		public unsafe string playerPrefLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerPref.NativeFieldInfoPtr_playerPrefLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SetPlayerPref.NativeFieldInfoPtr_playerPrefLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004EDB RID: 20187
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefLabel;

		// Token: 0x04004EDC RID: 20188
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EDD RID: 20189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
