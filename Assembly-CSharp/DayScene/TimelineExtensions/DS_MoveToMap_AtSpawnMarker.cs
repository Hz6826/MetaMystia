using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000152 RID: 338
	public class DS_MoveToMap_AtSpawnMarker : PlayableAsset
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x00120C58 File Offset: 0x0011EE58
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MoveToMap_AtSpawnMarker()
		{
			Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MoveToMap_AtSpawnMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr);
			DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, "targetMapLabel");
			DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, "targetMarkerName");
			DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldCostAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, "shouldCostAction");
			DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldFadeInFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, "shouldFadeInFadeOut");
			DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_triggerEnterMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, "triggerEnterMapEvent");
			DS_MoveToMap_AtSpawnMarker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, 100670240);
			DS_MoveToMap_AtSpawnMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr, 100670241);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00120D14 File Offset: 0x0011EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90739, XrefRangeEnd = 90761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MoveToMap_AtSpawnMarker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00120D7C File Offset: 0x0011EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90761, XrefRangeEnd = 90762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MoveToMap_AtSpawnMarker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MoveToMap_AtSpawnMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00016FD7 File Offset: 0x000151D7
		public DS_MoveToMap_AtSpawnMarker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x00120DB8 File Offset: 0x0011EFB8
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x00016FE0 File Offset: 0x000151E0
		public unsafe string targetMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x00120DE0 File Offset: 0x0011EFE0
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00016FFF File Offset: 0x000151FF
		public unsafe string targetMarkerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMarkerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_targetMarkerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00120E08 File Offset: 0x0011F008
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0001701E File Offset: 0x0001521E
		public unsafe bool shouldCostAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldCostAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldCostAction)) = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00120E30 File Offset: 0x0011F030
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00017039 File Offset: 0x00015239
		public unsafe bool shouldFadeInFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldFadeInFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_shouldFadeInFadeOut)) = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00120E58 File Offset: 0x0011F058
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00017054 File Offset: 0x00015254
		public unsafe bool triggerEnterMapEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_triggerEnterMapEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker.NativeFieldInfoPtr_triggerEnterMapEvent)) = value;
			}
		}

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr_targetMapLabel;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeFieldInfoPtr_targetMarkerName;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeFieldInfoPtr_shouldCostAction;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeFieldInfoPtr_shouldFadeInFadeOut;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr_triggerEnterMapEvent;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
