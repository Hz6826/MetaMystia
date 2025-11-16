using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E4 RID: 996
	public class COM_ACharacter_Rotate : PlayableAsset
	{
		// Token: 0x0600764A RID: 30282 RVA: 0x00228A08 File Offset: 0x00226C08
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Rotate()
		{
			Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Rotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr);
			COM_ACharacter_Rotate.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr, "label");
			COM_ACharacter_Rotate.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr, "targetRotation");
			COM_ACharacter_Rotate.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr, 100687499);
			COM_ACharacter_Rotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr, 100687500);
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00228A88 File Offset: 0x00226C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292686, XrefRangeEnd = 292701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Rotate.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00228AF0 File Offset: 0x00226CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Rotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Rotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Rotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x0004000A File Offset: 0x0003E20A
		public COM_ACharacter_Rotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600764E RID: 30286 RVA: 0x00228B2C File Offset: 0x00226D2C
		// (set) Token: 0x0600764F RID: 30287 RVA: 0x00040013 File Offset: 0x0003E213
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x00228B54 File Offset: 0x00226D54
		// (set) Token: 0x06007651 RID: 30289 RVA: 0x00040032 File Offset: 0x0003E232
		public unsafe DayScenePlayerInputGenerator.CharacterRotation targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Rotate.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x04004E54 RID: 20052
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E55 RID: 20053
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04004E56 RID: 20054
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E57 RID: 20055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
