using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000153 RID: 339
	public class DS_MoveToMap_AtWorldPos : PlayableAsset
	{
		// Token: 0x06002711 RID: 10001 RVA: 0x00120E80 File Offset: 0x0011F080
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MoveToMap_AtWorldPos()
		{
			Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MoveToMap_AtWorldPos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr);
			DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, "targetMapLabel");
			DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, "targetPosition");
			DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldCostAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, "shouldCostAction");
			DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldFadeInFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, "shouldFadeInFadeOut");
			DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_triggerEnterMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, "triggerEnterMapEvent");
			DS_MoveToMap_AtWorldPos.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, 100670242);
			DS_MoveToMap_AtWorldPos.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr, 100670243);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00120F3C File Offset: 0x0011F13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90762, XrefRangeEnd = 90783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MoveToMap_AtWorldPos.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00120FA4 File Offset: 0x0011F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MoveToMap_AtWorldPos() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MoveToMap_AtWorldPos.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0001706F File Offset: 0x0001526F
		public DS_MoveToMap_AtWorldPos(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00120FE0 File Offset: 0x0011F1E0
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00017078 File Offset: 0x00015278
		public unsafe string targetMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00121008 File Offset: 0x0011F208
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00017097 File Offset: 0x00015297
		public unsafe Vector2 targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_targetPosition)) = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00121030 File Offset: 0x0011F230
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x000170B2 File Offset: 0x000152B2
		public unsafe bool shouldCostAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldCostAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldCostAction)) = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00121058 File Offset: 0x0011F258
		// (set) Token: 0x0600271C RID: 10012 RVA: 0x000170CD File Offset: 0x000152CD
		public unsafe bool shouldFadeInFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldFadeInFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_shouldFadeInFadeOut)) = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00121080 File Offset: 0x0011F280
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x000170E8 File Offset: 0x000152E8
		public unsafe bool triggerEnterMapEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_triggerEnterMapEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos.NativeFieldInfoPtr_triggerEnterMapEvent)) = value;
			}
		}

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeFieldInfoPtr_targetMapLabel;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeFieldInfoPtr_shouldCostAction;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeFieldInfoPtr_shouldFadeInFadeOut;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeFieldInfoPtr_triggerEnterMapEvent;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
