using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E6 RID: 998
	public class COM_ACharacter_SetClothes : PlayableAsset
	{
		// Token: 0x0600765C RID: 30300 RVA: 0x00228D2C File Offset: 0x00226F2C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SetClothes()
		{
			Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SetClothes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr);
			COM_ACharacter_SetClothes.NativeFieldInfoPtr_clothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr, "clothesId");
			COM_ACharacter_SetClothes.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr, 100687503);
			COM_ACharacter_SetClothes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr, 100687504);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00228D98 File Offset: 0x00226F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292718, XrefRangeEnd = 292730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SetClothes.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00228E00 File Offset: 0x00227000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SetClothes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SetClothes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x000400AB File Offset: 0x0003E2AB
		public COM_ACharacter_SetClothes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x00228E3C File Offset: 0x0022703C
		// (set) Token: 0x06007661 RID: 30305 RVA: 0x000400B4 File Offset: 0x0003E2B4
		public unsafe int clothesId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes.NativeFieldInfoPtr_clothesId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes.NativeFieldInfoPtr_clothesId)) = value;
			}
		}

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeFieldInfoPtr_clothesId;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
