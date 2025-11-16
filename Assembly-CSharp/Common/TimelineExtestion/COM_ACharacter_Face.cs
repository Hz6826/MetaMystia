using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003DF RID: 991
	public class COM_ACharacter_Face : PlayableAsset
	{
		// Token: 0x0600761A RID: 30234 RVA: 0x002281CC File Offset: 0x002263CC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Face()
		{
			Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Face");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr);
			COM_ACharacter_Face.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr, "label");
			COM_ACharacter_Face.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr, "faceID");
			COM_ACharacter_Face.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr, 100687489);
			COM_ACharacter_Face.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr, 100687490);
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x0022824C File Offset: 0x0022644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292600, XrefRangeEnd = 292615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Face.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x002282B4 File Offset: 0x002264B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Face() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Face>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Face.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x0003FE4F File Offset: 0x0003E04F
		public COM_ACharacter_Face(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x002282F0 File Offset: 0x002264F0
		// (set) Token: 0x0600761F RID: 30239 RVA: 0x0003FE58 File Offset: 0x0003E058
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x00228318 File Offset: 0x00226518
		// (set) Token: 0x06007621 RID: 30241 RVA: 0x0003FE77 File Offset: 0x0003E077
		public unsafe COM_ACharacter_Face_Behaviour.FaceID faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x04004E3C RID: 20028
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E3D RID: 20029
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x04004E3E RID: 20030
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
