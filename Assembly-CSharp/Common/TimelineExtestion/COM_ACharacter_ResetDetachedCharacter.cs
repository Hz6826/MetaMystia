using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E3 RID: 995
	public class COM_ACharacter_ResetDetachedCharacter : PlayableAsset
	{
		// Token: 0x06007644 RID: 30276 RVA: 0x002288D0 File Offset: 0x00226AD0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_ResetDetachedCharacter()
		{
			Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_ResetDetachedCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr);
			COM_ACharacter_ResetDetachedCharacter.NativeFieldInfoPtr_detachedCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr, "detachedCharacterLabel");
			COM_ACharacter_ResetDetachedCharacter.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr, 100687497);
			COM_ACharacter_ResetDetachedCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr, 100687498);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x0022893C File Offset: 0x00226B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292673, XrefRangeEnd = 292686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_ResetDetachedCharacter.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x002289A4 File Offset: 0x00226BA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_ResetDetachedCharacter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ResetDetachedCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetDetachedCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x0003FFE2 File Offset: 0x0003E1E2
		public COM_ACharacter_ResetDetachedCharacter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x002289E0 File Offset: 0x00226BE0
		// (set) Token: 0x06007649 RID: 30281 RVA: 0x0003FFEB File Offset: 0x0003E1EB
		public unsafe string detachedCharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetDetachedCharacter.NativeFieldInfoPtr_detachedCharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetDetachedCharacter.NativeFieldInfoPtr_detachedCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004E51 RID: 20049
		private static readonly IntPtr NativeFieldInfoPtr_detachedCharacterLabel;

		// Token: 0x04004E52 RID: 20050
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E53 RID: 20051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
