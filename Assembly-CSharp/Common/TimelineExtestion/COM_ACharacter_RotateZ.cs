using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E5 RID: 997
	public class COM_ACharacter_RotateZ : PlayableAsset
	{
		// Token: 0x06007652 RID: 30290 RVA: 0x00228B7C File Offset: 0x00226D7C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_RotateZ()
		{
			Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_RotateZ");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr);
			COM_ACharacter_RotateZ.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr, "label");
			COM_ACharacter_RotateZ.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr, "targetValue");
			COM_ACharacter_RotateZ.NativeFieldInfoPtr_continuousRotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr, "continuousRotationZ");
			COM_ACharacter_RotateZ.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr, 100687501);
			COM_ACharacter_RotateZ.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr, 100687502);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00228C10 File Offset: 0x00226E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292701, XrefRangeEnd = 292718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_RotateZ.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00228C78 File Offset: 0x00226E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_RotateZ() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_RotateZ>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_RotateZ.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x0004004D File Offset: 0x0003E24D
		public COM_ACharacter_RotateZ(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06007656 RID: 30294 RVA: 0x00228CB4 File Offset: 0x00226EB4
		// (set) Token: 0x06007657 RID: 30295 RVA: 0x00040056 File Offset: 0x0003E256
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x06007658 RID: 30296 RVA: 0x00228CDC File Offset: 0x00226EDC
		// (set) Token: 0x06007659 RID: 30297 RVA: 0x00040075 File Offset: 0x0003E275
		public unsafe float targetValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_targetValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_targetValue)) = value;
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x00228D04 File Offset: 0x00226F04
		// (set) Token: 0x0600765B RID: 30299 RVA: 0x00040090 File Offset: 0x0003E290
		public unsafe bool continuousRotationZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_continuousRotationZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_RotateZ.NativeFieldInfoPtr_continuousRotationZ)) = value;
			}
		}

		// Token: 0x04004E58 RID: 20056
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeFieldInfoPtr_targetValue;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeFieldInfoPtr_continuousRotationZ;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
