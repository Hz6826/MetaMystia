using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E8 RID: 1000
	public class COM_ACharacter_Shake : PlayableAsset
	{
		// Token: 0x0600766A RID: 30314 RVA: 0x00228FD8 File Offset: 0x002271D8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Shake()
		{
			Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Shake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr);
			COM_ACharacter_Shake.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, "label");
			COM_ACharacter_Shake.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, "amplitude");
			COM_ACharacter_Shake.NativeFieldInfoPtr_timeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, "timeLength");
			COM_ACharacter_Shake.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Shake.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, 100687507);
			COM_ACharacter_Shake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr, 100687508);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00229080 File Offset: 0x00227280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292745, XrefRangeEnd = 292764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Shake.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x002290E8 File Offset: 0x002272E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292764, XrefRangeEnd = 292765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Shake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Shake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Shake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00040112 File Offset: 0x0003E312
		public COM_ACharacter_Shake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x00229124 File Offset: 0x00227324
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x0004011B File Offset: 0x0003E31B
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x0022914C File Offset: 0x0022734C
		// (set) Token: 0x06007671 RID: 30321 RVA: 0x0004013A File Offset: 0x0003E33A
		public unsafe Vector2 amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x00229174 File Offset: 0x00227374
		// (set) Token: 0x06007673 RID: 30323 RVA: 0x00040155 File Offset: 0x0003E355
		public unsafe float timeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_timeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_timeLength)) = value;
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x0022919C File Offset: 0x0022739C
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x00040170 File Offset: 0x0003E370
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Shake.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004E64 RID: 20068
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E65 RID: 20069
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004E66 RID: 20070
		private static readonly IntPtr NativeFieldInfoPtr_timeLength;

		// Token: 0x04004E67 RID: 20071
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004E68 RID: 20072
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E69 RID: 20073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
